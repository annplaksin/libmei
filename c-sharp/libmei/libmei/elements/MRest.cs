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
    /// <mRest/>
    /// </summary>
    public class MRest : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttDurationMusical, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttFermatapresent, IAttAltsym, IAttCutout, IAttExtsym, IAttRelativesize, IAttStaffloc, IAttStafflocPitched, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisibility, IAttXy, IAttDurationPerformed, IAttInstrumentident, IAttCommonAnl, IAttAlignment
    {
        
        public MRest() : base("mRest") { }

        public MRest(object _content) : base("mRest", _content) { }

        public MRest(params object[] _content) : base("mRest", _content) { }


        
    }
}
