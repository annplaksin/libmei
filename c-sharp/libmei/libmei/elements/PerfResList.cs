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
    /// <perfResList/>
    /// </summary>
    public class PerfResList : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttCanonical, IAttResponsibility, IAttSource, IAttEvidence, IAttLang
    {
        
        public PerfResList() : base("perfResList") { }

        public PerfResList(object _content) : base("perfResList", _content) { }

        public PerfResList(params object[] _content) : base("perfResList", _content) { }


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

    }
}
