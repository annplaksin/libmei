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
    /// <tuplet/>
    /// </summary>
    public class Tuplet : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttBeamedwith, IAttAugmentdots, IAttDurationAdditive, IAttDurationRatio, IAttStartendid, IAttStartid, IAttTupletVis, IAttColor, IAttNumberplacement, IAttDurationPerformed, IAttCommonAnl, IAttAlignment
    {
        
        public Tuplet() : base("tuplet") { }

        public Tuplet(object _content) : base("tuplet", _content) { }

        public Tuplet(params object[] _content) : base("tuplet", _content) { }


        
    }
}
