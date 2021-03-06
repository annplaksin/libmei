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
    /// <restore/>
    /// </summary>
    public class Restore : MeiElement, IAttCommon, IAttCommonPart, IAttResponsibility, IAttSource, IAttEvidence, IAttFacsimile, IAttLang, IAttHandident, IAttSequence, IAttTyped
    {
        
        public Restore() : base("restore") { }

        public Restore(object _content) : base("restore", _content) { }

        public Restore(params object[] _content) : base("restore", _content) { }


        #region desc
    
    public void SetDesc(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "desc", _val);
    }

    public XAttribute GetDesc()
    {
      return MeiAtt_controller.GetAttribute(this, "desc");
    }

    public bool HasDesc()
    {
      return MeiAtt_controller.HasAttribute(this, "desc");
    }

    public void RemoveDesc()
    {
      MeiAtt_controller.RemoveAttribute(this, "desc");
    }
    #endregion

    }
}
