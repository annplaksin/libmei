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
    /// <when/>
    /// </summary>
    public class When : MeiElement, IAttCommon, IAttCommonPart, IAttDatapointing
    {
        
        public When() : base("when") { }

        public When(object _content) : base("when", _content) { }

        public When(params object[] _content) : base("when", _content) { }


        #region absolute
    
    public void SetAbsolute(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "absolute", _val);
    }

    public XAttribute GetAbsolute()
    {
      return MeiAtt_controller.GetAttribute(this, "absolute");
    }

    public bool HasAbsolute()
    {
      return MeiAtt_controller.HasAttribute(this, "absolute");
    }

    public void RemoveAbsolute()
    {
      MeiAtt_controller.RemoveAttribute(this, "absolute");
    }
    #endregion

        #region interval
    
    public void SetInterval(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "interval", _val);
    }

    public XAttribute GetInterval()
    {
      return MeiAtt_controller.GetAttribute(this, "interval");
    }

    public bool HasInterval()
    {
      return MeiAtt_controller.HasAttribute(this, "interval");
    }

    public void RemoveInterval()
    {
      MeiAtt_controller.RemoveAttribute(this, "interval");
    }
    #endregion

        #region abstype
    
    public void SetAbstype(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "abstype", _val);
    }

    public XAttribute GetAbstype()
    {
      return MeiAtt_controller.GetAttribute(this, "abstype");
    }

    public bool HasAbstype()
    {
      return MeiAtt_controller.HasAttribute(this, "abstype");
    }

    public void RemoveAbstype()
    {
      MeiAtt_controller.RemoveAttribute(this, "abstype");
    }
    #endregion

        #region inttype
    
    public void SetInttype(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "inttype", _val);
    }

    public XAttribute GetInttype()
    {
      return MeiAtt_controller.GetAttribute(this, "inttype");
    }

    public bool HasInttype()
    {
      return MeiAtt_controller.HasAttribute(this, "inttype");
    }

    public void RemoveInttype()
    {
      MeiAtt_controller.RemoveAttribute(this, "inttype");
    }
    #endregion

        #region since
    
    public void SetSince(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "since", _val);
    }

    public XAttribute GetSince()
    {
      return MeiAtt_controller.GetAttribute(this, "since");
    }

    public bool HasSince()
    {
      return MeiAtt_controller.HasAttribute(this, "since");
    }

    public void RemoveSince()
    {
      MeiAtt_controller.RemoveAttribute(this, "since");
    }
    #endregion

    }
}
