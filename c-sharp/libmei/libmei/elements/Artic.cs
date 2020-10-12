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
    /// <artic/>
    /// </summary>
    public class Artic : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttArticulation, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAltsym, IAttColor, IAttEnclosingchars, IAttExtsym, IAttPlacement, IAttStaffloc, IAttTypography, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttXy, IAttArticulationPerformed, IAttCommonAnl, IAttAlignment
    {
        
        public Artic() : base("artic") { }

        public Artic(object _content) : base("artic", _content) { }

        public Artic(params object[] _content) : base("artic", _content) { }


        
    }
}
