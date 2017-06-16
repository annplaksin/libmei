using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using mei.atts;

namespace mei.atts
{
  /// <summary>
  /// Interface for att.id
  /// </summary>
  interface IAttId : IMEiAtt
  {

  }
  
  /// <summary>
  /// Extension methods for att.id
  /// </summary>
  static class AttId_extensions
  {
    #region xml:id
    public static void SetId(this IAttId e, string _val)
    {
      e.SetAttribute("xml:id", _val);

    }

    public static XAttribute GetId(this IAttId e)
    {
      return e.GetAttribute("xml:id");

    }

    public static bool HasId(this IAttId e)
    {
      return e.HasAttribute("xml:id");
    }

    public static void RemoveId(this IAttId e)
    {
      e.RemoveAttribute("xml:id");
    }
    #endregion
  }
}
