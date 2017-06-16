using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei.atts
{
  /// <summary>
  /// Interface for att.common
  /// </summary>
  interface IAttCommon : IMEiAtt, IAttCommonPart
  {

  }

  /// <summary>
  /// Extension methods for att.common
  /// </summary>
  static class AttCommon_extensions
  {
    #region n
    public static void SetN(this IAttCommon e, string _val)
    {
      e.SetAttribute("n", _val);

    }

    public static XAttribute GetN(this IAttCommon e)
    {
      return e.GetAttribute("n");

    }

    public static bool HasN(this IAttCommon e)
    {
      return e.HasAttribute("n");
    }

    public static void RemoveN(this IAttCommon e)
    {
      e.RemoveAttribute("n");
    }
    #endregion
  }
}
