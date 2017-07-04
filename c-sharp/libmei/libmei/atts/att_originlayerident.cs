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
  /// Interface for att.origin.layerident
  /// </summary>
  public interface IAttOriginLayerident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.origin.layerident
  /// </summary>
  public static class AttOriginLayerident_extensions
  {
    #region origin.layer
    
    public static void SetOriginLayer(this IAttOriginLayerident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "origin.layer", _val);
    }

    public static XAttribute GetOriginLayer(this IAttOriginLayerident e)
    {
      return MeiAtt_controller.GetAttribute(e, "origin.layer");
    }

    public static bool HasOriginLayer(this IAttOriginLayerident e)
    {
      return MeiAtt_controller.HasAttribute(e, "origin.layer");
    }

    public static void RemoveOriginLayer(this IAttOriginLayerident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "origin.layer");
    }
    #endregion

  }

}