using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/////////////////////////////////////////////////////////////////////////////
// Authors:     Anna Plaksin
// Created:     2017
// Copyright (c) Authors and others. All rights reserved.
//
// Code generated using a modified version of libmei
// by Andrew Hankinson, Alastair Porter, and Others
/////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////////////
// NOTE: this file was generated with the Verovio libmei version and
// should not be edited because changes will be lost.
/////////////////////////////////////////////////////////////////////////////

namespace mei
{
    /// <summary>
    /// <name/>
    /// </summary>
    public class Name : MeiElement, IAttBibl, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttFacsimile, IAttLang, IAttName, IAttAuthorized, IAttCanonical, IAttDatable, IAttFiling
    {
        
        public Name() : base("name") { }

        public Name(object _content) : base("name", _content) { }

        public Name(params object[] _content) : base("name", _content) { }


        #region typeAttribute
    
    public void SetTypeAttribute(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "type", _val);
    }

    public XAttribute GetTypeAttribute()
    {
      return MeiAtt_controller.GetAttribute(this, "type");
    }

    public bool HasTypeAttribute()
    {
      return MeiAtt_controller.HasAttribute(this, "type");
    }

    public void RemoveTypeAttribute()
    {
      MeiAtt_controller.RemoveAttribute(this, "type");
    }
    #endregion

        #region subtype
    
    public void SetSubtype(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "subtype", _val);
    }

    public XAttribute GetSubtype()
    {
      return MeiAtt_controller.GetAttribute(this, "subtype");
    }

    public bool HasSubtype()
    {
      return MeiAtt_controller.HasAttribute(this, "subtype");
    }

    public void RemoveSubtype()
    {
      MeiAtt_controller.RemoveAttribute(this, "subtype");
    }
    #endregion

    }
}
