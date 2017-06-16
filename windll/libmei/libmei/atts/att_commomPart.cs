using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei.atts
{
  /// <summary>
  /// Interface for att.commonPart
  /// </summary>
  interface IAttCommonPart : IMEiAtt, IAttId
  {

  }

  /// <summary>
  /// Extension methods for att.commonPart
  /// </summary>
  static class AttCommomPart_extensions
  {
    #region label
    public static void SetLabel(this IAttCommonPart e, string _val)
    {
      e.SetAttribute("label", _val);

    }

    public static XAttribute GetLabel(this IAttCommonPart e)
    {
      return e.GetAttribute("label");

    }

    public static bool HasLabel(this IAttCommonPart e)
    {
      return e.HasAttribute("label");
    }

    public static void RemoveLabel(this IAttCommonPart e)
    {
      e.RemoveAttribute("label");
    }
    #endregion

    #region xml:base
    public static void SetBase(this IAttCommonPart e, string _val)
    {
      e.SetAttribute("xml:base", _val);

    }

    public static XAttribute GetBase(this IAttCommonPart e)
    {
      return e.GetAttribute("xml:base");

    }

    public static bool HasBase(this IAttCommonPart e)
    {
      return e.HasAttribute("xml:base");
    }

    public static void RemoveBase(this IAttCommonPart e)
    {
      e.RemoveAttribute("xml:base");
    }
    #endregion

  }
}
