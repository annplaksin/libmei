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
  /// Interface for att.miditempo
  /// </summary>
  public interface IAttMiditempo : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.miditempo
  /// </summary>
  public static class AttMiditempo_extensions
  {
    #region midi.bpm
    
    public static void SetMidiBpm(this IAttMiditempo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.bpm", _val);
    }

    public static XAttribute GetMidiBpm(this IAttMiditempo e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.bpm");
    }

    public static bool HasMidiBpm(this IAttMiditempo e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.bpm");
    }

    public static void RemoveMidiBpm(this IAttMiditempo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.bpm");
    }
    #endregion

    #region midi.mspb
    
    public static void SetMidiMspb(this IAttMiditempo e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.mspb", _val);
    }

    public static XAttribute GetMidiMspb(this IAttMiditempo e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.mspb");
    }

    public static bool HasMidiMspb(this IAttMiditempo e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.mspb");
    }

    public static void RemoveMidiMspb(this IAttMiditempo e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.mspb");
    }
    #endregion

  }

}