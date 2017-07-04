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
    /// <multiRest/>
    /// </summary>
    public class MultiRest : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttNumbered, IAttMultiRestVis, IAttAltsym, IAttExtsym, IAttStaffloc, IAttStafflocPitched, IAttTypography, IAttDurationPerformed, IAttInstrumentident, IAttCommonAnl, IAttAlignment
    {
        
        public MultiRest() : base("multiRest") { }

        public MultiRest(object _content) : base("multiRest", _content) { }

        public MultiRest(params object[] _content) : base("multiRest", _content) { }


        
    }
}
