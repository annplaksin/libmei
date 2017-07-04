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
  /// Interface for att.midiinstrument
  /// </summary>
  public interface IAttMidiinstrument : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.midiinstrument
  /// </summary>
  public static class AttMidiinstrument_extensions
  {
    #region midi.instrnum
    
    public static void SetMidiInstrnum(this IAttMidiinstrument e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.instrnum", _val);
    }

    public static XAttribute GetMidiInstrnum(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.instrnum");
    }

    public static bool HasMidiInstrnum(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.instrnum");
    }

    public static void RemoveMidiInstrnum(this IAttMidiinstrument e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.instrnum");
    }
    #endregion

    #region midi.instrname
    
    public static void SetMidiInstrname(this IAttMidiinstrument e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.instrname", _val);
    }

    public static XAttribute GetMidiInstrname(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.instrname");
    }

    public static bool HasMidiInstrname(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.instrname");
    }

    public static void RemoveMidiInstrname(this IAttMidiinstrument e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.instrname");
    }
    #endregion

    #region midi.pan
    
    public static void SetMidiPan(this IAttMidiinstrument e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.pan", _val);
    }

    public static XAttribute GetMidiPan(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.pan");
    }

    public static bool HasMidiPan(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.pan");
    }

    public static void RemoveMidiPan(this IAttMidiinstrument e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.pan");
    }
    #endregion

    #region midi.volume
    
    public static void SetMidiVolume(this IAttMidiinstrument e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.volume", _val);
    }

    public static XAttribute GetMidiVolume(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.volume");
    }

    public static bool HasMidiVolume(this IAttMidiinstrument e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.volume");
    }

    public static void RemoveMidiVolume(this IAttMidiinstrument e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.volume");
    }
    #endregion

  }

}