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
    public static void SetAttribute(this IMEiAtt e, string _name, string _val)
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

    public static XAttribute GetAttribute(this IMEiAtt e, string _name)
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

    public static bool HasAttribute(this IMEiAtt e, string _name)
    {
      return (e.Attributes(_name).Count() > 0);
    }

    public static void RemoveAttribute(this IMEiAtt e, string _name)
    {
      if (e.HasAttribute(_name))
      {
        e.Attribute(_name).Remove();
      }
    }
  }
}
