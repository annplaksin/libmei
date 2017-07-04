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
  /// Interface for att.mediabounds
  /// </summary>
  public interface IAttMediabounds : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.mediabounds
  /// </summary>
  public static class AttMediabounds_extensions
  {
    #region begin
    
    public static void SetBegin(this IAttMediabounds e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "begin", _val);
    }

    public static XAttribute GetBegin(this IAttMediabounds e)
    {
      return MeiAtt_controller.GetAttribute(e, "begin");
    }

    public static bool HasBegin(this IAttMediabounds e)
    {
      return MeiAtt_controller.HasAttribute(e, "begin");
    }

    public static void RemoveBegin(this IAttMediabounds e)
    {
      MeiAtt_controller.RemoveAttribute(e, "begin");
    }
    #endregion

    #region end
    
    public static void SetEnd(this IAttMediabounds e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "end", _val);
    }

    public static XAttribute GetEnd(this IAttMediabounds e)
    {
      return MeiAtt_controller.GetAttribute(e, "end");
    }

    public static bool HasEnd(this IAttMediabounds e)
    {
      return MeiAtt_controller.HasAttribute(e, "end");
    }

    public static void RemoveEnd(this IAttMediabounds e)
    {
      MeiAtt_controller.RemoveAttribute(e, "end");
    }
    #endregion

    #region betype
    
    public static void SetBetype(this IAttMediabounds e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "betype", _val);
    }

    public static XAttribute GetBetype(this IAttMediabounds e)
    {
      return MeiAtt_controller.GetAttribute(e, "betype");
    }

    public static bool HasBetype(this IAttMediabounds e)
    {
      return MeiAtt_controller.HasAttribute(e, "betype");
    }

    public static void RemoveBetype(this IAttMediabounds e)
    {
      MeiAtt_controller.RemoveAttribute(e, "betype");
    }
    #endregion

  }

}