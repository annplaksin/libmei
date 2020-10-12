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
    /// <mRpt2/>
    /// </summary>
    public class MRpt2 : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAltsym, IAttColor, IAttExpandable, IAttExtsym, IAttTypography, IAttCommonAnl, IAttAlignment
    {
        
        public MRpt2() : base("mRpt2") { }

        public MRpt2(object _content) : base("mRpt2", _content) { }

        public MRpt2(params object[] _content) : base("mRpt2", _content) { }


        
    }
}
