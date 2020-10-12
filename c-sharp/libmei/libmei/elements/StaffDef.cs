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
    /// <staffDef/>
    /// </summary>
    public class StaffDef : MeiElement, IAttCommonPart, IAttDeclaring, IAttCleffingLog, IAttDurationDefault, IAttKeySigDefaultLog, IAttMeterSigDefaultLog, IAttNotationtype, IAttOctavedefault, IAttTransposition, IAttBeamingLog, IAttMensuralLog, IAttMensuralShared, IAttStaffDefVis, IAttCleffingVis, IAttDistances, IAttKeySigDefaultVis, IAttLabelsAddl, IAttLyricstyle, IAttMeterSigDefaultVis, IAttMultinummeasures, IAttOnelinestaff, IAttScalable, IAttTextstyle, IAttVisibility, IAttBeamingVis, IAttPianopedals, IAttRehearsal, IAttSlurrend, IAttTierend, IAttMensuralVis, IAttInstrumentident, IAttTimebase, IAttStaffDefGesTablature
    {
        
        public StaffDef() : base("staffDef") { }

        public StaffDef(object _content) : base("staffDef", _content) { }

        public StaffDef(params object[] _content) : base("staffDef", _content) { }


        #region n
    
    public void SetN(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "n", _val);
    }

    public XAttribute GetN()
    {
      return MeiAtt_controller.GetAttribute(this, "n");
    }

    public bool HasN()
    {
      return MeiAtt_controller.HasAttribute(this, "n");
    }

    public void RemoveN()
    {
      MeiAtt_controller.RemoveAttribute(this, "n");
    }
    #endregion

    }
}
