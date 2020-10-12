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
  /// Interface for att.beatRpt.vis
  /// </summary>
  public interface IAttBeatRptVis : IMEiAtt, IAttAltsym, IAttColor, IAttExpandable, IAttExtsym, IAttTypography
  {

  }


    /// <summary>
  /// Extension methods for att.beatRpt.vis
  /// </summary>
  public static class AttBeatRptVis_extensions
  {
    #region form
    
    public static void SetForm(this IAttBeatRptVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetForm(this IAttBeatRptVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }

    public static bool HasForm(this IAttBeatRptVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttBeatRptVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

  }

}