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
  /// Interface for att.beatRpt.log
  /// </summary>
  public interface IAttBeatRptLog : IMEiAtt, IAttEvent
  {

  }


    /// <summary>
  /// Extension methods for att.beatRpt.log
  /// </summary>
  public static class AttBeatRptLog_extensions
  {
    #region beatDef
    
    public static void SetBeatDef(this IAttBeatRptLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "beatDef", _val);
    }

    public static XAttribute GetBeatDef(this IAttBeatRptLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "beatDef");
    }

    public static bool HasBeatDef(this IAttBeatRptLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "beatDef");
    }

    public static void RemoveBeatDef(this IAttBeatRptLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "beatDef");
    }
    #endregion

  }

}