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
  /// Interface for att.measure.log
  /// </summary>
  public interface IAttMeasureLog : IMEiAtt, IAttMeterconformanceBar
  {

  }


    /// <summary>
  /// Extension methods for att.measure.log
  /// </summary>
  public static class AttMeasureLog_extensions
  {
    #region left
    
    public static void SetLeft(this IAttMeasureLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "left", _val);
    }

    public static XAttribute GetLeft(this IAttMeasureLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "left");
    }

    public static bool HasLeft(this IAttMeasureLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "left");
    }

    public static void RemoveLeft(this IAttMeasureLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "left");
    }
    #endregion

    #region right
    
    public static void SetRight(this IAttMeasureLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "right", _val);
    }

    public static XAttribute GetRight(this IAttMeasureLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "right");
    }

    public static bool HasRight(this IAttMeasureLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "right");
    }

    public static void RemoveRight(this IAttMeasureLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "right");
    }
    #endregion

  }

}