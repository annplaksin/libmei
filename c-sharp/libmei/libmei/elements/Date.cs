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
    /// <date/>
    /// </summary>
    public class Date : MeiElement, IAttBibl, IAttCalendared, IAttCommon, IAttCommonPart, IAttDatable, IAttResponsibility, IAttSource, IAttEvidence, IAttFacsimile, IAttLang, IAttTyped
    {
        
        public Date() : base("date") { }

        public Date(object _content) : base("date", _content) { }

        public Date(params object[] _content) : base("date", _content) { }


        
    }
}
