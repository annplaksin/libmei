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
    /// <octave/>
    /// </summary>
    public class Octave : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttOctaveLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttDurationAdditive, IAttOctavedisplacement, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttColor, IAttExtender, IAttLinerend, IAttLinerendBase, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttDurationPerformed, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public Octave() : base("octave") { }

        public Octave(object _content) : base("octave", _content) { }

        public Octave(params object[] _content) : base("octave", _content) { }


        
    }
}
