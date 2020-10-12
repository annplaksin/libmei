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
  /// Interface for att.midivalue2
  /// </summary>
  public interface IAttMidivalue2 : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.midivalue2
  /// </summary>
  public static class AttMidivalue2_extensions
  {
    #region val2
    
    public static void SetVal2(this IAttMidivalue2 e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "val2", _val);
    }

    public static XAttribute GetVal2(this IAttMidivalue2 e)
    {
      return MeiAtt_controller.GetAttribute(e, "val2");
    }

    public static bool HasVal2(this IAttMidivalue2 e)
    {
      return MeiAtt_controller.HasAttribute(e, "val2");
    }

    public static void RemoveVal2(this IAttMidivalue2 e)
    {
      MeiAtt_controller.RemoveAttribute(e, "val2");
    }
    #endregion

  }

}