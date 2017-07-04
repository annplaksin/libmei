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
    /// <arpeg/>
    /// </summary>
    public class Arpeg : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttArpegLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttStartid, IAttArpegVis, IAttAltsym, IAttColor, IAttExtsym, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public Arpeg() : base("arpeg") { }

        public Arpeg(object _content) : base("arpeg", _content) { }

        public Arpeg(params object[] _content) : base("arpeg", _content) { }


        
    }
}
