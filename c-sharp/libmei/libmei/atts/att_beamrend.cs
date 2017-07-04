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
  /// Interface for att.beamrend
  /// </summary>
  public interface IAttBeamrend : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.beamrend
  /// </summary>
  public static class AttBeamrend_extensions
  {
    #region form
    
    public static void SetForm(this IAttBeamrend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetForm(this IAttBeamrend e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }

    public static bool HasForm(this IAttBeamrend e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttBeamrend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

    #region slope
    
    public static void SetSlope(this IAttBeamrend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "slope", _val);
    }

    public static XAttribute GetSlope(this IAttBeamrend e)
    {
      return MeiAtt_controller.GetAttribute(e, "slope");
    }

    public static bool HasSlope(this IAttBeamrend e)
    {
      return MeiAtt_controller.HasAttribute(e, "slope");
    }

    public static void RemoveSlope(this IAttBeamrend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "slope");
    }
    #endregion

  }

}