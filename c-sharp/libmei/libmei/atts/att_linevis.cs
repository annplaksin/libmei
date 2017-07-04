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
  /// Interface for att.line.vis
  /// </summary>
  public interface IAttLineVis : IMEiAtt, IAttColor, IAttPlacement, IAttVisualoffset, IAttVisualoffset2, IAttXy, IAttXy2
  {

  }


    /// <summary>
  /// Extension methods for att.line.vis
  /// </summary>
  public static class AttLineVis_extensions
  {
    #region form
    
    public static void SetForm(this IAttLineVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetForm(this IAttLineVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }

    public static bool HasForm(this IAttLineVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttLineVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

    #region width
    
    public static void SetWidth(this IAttLineVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "width", _val);
    }

    public static XAttribute GetWidth(this IAttLineVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "width");
    }

    public static bool HasWidth(this IAttLineVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "width");
    }

    public static void RemoveWidth(this IAttLineVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "width");
    }
    #endregion

    #region endsym
    
    public static void SetEndsym(this IAttLineVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "endsym", _val);
    }

    public static XAttribute GetEndsym(this IAttLineVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "endsym");
    }

    public static bool HasEndsym(this IAttLineVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "endsym");
    }

    public static void RemoveEndsym(this IAttLineVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "endsym");
    }
    #endregion

    #region endsymsize
    
    public static void SetEndsymsize(this IAttLineVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "endsymsize", _val);
    }

    public static XAttribute GetEndsymsize(this IAttLineVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "endsymsize");
    }

    public static bool HasEndsymsize(this IAttLineVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "endsymsize");
    }

    public static void RemoveEndsymsize(this IAttLineVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "endsymsize");
    }
    #endregion

    #region startsym
    
    public static void SetStartsym(this IAttLineVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "startsym", _val);
    }

    public static XAttribute GetStartsym(this IAttLineVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "startsym");
    }

    public static bool HasStartsym(this IAttLineVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "startsym");
    }

    public static void RemoveStartsym(this IAttLineVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "startsym");
    }
    #endregion

    #region startsymsize
    
    public static void SetStartsymsize(this IAttLineVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "startsymsize", _val);
    }

    public static XAttribute GetStartsymsize(this IAttLineVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "startsymsize");
    }

    public static bool HasStartsymsize(this IAttLineVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "startsymsize");
    }

    public static void RemoveStartsymsize(this IAttLineVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "startsymsize");
    }
    #endregion

  }

}