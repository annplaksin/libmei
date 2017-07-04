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
    /// <mSpace/>
    /// </summary>
    public class MSpace : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttAugmentdots, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttDurationMusical, IAttFermatapresent, IAttAltsym, IAttCutout, IAttVisibility, IAttXy, IAttDurationPerformed, IAttInstrumentident, IAttCommonAnl, IAttAlignment
    {
        
        public MSpace() : base("mSpace") { }

        public MSpace(object _content) : base("mSpace", _content) { }

        public MSpace(params object[] _content) : base("mSpace", _content) { }


        
    }
}
