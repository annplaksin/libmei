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
    /// <turn/>
    /// </summary>
    public class Turn : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttTurnLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttOrnamentaccid, IAttStartid, IAttAltsym, IAttColor, IAttExtsym, IAttPlacement, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public Turn() : base("turn") { }

        public Turn(object _content) : base("turn", _content) { }

        public Turn(params object[] _content) : base("turn", _content) { }


        
    }
}
