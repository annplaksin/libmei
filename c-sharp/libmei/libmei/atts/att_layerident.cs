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
  /// Interface for att.layerident
  /// </summary>
  public interface IAttLayerident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.layerident
  /// </summary>
  public static class AttLayerident_extensions
  {
    #region layer
    
    public static void SetLayer(this IAttLayerident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "layer", _val);
    }

    public static XAttribute GetLayer(this IAttLayerident e)
    {
      return MeiAtt_controller.GetAttribute(e, "layer");
    }

    public static bool HasLayer(this IAttLayerident e)
    {
      return MeiAtt_controller.HasAttribute(e, "layer");
    }

    public static void RemoveLayer(this IAttLayerident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "layer");
    }
    #endregion

  }

}