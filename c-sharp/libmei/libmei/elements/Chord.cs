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
    /// <chord/>
    /// </summary>
    public class Chord : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttArticulation, IAttAugmentdots, IAttDurationMusical, IAttFermatapresent, IAttSyltext, IAttSlurpresent, IAttTiepresent, IAttTupletpresent, IAttBeamed, IAttLvpresent, IAttOrnam, IAttChordVis, IAttAltsym, IAttColor, IAttEnclosingchars, IAttExtsym, IAttRelativesize, IAttStems, IAttStemsCmn, IAttTypography, IAttVisibility, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttXy, IAttBeamsecondary, IAttArticulationPerformed, IAttDurationPerformed, IAttInstrumentident, IAttGraced, IAttCommonAnl, IAttAlignment
    {
        
        public Chord() : base("chord") { }

        public Chord(object _content) : base("chord", _content) { }

        public Chord(params object[] _content) : base("chord", _content) { }


        
    }
}
