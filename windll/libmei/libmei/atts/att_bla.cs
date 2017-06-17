using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei.atts
{

  /*
   * Hier stellt sich eine ganz besondere Frage...
   * Wie geht man mit Attributen mit explizit deklarierten abweichenden Namespaces um?
   * 
   * Beispiel:
   * <classSpec ident="att.lyricstype" module="MEI.sourceEncoding" type="atts" mode="add">
          <desc>Attributes to classify lyrics</desc>
          <attList>
            <attDef ident="lyric-type" usage="opt" mode="add" ns="http://github.com/annplaksin/mensural_sourceEncoding">
              <desc>Classifies the type of a lyric portion in a source.</desc>
              <valList type="closed">
                <valItem ident="full"><desc>full lyrics below stave</desc></valItem>
                <valItem ident="incipit"><desc>only text incipit given</desc></valItem>
                <valItem ident="additional"><desc>additional lyrics independent of staves</desc></valItem>
              </valList>
            </attDef>
          </attList>
        </classSpec>
   */

  /// <summary>
  /// Interface for att.id
  /// </summary>
  interface IAttBla : IMEiAtt
  {
    
  }

  /// <summary>
  /// Extension methods for att.id
  /// </summary>
  static class AttBla_extensions
  {
    #region bla:bla
    private static readonly XNamespace ns_bla = "http://github.com/annplaksin/bla";

    public static void SetBla(this IAttBla e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "bla", ns_bla, _val);
    }

    public static XAttribute GetBla(this IAttBla e)
    {
      return MeiAtt_controller.GetAttribute(e, "bla", ns_bla);
    }

    public static bool HasBla(this IAttBla e)
    {
      return MeiAtt_controller.HasAttribute(e, "bla", ns_bla);
    }

    public static void RemoveBla(this IAttBla e)
    {
      MeiAtt_controller.RemoveAttribute(e, "bla", ns_bla);
    }
    #endregion
  }
}
