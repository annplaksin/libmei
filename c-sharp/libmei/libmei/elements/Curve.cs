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
    /// <curve/>
    /// </summary>
    public class Curve : MeiElement, IAttCommonAnl, IAttAlignment, IAttColor, IAttCommon, IAttCommonPart, IAttCurvature, IAttCurverend, IAttFacsimile, IAttStartendid, IAttStartid, IAttTyped, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttVisualoffset2Vo, IAttXy, IAttXy2
    {
        
        public Curve() : base("curve") { }

        public Curve(object _content) : base("curve", _content) { }

        public Curve(params object[] _content) : base("curve", _content) { }


        
    }
}
