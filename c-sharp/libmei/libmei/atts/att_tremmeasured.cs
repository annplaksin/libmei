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
  /// Interface for att.tremmeasured
  /// </summary>
  public interface IAttTremmeasured : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.tremmeasured
  /// </summary>
  public static class AttTremmeasured_extensions
  {
    #region measperf
    
    public static void SetMeasperf(this IAttTremmeasured e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "measperf", _val);
    }

    public static XAttribute GetMeasperf(this IAttTremmeasured e)
    {
      return MeiAtt_controller.GetAttribute(e, "measperf");
    }

    public static bool HasMeasperf(this IAttTremmeasured e)
    {
      return MeiAtt_controller.HasAttribute(e, "measperf");
    }

    public static void RemoveMeasperf(this IAttTremmeasured e)
    {
      MeiAtt_controller.RemoveAttribute(e, "measperf");
    }
    #endregion

  }

}