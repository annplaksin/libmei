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
    /// <sb/>
    /// </summary>
    public class Sb : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttSource, IAttSbVis, IAttAltsym, IAttExtsym, IAttTypography, IAttCommonAnl, IAttAlignment
    {
        
        public Sb() : base("sb") { }

        public Sb(object _content) : base("sb", _content) { }

        public Sb(params object[] _content) : base("sb", _content) { }


        
    }
}
