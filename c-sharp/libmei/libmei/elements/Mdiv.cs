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
    /// <mdiv/>
    /// </summary>
    public class Mdiv : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttFacsimile, IAttTyped
    {
        
        public Mdiv() : base("mdiv") { }

        public Mdiv(object _content) : base("mdiv", _content) { }

        public Mdiv(params object[] _content) : base("mdiv", _content) { }


        
    }
}
