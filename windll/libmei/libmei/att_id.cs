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
  public interface IAttId : IMEiAtt
  {

  }
  
  /// <summary>
  /// Extension methods for att.id
  /// </summary>
  public static class AttId_extensions
  {
    #region xml:id
    public static void SetId(this IAttId e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xml:id", _val);

    }

    public static XAttribute GetId(this IAttId e)
    {
      return MeiAtt_controller.GetAttribute(e, "xml:id");

    }

    public static bool HasId(this IAttId e)
    {
      return MeiAtt_controller.HasAttribute(e, "xml:id");
    }

    public static void RemoveId(this IAttId e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xml:id");
    }
    #endregion
  }
}
