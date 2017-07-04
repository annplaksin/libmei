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
  /// Interface for att.pitchclass
  /// </summary>
  public interface IAttPitchclass : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pitchclass
  /// </summary>
  public static class AttPitchclass_extensions
  {
    #region pclass
    
    public static void SetPclass(this IAttPitchclass e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "pclass", _val);
    }

    public static XAttribute GetPclass(this IAttPitchclass e)
    {
      return MeiAtt_controller.GetAttribute(e, "pclass");
    }

    public static bool HasPclass(this IAttPitchclass e)
    {
      return MeiAtt_controller.HasAttribute(e, "pclass");
    }

    public static void RemovePclass(this IAttPitchclass e)
    {
      MeiAtt_controller.RemoveAttribute(e, "pclass");
    }
    #endregion

  }

}