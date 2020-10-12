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
  /// Interface for att.pianopedals
  /// </summary>
  public interface IAttPianopedals : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pianopedals
  /// </summary>
  public static class AttPianopedals_extensions
  {
    #region pedal.style
    
    public static void SetPedalStyle(this IAttPianopedals e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "pedal.style", _val);
    }

    public static XAttribute GetPedalStyle(this IAttPianopedals e)
    {
      return MeiAtt_controller.GetAttribute(e, "pedal.style");
    }

    public static bool HasPedalStyle(this IAttPianopedals e)
    {
      return MeiAtt_controller.HasAttribute(e, "pedal.style");
    }

    public static void RemovePedalStyle(this IAttPianopedals e)
    {
      MeiAtt_controller.RemoveAttribute(e, "pedal.style");
    }
    #endregion

  }

}