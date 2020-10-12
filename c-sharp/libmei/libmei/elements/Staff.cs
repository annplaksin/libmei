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
    /// <staff/>
    /// </summary>
    public class Staff : MeiElement, IAttCommonPart, IAttDeclaring, IAttFacsimile, IAttStaffLog, IAttMeterconformance, IAttVisibility, IAttCommonAnl, IAttAlignment
    {
        
        public Staff() : base("staff") { }

        public Staff(object _content) : base("staff", _content) { }

        public Staff(params object[] _content) : base("staff", _content) { }


        #region n
    
    public void SetN(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "n", _val);
    }

    public XAttribute GetN()
    {
      return MeiAtt_controller.GetAttribute(this, "n");
    }

    public bool HasN()
    {
      return MeiAtt_controller.HasAttribute(this, "n");
    }

    public void RemoveN()
    {
      MeiAtt_controller.RemoveAttribute(this, "n");
    }
    #endregion

    }
}
