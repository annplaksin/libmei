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
    /// <tempo/>
    /// </summary>
    public class Tempo : MeiElement, IAttCommon, IAttCommonPart, IAttBibl, IAttFacsimile, IAttLang, IAttTempoLog, IAttPlist, IAttTargeteval, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttStartid, IAttPlacement, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy, IAttMiditempo, IAttMmtempo, IAttCommonAnl, IAttAlignment, IAttTyped
    {
        
        public Tempo() : base("tempo") { }

        public Tempo(object _content) : base("tempo", _content) { }

        public Tempo(params object[] _content) : base("tempo", _content) { }


        
    }
}
