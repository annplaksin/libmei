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
  /// Interface for att.graced
  /// </summary>
  public interface IAttGraced : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.graced
  /// </summary>
  public static class AttGraced_extensions
  {
    #region grace
    
    public static void SetGrace(this IAttGraced e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "grace", _val);
    }

    public static XAttribute GetGrace(this IAttGraced e)
    {
      return MeiAtt_controller.GetAttribute(e, "grace");
    }

    public static bool HasGrace(this IAttGraced e)
    {
      return MeiAtt_controller.HasAttribute(e, "grace");
    }

    public static void RemoveGrace(this IAttGraced e)
    {
      MeiAtt_controller.RemoveAttribute(e, "grace");
    }
    #endregion

    #region grace.time
    
    public static void SetGraceTime(this IAttGraced e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "grace.time", _val);
    }

    public static XAttribute GetGraceTime(this IAttGraced e)
    {
      return MeiAtt_controller.GetAttribute(e, "grace.time");
    }

    public static bool HasGraceTime(this IAttGraced e)
    {
      return MeiAtt_controller.HasAttribute(e, "grace.time");
    }

    public static void RemoveGraceTime(this IAttGraced e)
    {
      MeiAtt_controller.RemoveAttribute(e, "grace.time");
    }
    #endregion

  }

}