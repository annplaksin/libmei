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
  /// Interface for att.cutout
  /// </summary>
  public interface IAttCutout : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.cutout
  /// </summary>
  public static class AttCutout_extensions
  {
    #region cutout
    
    public static void SetCutout(this IAttCutout e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "cutout", _val);
    }

    public static XAttribute GetCutout(this IAttCutout e)
    {
      return MeiAtt_controller.GetAttribute(e, "cutout");
    }

    public static bool HasCutout(this IAttCutout e)
    {
      return MeiAtt_controller.HasAttribute(e, "cutout");
    }

    public static void RemoveCutout(this IAttCutout e)
    {
      MeiAtt_controller.RemoveAttribute(e, "cutout");
    }
    #endregion

  }

}