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
    /// <tupletSpan/>
    /// </summary>
    public class TupletSpan : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttBeamedwith, IAttAugmentdots, IAttDurationAdditive, IAttDurationRatio, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttTupletVis, IAttColor, IAttNumberplacement, IAttDurationPerformed, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public TupletSpan() : base("tupletSpan") { }

        public TupletSpan(object _content) : base("tupletSpan", _content) { }

        public TupletSpan(params object[] _content) : base("tupletSpan", _content) { }


        
    }
}
