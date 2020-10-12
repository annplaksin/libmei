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
  /// Interface for att.harmonicfunction
  /// </summary>
  public interface IAttHarmonicfunction : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.harmonicfunction
  /// </summary>
  public static class AttHarmonicfunction_extensions
  {
    #region deg
    
    public static void SetDeg(this IAttHarmonicfunction e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "deg", _val);
    }

    public static XAttribute GetDeg(this IAttHarmonicfunction e)
    {
      return MeiAtt_controller.GetAttribute(e, "deg");
    }

    public static bool HasDeg(this IAttHarmonicfunction e)
    {
      return MeiAtt_controller.HasAttribute(e, "deg");
    }

    public static void RemoveDeg(this IAttHarmonicfunction e)
    {
      MeiAtt_controller.RemoveAttribute(e, "deg");
    }
    #endregion

  }

}