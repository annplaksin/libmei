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
  /// Interface for att.note.ges
  /// </summary>
  public interface IAttNoteGes : IMEiAtt, IAttAccidentalPerformed, IAttArticulationPerformed, IAttDurationPerformed, IAttInstrumentident, IAttMidivelocity, IAttNoteGesCmn, IAttNoteGesMensural, IAttNoteGesTablature
  {

  }


    /// <summary>
  /// Extension methods for att.note.ges
  /// </summary>
  public static class AttNoteGes_extensions
  {
    #region oct.ges
    
    public static void SetOctGes(this IAttNoteGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "oct.ges", _val);
    }

    public static XAttribute GetOctGes(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "oct.ges");
    }

    public static bool HasOctGes(this IAttNoteGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "oct.ges");
    }

    public static void RemoveOctGes(this IAttNoteGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "oct.ges");
    }
    #endregion

    #region pname.ges
    
    public static void SetPnameGes(this IAttNoteGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "pname.ges", _val);
    }

    public static XAttribute GetPnameGes(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "pname.ges");
    }

    public static bool HasPnameGes(this IAttNoteGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "pname.ges");
    }

    public static void RemovePnameGes(this IAttNoteGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "pname.ges");
    }
    #endregion

    #region pnum
    
    public static void SetPnum(this IAttNoteGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "pnum", _val);
    }

    public static XAttribute GetPnum(this IAttNoteGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "pnum");
    }

    public static bool HasPnum(this IAttNoteGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "pnum");
    }

    public static void RemovePnum(this IAttNoteGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "pnum");
    }
    #endregion

  }

}