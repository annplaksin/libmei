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
    /// <rest/>
    /// </summary>
    public class Rest : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttAugmentdots, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttDurationMusical, IAttFermatapresent, IAttTupletpresent, IAttBeamed, IAttAltsym, IAttColor, IAttEnclosingchars, IAttRelativesize, IAttRestVisMensural, IAttStaffloc, IAttStafflocPitched, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttDurationPerformed, IAttInstrumentident, IAttDurationRatio, IAttCommonAnl, IAttAlignment
    {
        
        public Rest() : base("rest") { }

        public Rest(object _content) : base("rest", _content) { }

        public Rest(params object[] _content) : base("rest", _content) { }


        
    }
}
