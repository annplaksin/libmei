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
  /// Interface for att.harm.log
  /// </summary>
  public interface IAttHarmLog : IMEiAtt, IAttControlevent, IAttAugmentdots, IAttDurationAdditive, IAttStartendid, IAttTimestamp2Musical
  {

  }


    /// <summary>
  /// Extension methods for att.harm.log
  /// </summary>
  public static class AttHarmLog_extensions
  {
    #region chordref
    
    public static void SetChordref(this IAttHarmLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "chordref", _val);
    }

    public static XAttribute GetChordref(this IAttHarmLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "chordref");
    }

    public static bool HasChordref(this IAttHarmLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "chordref");
    }

    public static void RemoveChordref(this IAttHarmLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "chordref");
    }
    #endregion

  }

}