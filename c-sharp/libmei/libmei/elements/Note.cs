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
    /// <note/>
    /// </summary>
    public class Note : MeiElement, IAttCommon, IAttCommonPart, IAttFacsimile, IAttTimestampMusical, IAttTimestampPerformed, IAttStaffident, IAttLayerident, IAttAccidental, IAttArticulation, IAttAugmentdots, IAttDurationMusical, IAttFermatapresent, IAttPitch, IAttOctave, IAttSyltext, IAttSlurpresent, IAttTiepresent, IAttTupletpresent, IAttBeamed, IAttLvpresent, IAttOrnam, IAttNoteLogMensural, IAttAltsym, IAttColor, IAttColoration, IAttEnclosingchars, IAttExtsym, IAttNoteheads, IAttRelativesize, IAttStaffloc, IAttStems, IAttStemsCmn, IAttTypography, IAttVisibility, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttXy, IAttBeamsecondary, IAttNoteGes, IAttAccidentalPerformed, IAttArticulationPerformed, IAttDurationPerformed, IAttInstrumentident, IAttMidivelocity, IAttNoteGesCmn, IAttGraced, IAttDurationRatio, IAttNoteGesTablature, IAttCommonAnl, IAttAlignment, IAttHarmonicfunction, IAttIntervalmelodic, IAttMelodicfunction, IAttPitchclass, IAttSolfa
    {
        
        public Note() : base("note") { }

        public Note(object _content) : base("note", _content) { }

        public Note(params object[] _content) : base("note", _content) { }


        
    }
}
