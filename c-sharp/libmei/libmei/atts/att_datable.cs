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
  /// Interface for att.datable
  /// </summary>
  public interface IAttDatable : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.datable
  /// </summary>
  public static class AttDatable_extensions
  {
    #region enddate
    
    public static void SetEnddate(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "enddate", _val);
    }

    public static XAttribute GetEnddate(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "enddate");
    }

    public static bool HasEnddate(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "enddate");
    }

    public static void RemoveEnddate(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "enddate");
    }
    #endregion

    #region isodate
    
    public static void SetIsodate(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "isodate", _val);
    }

    public static XAttribute GetIsodate(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "isodate");
    }

    public static bool HasIsodate(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "isodate");
    }

    public static void RemoveIsodate(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "isodate");
    }
    #endregion

    #region notafter
    
    public static void SetNotafter(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "notafter", _val);
    }

    public static XAttribute GetNotafter(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "notafter");
    }

    public static bool HasNotafter(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "notafter");
    }

    public static void RemoveNotafter(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "notafter");
    }
    #endregion

    #region notbefore
    
    public static void SetNotbefore(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "notbefore", _val);
    }

    public static XAttribute GetNotbefore(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "notbefore");
    }

    public static bool HasNotbefore(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "notbefore");
    }

    public static void RemoveNotbefore(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "notbefore");
    }
    #endregion

    #region startdate
    
    public static void SetStartdate(this IAttDatable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "startdate", _val);
    }

    public static XAttribute GetStartdate(this IAttDatable e)
    {
      return MeiAtt_controller.GetAttribute(e, "startdate");
    }

    public static bool HasStartdate(this IAttDatable e)
    {
      return MeiAtt_controller.HasAttribute(e, "startdate");
    }

    public static void RemoveStartdate(this IAttDatable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "startdate");
    }
    #endregion

  }

}