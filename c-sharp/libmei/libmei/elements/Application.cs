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
    /// <application/>
    /// </summary>
    public class Application : MeiElement, IAttCommon, IAttCommonPart, IAttDatable, IAttTyped
    {
        
        public Application() : base("application") { }

        public Application(object _content) : base("application", _content) { }

        public Application(params object[] _content) : base("application", _content) { }


        #region version
    
    public void SetVersion(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "version", _val);
    }

    public XAttribute GetVersion()
    {
      return MeiAtt_controller.GetAttribute(this, "version");
    }

    public bool HasVersion()
    {
      return MeiAtt_controller.HasAttribute(this, "version");
    }

    public void RemoveVersion()
    {
      MeiAtt_controller.RemoveAttribute(this, "version");
    }
    #endregion

    }
}
