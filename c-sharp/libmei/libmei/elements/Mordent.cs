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
    /// <mordent/>
    /// </summary>
    public class Mordent : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttMordentLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttStartendid, IAttStartid, IAttOrnamentaccid, IAttAltsym, IAttColor, IAttExtsym, IAttPlacement, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public Mordent() : base("mordent") { }

        public Mordent(object _content) : base("mordent", _content) { }

        public Mordent(params object[] _content) : base("mordent", _content) { }


        
    }
}
