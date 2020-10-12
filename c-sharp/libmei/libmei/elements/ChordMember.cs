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
    /// <chordMember/>
    /// </summary>
    public class ChordMember : MeiElement, IAttCommon, IAttCommonPart, IAttAccidentalPerformed, IAttFretlocation, IAttIntervalharmonic, IAttPitch, IAttOctave
    {
        
        public ChordMember() : base("chordMember") { }

        public ChordMember(object _content) : base("chordMember", _content) { }

        public ChordMember(params object[] _content) : base("chordMember", _content) { }


        #region fing
    
    public void SetFing(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "fing", _val);
    }

    public XAttribute GetFing()
    {
      return MeiAtt_controller.GetAttribute(this, "fing");
    }

    public bool HasFing()
    {
      return MeiAtt_controller.HasAttribute(this, "fing");
    }

    public void RemoveFing()
    {
      MeiAtt_controller.RemoveAttribute(this, "fing");
    }
    #endregion

    }
}
