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
    /// <pgFoot/>
    /// </summary>
    public class PgFoot : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttLang, IAttTyped
    {
        
        public PgFoot() : base("pgFoot") { }

        public PgFoot(object _content) : base("pgFoot", _content) { }

        public PgFoot(params object[] _content) : base("pgFoot", _content) { }


        #region halign
    
    public void SetHalign(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "halign", _val);
    }

    public XAttribute GetHalign()
    {
      return MeiAtt_controller.GetAttribute(this, "halign");
    }

    public bool HasHalign()
    {
      return MeiAtt_controller.HasAttribute(this, "halign");
    }

    public void RemoveHalign()
    {
      MeiAtt_controller.RemoveAttribute(this, "halign");
    }
    #endregion

    }
}
