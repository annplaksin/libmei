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
    /// <uneume/>
    /// </summary>
    public class Uneume : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttTyped, IAttUneumeLog, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttSyltext, IAttAltsym, IAttColor, IAttExtsym, IAttRelativesize, IAttStaffloc, IAttTypography, IAttVisibility, IAttVisualoffsetHo, IAttXy, IAttCommonAnl, IAttAlignment, IAttHarmonicfunction, IAttIntervalmelodic, IAttMelodicfunction, IAttSolfa
    {
        
        public Uneume() : base("uneume") { }

        public Uneume(object _content) : base("uneume", _content) { }

        public Uneume(params object[] _content) : base("uneume", _content) { }


        
    }
}
