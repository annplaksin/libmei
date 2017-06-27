﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei
{
  public class MeiDocument : XDocument
  {
    /// <summary>
    /// Location of Schema to link with document
    /// </summary>
    public string SchemaLocation { get; private set;}

    /// <summary>
    /// MEI version label
    /// </summary>
    public string MeiVersion { get; set; }

    /// <summary>
    /// Constructor with content and schema location
    /// </summary>
    /// <param name="_root">Content root node</param>
    /// <param name="_schemaLocation">Location of MEI schema to link</param>
    internal MeiDocument(MeiElement _root, string _schemaLocation) : base(_root)
    {
      this.SchemaLocation = _schemaLocation;
      WriteSchemaProcessingInstructions();

      this.MeiVersion = _root.Attribute("meiversion").Value;
    }

    /// <summary>
    /// Constructor with content
    /// </summary>
    /// <param name="_root">Content root node</param>
    internal MeiDocument(MeiElement _root) : base(_root)
    {
      this.MeiVersion = _root.Attribute("meiversion").Value;
    }

    /// <summary>
    /// Constructor with xml declaration, content, and schema location
    /// Use to create an MeiDocument from an existing parsed XDocument
    /// </summary>
    /// <param name="_xmldecl">Xml declaration</param>
    /// <param name="_root">Content root node</param>
    /// <param name="_schemaLocation">Location of MEI schema to link</param>
    internal MeiDocument(XDeclaration _xmldecl, MeiElement _root, string _schemaLocation) : base (_xmldecl, _root)
    {
      this.SchemaLocation = _schemaLocation;
      WriteSchemaProcessingInstructions();

      this.MeiVersion = _root.Attribute("meiversion").Value;
    }

    /// <summary>
    /// Constructor with xml declaration and content
    /// Use to create an MeiDocument from an existing parsed XDocument
    /// </summary>
    /// <param name="_xmldecl">Xml declaration</param>
    /// <param name="_root">Content root node</param>
    internal MeiDocument(XDeclaration _xmldecl, MeiElement _root) : base(_xmldecl, _root)
    {
      this.MeiVersion = _root.Attribute("meiversion").Value;
    }

    /// <summary>
    /// Writes MeiVersion property as mei/@meiversion
    /// </summary>
    public void WriteMeiVersion()
    {
      if (this.MeiVersion != null)
      {
        //Add MeiVersion as @meiversion to document root <mei>
      }
    }

    /// <summary>
    /// Overwrites schema location of the document and creates the processing instructions
    /// </summary>
    /// <param name="_schemaLocation">location of MEI schema</param>
    public void SetSchemaLocation(string _schemaLocation)
    {
      this.SchemaLocation = _schemaLocation;
      WriteSchemaProcessingInstructions();
    }

    /// <summary>
    /// Writes processing instructions to add the MEI schema at the given schema location to the MeiDocument
    /// </summary>
    private void WriteSchemaProcessingInstructions()
    {
      if (this.SchemaLocation != null)
      {
        XProcessingInstruction rng = new XProcessingInstruction("xml-model", string.Format("href='{0}' type='application/xml' schematypens='http://relaxng.org/ns/structure/1.0'", this.SchemaLocation));
        XProcessingInstruction schematron = new XProcessingInstruction("xml-model", string.Format("href='{0}' type='application / xml' schematypens='http://purl.oclc.org/dsdl/schematron'", this.SchemaLocation));

        Root.AddBeforeSelf(rng);
        Root.AddBeforeSelf(schematron);
      }
    }

  }
}
