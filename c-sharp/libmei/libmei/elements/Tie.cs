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
    /// <tie/>
    /// </summary>
    public class Tie : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttColor, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttVisualoffset2Vo, IAttXy, IAttXy2, IAttCurvature, IAttCurverend, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public Tie() : base("tie") { }

        public Tie(object _content) : base("tie", _content) { }

        public Tie(params object[] _content) : base("tie", _content) { }


        
    }
}
