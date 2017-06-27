using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace mei
{
  public static class MeiImport
  {
    public static void ImportDocument(string _filePath)
    {
      XDocument doc = XDocument.Load(_filePath);
      XDeclaration xml_decl = doc.Declaration;

      //ReadProcessingInstructions()

      XElement root = doc.Root;
      //XmlToMei(root)

      //CreateMeiDocument(xml_decl, root, schemaLocation);

    }

    //ImportString()

    //XML-Struktur transformieren: XmlToMei()

    //Processing Instructions auslesen: ReadProcessingInstructions()
    private static string ReadProcessingInstructions(XDocument _doc, out IEnumerable<XProcessingInstruction> _otherPIs)
    {
      string schemaLocation = "";

      List<string> schemaLocs = new List<string>();

      IEnumerable<XProcessingInstruction> pIs = (from node in _doc.Nodes().OfType<XProcessingInstruction>() select node);

      Match hrefs;

      foreach (XProcessingInstruction pImodel in pIs.Where(pI => pI.Target == "xml-model"))
      {
        //Get schemaLocation from pImodel.Data
        //See example here: https://msdn.microsoft.com/de-de/library/t9e807fx(v=vs.110).aspx

        string HRefPattern = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";

        try
        {
          hrefs = Regex.Match(pImodel.Data, HRefPattern,
                      RegexOptions.IgnoreCase | RegexOptions.Compiled,
                      TimeSpan.FromSeconds(1));
          while(hrefs.Success)
          {
            schemaLocs.Add(hrefs.Groups[1].ToString());
            hrefs = hrefs.NextMatch();
          }
        }

        catch(RegexMatchTimeoutException)
        {
          break;
        }

      }

      //if all extracted strings are equal, set schemaLocation
      if (schemaLocs.Count > 0 && schemaLocs.Where(loc => loc == schemaLocs[0]).Count() == schemaLocs.Count)
      {
        schemaLocation = schemaLocs[0];
        _otherPIs = pIs.Where(pI => pI.Target != "xml-model");
      }
      else
      {
        _otherPIs = pIs;
      }

      

      return schemaLocation;
    }

    //MeiDocument erzeugen: CreateMeiDocument()
  }
}
