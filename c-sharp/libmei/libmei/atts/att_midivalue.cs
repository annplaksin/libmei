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
  /// Interface for att.midivalue
  /// </summary>
  public interface IAttMidivalue : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.midivalue
  /// </summary>
  public static class AttMidivalue_extensions
  {
    #region val
    
    public static void SetVal(this IAttMidivalue e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "val", _val);
    }

    public static XAttribute GetVal(this IAttMidivalue e)
    {
      return MeiAtt_controller.GetAttribute(e, "val");
    }

    public static bool HasVal(this IAttMidivalue e)
    {
      return MeiAtt_controller.HasAttribute(e, "val");
    }

    public static void RemoveVal(this IAttMidivalue e)
    {
      MeiAtt_controller.RemoveAttribute(e, "val");
    }
    #endregion

  }

}