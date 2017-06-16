using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei
{
  /// <summary>
  /// Basic interface for all attribute class interfaces
  /// </summary>
  interface IMEiAtt
  {
    void Add(Object obj);

    XAttribute Attribute(XName name);

    IEnumerable<XAttribute> Attributes(XName name);
    
  }

  /// <summary>
  /// Basis extension class for all attribute class extension classes
  /// </summary>
  static class MeiAtt_extensions
  {
    #region SetAttribute
    /// <summary>
    /// Sets the value of an attribute by name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_val">value to set</param>
    public static void SetAttribute(this IMEiAtt e, string _name, string _val)
    {
      if (_name.StartsWith("xml:"))
      {
        e.SetAttribute(_name, XNamespace.Xml, _val);
      }
      else
      {
        if (e.HasAttribute(_name))
        {
          e.Attribute(_name).SetValue(_val);
        }
        else
        {
          e.Add(new XAttribute(_name, _val));
        }
      }
    }

    /// <summary>
    /// Sets the value of an attribute by name and namespace
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    /// <param name="_val">value to set</param>
    public static void SetAttribute(this IMEiAtt e, string _name, XNamespace _ns, string _val)
    {
      if (e.HasAttribute(_name, _ns))
      {
        e.Attribute(_ns + _name).SetValue(_val);
      }
      else
      {
        e.Add(new XAttribute(_ns + _name, _val));
      }
    }
    #endregion

    #region GetAttribute
    /// <summary>
    /// Get an attribute from an element by name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <returns></returns>
    public static XAttribute GetAttribute(this IMEiAtt e, string _name)
    {
      if (_name.StartsWith("xml:"))
      {
        return e.GetAttribute(_name, XNamespace.Xml);
      }
      else
      {
        if (e.HasAttribute(_name))
        {
          return e.Attribute(_name);
        }
        else
        {
          return null;
        }
      }
    }

    /// <summary>
    /// Get an attribute from an element by name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    /// <returns></returns>
    public static XAttribute GetAttribute(this IMEiAtt e, string _name, XNamespace _ns)
    {
      if (e.HasAttribute(_name, _ns))
      {
        return e.Attribute(_ns + _name);
      }
      else
      {
        return null;
      }

    }
    #endregion

    #region HasAttribute
    /// <summary>
    /// Checks if element has an attribute with defined name
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <returns></returns>
    public static bool HasAttribute(this IMEiAtt e, string _name)
    {
      if (_name.StartsWith("xml:"))
      {
        return e.HasAttribute(_name, XNamespace.Xml);
      }
      else
      {
        return (e.Attributes(_name).Count() > 0);
      }
    }

    /// <summary>
    /// Checks if element has an attribute with defined name and namespace
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    /// <returns></returns>
    public static bool HasAttribute(this IMEiAtt e, string _name, XNamespace _ns)
    {
      return (e.Attributes(_ns + _name).Count() > 0);
    }
    #endregion

    #region RemoveAttribute()
    /// <summary>
    /// Removes attribute
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">Name of attribute</param>
    public static void RemoveAttribute(this IMEiAtt e, string _name)
    {
      if (_name.StartsWith("xml:"))
      {
        e.RemoveAttribute(_name, XNamespace.Xml);
      }
      else
      {
        if (e.HasAttribute(_name))
        {
          e.Attribute(_name).Remove();
        }
      }
    }

    /// <summary>
    /// Removes namespaced attribute
    /// </summary>
    /// <param name="e">element</param>
    /// <param name="_name">name of attribute</param>
    /// <param name="_ns">namespace of attribute</param>
    public static void RemoveAttribute(this IMEiAtt e, string _name, XNamespace _ns)
    {
      if (e.HasAttribute(_name, _ns))
      {
        e.Attribute(_ns + _name).Remove();
      }
    }
    #endregion
  }
}
