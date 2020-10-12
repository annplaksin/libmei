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
    /// <soundChan/>
    /// </summary>
    public class SoundChan : MeiElement, IAttCommon, IAttCommonPart, IAttAuthorized, IAttBibl, IAttLang
    {
        
        public SoundChan() : base("soundChan") { }

        public SoundChan(object _content) : base("soundChan", _content) { }

        public SoundChan(params object[] _content) : base("soundChan", _content) { }


        #region num
    
    public void SetNum(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "num", _val);
    }

    public XAttribute GetNum()
    {
      return MeiAtt_controller.GetAttribute(this, "num");
    }

    public bool HasNum()
    {
      return MeiAtt_controller.HasAttribute(this, "num");
    }

    public void RemoveNum()
    {
      MeiAtt_controller.RemoveAttribute(this, "num");
    }
    #endregion

    }
}
