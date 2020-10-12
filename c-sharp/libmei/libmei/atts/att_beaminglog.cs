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
  /// Interface for att.beaming.log
  /// </summary>
  public interface IAttBeamingLog : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.beaming.log
  /// </summary>
  public static class AttBeamingLog_extensions
  {
    #region beam.group
    
    public static void SetBeamGroup(this IAttBeamingLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "beam.group", _val);
    }

    public static XAttribute GetBeamGroup(this IAttBeamingLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "beam.group");
    }

    public static bool HasBeamGroup(this IAttBeamingLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "beam.group");
    }

    public static void RemoveBeamGroup(this IAttBeamingLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "beam.group");
    }
    #endregion

    #region beam.rests
    
    public static void SetBeamRests(this IAttBeamingLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "beam.rests", _val);
    }

    public static XAttribute GetBeamRests(this IAttBeamingLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "beam.rests");
    }

    public static bool HasBeamRests(this IAttBeamingLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "beam.rests");
    }

    public static void RemoveBeamRests(this IAttBeamingLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "beam.rests");
    }
    #endregion

  }

}