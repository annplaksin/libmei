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
    /// <perfRes/>
    /// </summary>
    public class PerfRes : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttCanonical, IAttResponsibility, IAttSource, IAttEvidence, IAttLang
    {
        
        public PerfRes() : base("perfRes") { }

        public PerfRes(object _content) : base("perfRes", _content) { }

        public PerfRes(params object[] _content) : base("perfRes", _content) { }


        #region count
    
    public void SetCount(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "count", _val);
    }

    public XAttribute GetCount()
    {
      return MeiAtt_controller.GetAttribute(this, "count");
    }

    public bool HasCount()
    {
      return MeiAtt_controller.HasAttribute(this, "count");
    }

    public void RemoveCount()
    {
      MeiAtt_controller.RemoveAttribute(this, "count");
    }
    #endregion

        #region solo
    
    public void SetSolo(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "solo", _val);
    }

    public XAttribute GetSolo()
    {
      return MeiAtt_controller.GetAttribute(this, "solo");
    }

    public bool HasSolo()
    {
      return MeiAtt_controller.HasAttribute(this, "solo");
    }

    public void RemoveSolo()
    {
      MeiAtt_controller.RemoveAttribute(this, "solo");
    }
    #endregion

    }
}
