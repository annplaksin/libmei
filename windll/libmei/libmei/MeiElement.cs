using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei
{
  public abstract class MeiElement : XElement
  {
    public static readonly XNamespace meins = "http://www.music-encoding.org/ns/mei";

    public string ID { get; set; } = null;

    /// <summary>
    /// Constroctor with MEI namespace
    /// </summary>
    /// <param name="_name"></param>
    public MeiElement(string _name) : base(meins + _name)
    {
      this.GenerateAndSetID();
    }

    /// <summary>
    /// Constructor with explicit namespace
    /// </summary>
    /// <param name="_name"></param>
    /// <param name="_namespace"></param>
    protected MeiElement(string _name, XNamespace _namespace) : base (_namespace + _name)
    {
      this.GenerateAndSetID();
    }

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

    //GetValue(_bla) available as this.Value

    //SetValue(_bla) is already available as XElement.SetValue (object value)
  }
}
