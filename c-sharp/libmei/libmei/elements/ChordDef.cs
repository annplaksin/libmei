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
    /// <chordDef/>
    /// </summary>
    public class ChordDef : MeiElement, IAttCommon, IAttCommonPart
    {
        
        public ChordDef() : base("chordDef") { }

        public ChordDef(object _content) : base("chordDef", _content) { }

        public ChordDef(params object[] _content) : base("chordDef", _content) { }


        #region pos
    
    public void SetPos(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "pos", _val);
    }

    public XAttribute GetPos()
    {
      return MeiAtt_controller.GetAttribute(this, "pos");
    }

    public bool HasPos()
    {
      return MeiAtt_controller.HasAttribute(this, "pos");
    }

    public void RemovePos()
    {
      MeiAtt_controller.RemoveAttribute(this, "pos");
    }
    #endregion

    }
}
