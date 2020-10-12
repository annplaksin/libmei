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
  /// Interface for att.harm.vis
  /// </summary>
  public interface IAttHarmVis : IMEiAtt, IAttExtender, IAttPlacement, IAttVisualoffset, IAttVisualoffset2Ho, IAttVisualoffset2To, IAttXy
  {

  }


    /// <summary>
  /// Extension methods for att.harm.vis
  /// </summary>
  public static class AttHarmVis_extensions
  {
    #region rendgrid
    
    public static void SetRendgrid(this IAttHarmVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "rendgrid", _val);
    }

    public static XAttribute GetRendgrid(this IAttHarmVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "rendgrid");
    }

    public static bool HasRendgrid(this IAttHarmVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "rendgrid");
    }

    public static void RemoveRendgrid(this IAttHarmVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "rendgrid");
    }
    #endregion

  }

}