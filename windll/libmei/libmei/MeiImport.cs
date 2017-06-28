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
    /// <summary>
    /// Imports an Xml file and loads the content into Mei
    /// </summary>
    /// <param name="_filePath">Path of Xml file to import</param>
    public static void ImportDocument(string _filePath)
    {
      XDocument doc = XDocument.Load(_filePath);
      XDeclaration xml_decl = doc.Declaration;

      //Enum for processing instructions
      IEnumerable<XProcessingInstruction> pIs = Enumerable.Empty<XProcessingInstruction>();

      //ReadProcessingInstructions()
      string schemaLocation = ReadProcessingInstructions(doc, out pIs);

      XElement root = doc.Root;
      MeiElement convertedRoot = XmlToMei(root);

      CreateMeiDocument(xml_decl, convertedRoot, schemaLocation, pIs);

    }

    //ImportString() tbc

    /// <summary>
    /// Converts a tree of XElements into Mei
    /// </summary>
    /// <param name="_node">XElement with content</param>
    /// <returns>Mei element with content</returns>
    private static MeiElement XmlToMei(XElement _node)
    {
      //Invoke-Voodoo o_O
      //MeiElement bla = (MeiElement)Type.GetType(XElement.Name.LocalName, true).GetConstructor(new Type[] { }).Invoke(new object[] { });

      foreach (XElement element in _node.DescendantsAndSelf())
      {

      }
    }

    /// <summary>
    /// Reads processing instructions of the loaded file and looks for the schema uri. 
    /// If no single uri is extractable, it returnes all processing instructions
    /// </summary>
    /// <param name="_doc">Loaded XDocument</param>
    /// <param name="_otherPIs">Processing instrucions without detectable schema uri</param>
    /// <returns>Schema uri string</returns>
    private static string ReadProcessingInstructions(XDocument _doc, out IEnumerable<XProcessingInstruction> _otherPIs)
    {
      string schemaLocation = "";

      List<string> schemaLocs = new List<string>();

      IEnumerable<XProcessingInstruction> pIs = (from node in _doc.Nodes().OfType<XProcessingInstruction>() select node);

      Match hrefs;

      //Extract href value from all xml-model processing instructions into a list
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
      // else, return every processing instruction and leave schemaLocation empty
      else
      {
        _otherPIs = pIs;
      }
      
      return schemaLocation;
    }

    /// <summary>
    /// Creates an MeiDocument with content, declarations, and processing instructions
    /// </summary>
    /// <param name="_xmlDecl">Xml declaration of imported document</param>
    /// <param name="_root">Transfomed Mei tree</param>
    /// <param name="_schemaLoc">Schema location</param>
    /// <param name="_pIs">Other processing instructions</param>
    private static void CreateMeiDocument(XDeclaration _xmlDecl, MeiElement _root, string _schemaLoc, IEnumerable<XProcessingInstruction> _pIs)
    {
      MeiDocument meiDoc = new MeiDocument(_xmlDecl, _root, _schemaLoc);

      meiDoc.Add(_pIs);

    }
  }
}
