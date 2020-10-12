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
  /// Interface for att.scoreDef.vis.cmn
  /// </summary>
  public interface IAttScoreDefVisCmn : IMEiAtt, IAttBeamingVis, IAttPianopedals, IAttRehearsal, IAttSlurrend, IAttTierend
  {

  }


    /// <summary>
  /// Extension methods for att.scoreDef.vis.cmn
  /// </summary>
  public static class AttScoreDefVisCmn_extensions
  {
    #region grid.show
    
    public static void SetGridShow(this IAttScoreDefVisCmn e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "grid.show", _val);
    }

    public static XAttribute GetGridShow(this IAttScoreDefVisCmn e)
    {
      return MeiAtt_controller.GetAttribute(e, "grid.show");
    }

    public static bool HasGridShow(this IAttScoreDefVisCmn e)
    {
      return MeiAtt_controller.HasAttribute(e, "grid.show");
    }

    public static void RemoveGridShow(this IAttScoreDefVisCmn e)
    {
      MeiAtt_controller.RemoveAttribute(e, "grid.show");
    }
    #endregion

  }

}