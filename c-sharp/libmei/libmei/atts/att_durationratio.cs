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
  /// Interface for att.duration.ratio
  /// </summary>
  public interface IAttDurationRatio : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.duration.ratio
  /// </summary>
  public static class AttDurationRatio_extensions
  {
    #region num
    
    public static void SetNum(this IAttDurationRatio e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "num", _val);
    }

    public static XAttribute GetNum(this IAttDurationRatio e)
    {
      return MeiAtt_controller.GetAttribute(e, "num");
    }

    public static bool HasNum(this IAttDurationRatio e)
    {
      return MeiAtt_controller.HasAttribute(e, "num");
    }

    public static void RemoveNum(this IAttDurationRatio e)
    {
      MeiAtt_controller.RemoveAttribute(e, "num");
    }
    #endregion

    #region numbase
    
    public static void SetNumbase(this IAttDurationRatio e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "numbase", _val);
    }

    public static XAttribute GetNumbase(this IAttDurationRatio e)
    {
      return MeiAtt_controller.GetAttribute(e, "numbase");
    }

    public static bool HasNumbase(this IAttDurationRatio e)
    {
      return MeiAtt_controller.HasAttribute(e, "numbase");
    }

    public static void RemoveNumbase(this IAttDurationRatio e)
    {
      MeiAtt_controller.RemoveAttribute(e, "numbase");
    }
    #endregion

  }

}