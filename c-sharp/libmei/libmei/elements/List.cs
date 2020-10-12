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
    /// <list/>
    /// </summary>
    public class List : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttLang, IAttXy
    {
        
        public List() : base("list") { }

        public List(object _content) : base("list", _content) { }

        public List(params object[] _content) : base("list", _content) { }


        #region form
    
    public void SetForm(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "form", _val);
    }

    public XAttribute GetForm()
    {
      return MeiAtt_controller.GetAttribute(this, "form");
    }

    public bool HasForm()
    {
      return MeiAtt_controller.HasAttribute(this, "form");
    }

    public void RemoveForm()
    {
      MeiAtt_controller.RemoveAttribute(this, "form");
    }
    #endregion

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

    }
}
