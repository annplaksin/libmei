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
    /// <pb/>
    /// </summary>
    public class Pb : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttPointing, IAttSource, IAttTyped, IAttCommonAnl, IAttAlignment, IAttPbVis
    {
        
        public Pb() : base("pb") { }

        public Pb(object _content) : base("pb", _content) { }

        public Pb(params object[] _content) : base("pb", _content) { }


        
    }
}
