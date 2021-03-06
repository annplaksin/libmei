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
    /// <keyAccid/>
    /// </summary>
    public class KeyAccid : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttCommonAnl, IAttAlignment, IAttAccidental, IAttPitch, IAttOctave, IAttAltsym, IAttEnclosingchars, IAttExtsym, IAttStaffloc, IAttTypography, IAttXy
    {
        
        public KeyAccid() : base("keyAccid") { }

        public KeyAccid(object _content) : base("keyAccid", _content) { }

        public KeyAccid(params object[] _content) : base("keyAccid", _content) { }


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

    }
}
