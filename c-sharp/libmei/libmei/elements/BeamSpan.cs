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
    /// <beamSpan/>
    /// </summary>
    public class BeamSpan : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttBeamedwith, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttColor, IAttBeamrend, IAttDurationPerformed, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public BeamSpan() : base("beamSpan") { }

        public BeamSpan(object _content) : base("beamSpan", _content) { }

        public BeamSpan(params object[] _content) : base("beamSpan", _content) { }


        
    }
}
