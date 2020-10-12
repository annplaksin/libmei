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
  /// Interface for att.channelized
  /// </summary>
  public interface IAttChannelized : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.channelized
  /// </summary>
  public static class AttChannelized_extensions
  {
    #region midi.channel
    
    public static void SetMidiChannel(this IAttChannelized e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.channel", _val);
    }

    public static XAttribute GetMidiChannel(this IAttChannelized e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.channel");
    }

    public static bool HasMidiChannel(this IAttChannelized e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.channel");
    }

    public static void RemoveMidiChannel(this IAttChannelized e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.channel");
    }
    #endregion

    #region midi.duty
    
    public static void SetMidiDuty(this IAttChannelized e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.duty", _val);
    }

    public static XAttribute GetMidiDuty(this IAttChannelized e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.duty");
    }

    public static bool HasMidiDuty(this IAttChannelized e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.duty");
    }

    public static void RemoveMidiDuty(this IAttChannelized e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.duty");
    }
    #endregion

    #region midi.port
    
    public static void SetMidiPort(this IAttChannelized e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.port", _val);
    }

    public static XAttribute GetMidiPort(this IAttChannelized e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.port");
    }

    public static bool HasMidiPort(this IAttChannelized e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.port");
    }

    public static void RemoveMidiPort(this IAttChannelized e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.port");
    }
    #endregion

    #region midi.track
    
    public static void SetMidiTrack(this IAttChannelized e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "midi.track", _val);
    }

    public static XAttribute GetMidiTrack(this IAttChannelized e)
    {
      return MeiAtt_controller.GetAttribute(e, "midi.track");
    }

    public static bool HasMidiTrack(this IAttChannelized e)
    {
      return MeiAtt_controller.HasAttribute(e, "midi.track");
    }

    public static void RemoveMidiTrack(this IAttChannelized e)
    {
      MeiAtt_controller.RemoveAttribute(e, "midi.track");
    }
    #endregion

  }

}