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
  /// Interface for att.layer.log
  /// </summary>
  public interface IAttLayerLog : IMEiAtt, IAttMeterconformance
  {

  }


    /// <summary>
  /// Extension methods for att.layer.log
  /// </summary>
  public static class AttLayerLog_extensions
  {
    #region def
    
    public static void SetDef(this IAttLayerLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "def", _val);
    }

    public static XAttribute GetDef(this IAttLayerLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "def");
    }

    public static bool HasDef(this IAttLayerLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "def");
    }

    public static void RemoveDef(this IAttLayerLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "def");
    }
    #endregion

  }

}