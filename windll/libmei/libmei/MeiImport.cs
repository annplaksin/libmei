﻿using System;
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

    //public ImportString() tbc

    /// <summary>
    /// Converts a tree of XElements into Mei
    /// </summary>
    /// <param name="_node">XElement with content</param>
    /// <returns>Mei element with content</returns>
    public static MeiElement XmlToMei(XElement _node)
    {
      

      //Start recursive method
      return (MeiElement)CreateNode(_node);
    }

    /// <summary>
    /// Creates node for an MEI document.
    /// If XObject is an element, it tries to create an MeiElement from it. If it fails or in all other cases, it copies the node.
    /// </summary>
    /// <param name="_node">XObject to convert</param>
    /// <returns>Node and descendants</returns>
    private static XObject CreateNode(XObject _node)
    {
      XObject node;

      if (_node is XElement element)
      {
        XElement elementNode;

        //Try invokation voodoo to create MEI object from XElement
        try
        {
           elementNode = (MeiElement)Type.GetType("mei." + element.Name.LocalName, true, true).GetConstructor(new Type[] {  }).Invoke(new object[] {  });
        }
        //If failing, create new XElement
        catch
        {
          elementNode = new XElement(element.Name);
        }

        //Process attributes
        foreach(XAttribute att in element.Attributes())
        {
          elementNode.Add(CreateNode(att));
        }

        //Process child nodes
        foreach (XNode child in element.Nodes())
        {
          elementNode.Add(CreateNode(child));
        }

        node = elementNode;

      }
      //Every non-element node will be copied
      else
      {
        node = _node;
      }

      return node;
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
