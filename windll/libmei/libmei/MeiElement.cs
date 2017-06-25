using mei.atts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei
{
  public abstract class MeiElement : XElement, IAttId
  {
    public static readonly XNamespace meins = "http://www.music-encoding.org/ns/mei";

    public string ID { get; set; } = null;

    #region Constructors
    /// <summary>
    /// Constroctor with MEI namespace
    /// </summary>
    /// <param name="_name">name of element</param>
    public MeiElement(string _name) : base(meins + _name)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with MEI namespace and content
    /// </summary>
    /// <param name="_name">name of element</param>
    /// <param name="_content">content of element</param>
    public MeiElement(string _name, object _content) : base(meins + _name, _content)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with explicit namespace
    /// </summary>
    /// <param name="_namespace">namespace of element</param>
    /// <param name="_name">name of element</param>
    protected MeiElement(XNamespace _namespace, string _name) : base (_namespace + _name)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with explicit namespace and content
    /// </summary>
    /// <param name="_namespace">namespace of element</param>
    /// <param name="_name">name of element</param>
    /// <param name="_content">content of element</param>
    protected MeiElement(XNamespace _namespace, string _name, object _content) : base (_namespace + _name, _content)
    {
      this.GenerateAndSetID();
    }
    #endregion

    private void GenerateAndSetID()
    {
      if(ID == null)
      {
        ID = string.Concat("m-", Guid.NewGuid().ToString().ToLower());
      }
    }

    public string GetName()
    {
      return this.Name.LocalName;
    }

    //GetValue(_bla) -> this.Value

    //SetValue(_bla) -> XElement.SetValue (object value)

    //getTail & setTail are not available... no proper handling of mixed content in Linq to Xml

    #region obfuscated XElement methods
    /*
     * Makes the axis methods of XElement available within libmei and masks the XElement.Name with MEI object types.
     * E.G.: beam_object.Elements<Note>() returns all children Note objects of this Beam object.
     */

    /// <summary>
    /// Return collection of ancestors of the given type
    /// Obfuscation of Ancestors(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of ancestor elements of the given type</returns>
    public IEnumerable<MeiElement> Ancestors<T>() where T : MeiElement
    {
      return (IEnumerable<MeiElement>)this.Ancestors().Where(element => element is T);
    }

    /// <summary>
    /// Return collection of ancestors (including self) of the given type
    /// Obfuscation of AncestorsAndSelf(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of ancestor elements of the given type</returns>
    public IEnumerable<MeiElement> AncestorsAndSelf<T>() where T : MeiElement
    {
      return (IEnumerable<MeiElement>)this.AncestorsAndSelf().Where(element => element is T);
    }

    /// <summary>
    /// Return collection of descendants of the given type
    /// Obfuscation of Descendants(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of descendants elements of the given type</returns>
    public IEnumerable<MeiElement> Descendants<T>() where T : MeiElement
    {
      return (IEnumerable<MeiElement>)this.Descendants().Where(element => element is T);
    }

    /// <summary>
    /// Return collection of descendants (including self) of the given type
    /// Obfuscation of DescendantsAndSelf(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of descendants elements of the given type</returns>
    public IEnumerable<MeiElement> DescendantsAndSelf<T>() where T : MeiElement
    {
      return (IEnumerable<MeiElement>)this.DescendantsAndSelf().Where(element => element is T);
    }

    /// <summary>
    /// Returns the first child element with specific type
    /// Workaround for Element(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>first child MeiElement</returns>
    public MeiElement Element<T>() where T : MeiElement
    {
      return (MeiElement)this.Elements().FirstOrDefault(element => element is T);
    }

    /// <summary>
    /// Return collection of child elements of the given type
    /// Obfuscation of Elements(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of child elements of the given type</returns>
    public IEnumerable<MeiElement> Elements<T>() where T : MeiElement
    {
      return (IEnumerable<MeiElement>)this.Elements().Where(element => element is T);
    }

    /// <summary>
    /// Return collection of sibling elements of the given type after the current node
    /// Obfuscation of ElementsAfterSelf(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of sibling elements of the given type</returns>
    public IEnumerable<MeiElement> ElementsAfterSelf<T>() where T : MeiElement
    {
      return (IEnumerable<MeiElement>)this.ElementsAfterSelf().Where(element => element is T);
    }

    /// <summary>
    /// Return collection of sibling elements of the given type before the current node
    /// Obfuscation of Elements(XName)
    /// </summary>
    /// <typeparam name="T">type of MeiElement</typeparam>
    /// <returns>collection of sibling elements of the given type</returns>
    public IEnumerable<MeiElement> ElementsBeforeSelf<T>() where T : MeiElement
    {
      return (IEnumerable<MeiElement>)this.ElementsBeforeSelf().Where(element => element is T);
    }
    #endregion

    #region Attribute methods
    //getAttributes() -> XElement.Attributes()

    //setAttributes() -> within constructor or: for each (att in atts( {element.Add(att);} and 

    //setAttribute() XElement.SetAttributeValue(XName, Object)

    //addAttribute() -> XElement.Add(attribute)
    #endregion

    #region Parent methods
    //getParent() -> this.Parent

    /// <summary>
    /// Changes parent of current element
    /// </summary>
    /// <param name="_parent">new parent node</param>
    protected void SetParent(XElement _parent)
    {
      //Remove current element from its parent
      this.Remove();

      //Add current element to new parent node
      _parent.Add(this);
    }

    /// <summary>
    /// Checks for parent of an element
    /// </summary>
    /// <returns>true if element has parent</returns>
    protected bool HasParent()
    {
      return (this.Parent != null) ;
    }
    #endregion

    #region Children methods
    //addChild(MeiElement* child) -> this.Add(child)

    //XElement.SetElementValue(XName, Object)

    /**
     * \brief Add an element as a child before the specifed element.
     */
    //addChildBefore(MeiElement* before, MeiElement* child) -> this.

    /**
     * \brief set the children of this element to be the given children.
     *
     * This will remove any existing children.
     */
    //void setChildren(std::vector<MeiElement*> children);

    /**
     * \brief Get all of the children of this element.
     */
    //const std::vector<MeiElement*>& getChildren();

    /**
     * \brief Get all of the children of this element that have a given name.
     */
    //const std::vector<MeiElement*> getChildrenByName(std::string name);

    /**
     * \brief Remove all of the children of this element.
     *
     * The children are deleted and removed from the element.
     */
    //void deleteAllChildren();

    /**
     * \brief Remove the children from this element that have a given name.
     */
    //void removeChildrenByName(std::string cname);

    /**
     * \brief Remove the specified element as a child from this element.
     *
     * Elements are compared by memory address. It is the responsibility
     * of the caller to free elements after they have been removed.
     */
    //void removeChild(MeiElement* child);
    

    //hasChildren -> this.HasElements

    /**
     * \brief Check if this element has any children with the given name.
     */
    //bool hasChildren(std::string cname);

    #endregion
  }
}
