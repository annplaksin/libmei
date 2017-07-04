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
    /// <harm/>
    /// </summary>
    public class Harm : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttHarmLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttHarmVis, IAttExtender, IAttLinerend, IAttLinerendBase, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttDurationPerformed, IAttCommonAnl, IAttAlignment, IAttIntervalharmonic, IAttTyped
    {
        
        public Harm() : base("harm") { }

        public Harm(object _content) : base("harm", _content) { }

        public Harm(params object[] _content) : base("harm", _content) { }


        
    }
}
