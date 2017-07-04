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
    /// <trill/>
    /// </summary>
    public class Trill : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAugmentdots, IAttDurationAdditive, IAttOrnamentaccid, IAttStartendid, IAttStartid, IAttTimestamp2Musical, IAttAltsym, IAttColor, IAttExtender, IAttLinerend, IAttLinerendBase, IAttPlacement, IAttExtsym, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttDurationPerformed, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public Trill() : base("trill") { }

        public Trill(object _content) : base("trill", _content) { }

        public Trill(params object[] _content) : base("trill", _content) { }


        
    }
}
