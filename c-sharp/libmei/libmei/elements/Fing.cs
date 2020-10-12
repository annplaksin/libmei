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
    /// <fing/>
    /// </summary>
    public class Fing : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttCommonAnl, IAttAlignment, IAttDurationPerformed, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttDurationAdditive, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttAltsym, IAttExtender, IAttLinerend, IAttLinerendBase, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttTyped
    {
        
        public Fing() : base("fing") { }

        public Fing(object _content) : base("fing", _content) { }

        public Fing(params object[] _content) : base("fing", _content) { }


        
    }
}
