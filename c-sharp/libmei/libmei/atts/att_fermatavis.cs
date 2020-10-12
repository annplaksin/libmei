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
  /// Interface for att.fermata.vis
  /// </summary>
  public interface IAttFermataVis : IMEiAtt, IAttAltsym, IAttColor, IAttExtsym, IAttPlacement, IAttTypography, IAttVisualoffset, IAttXy
  {

  }


    /// <summary>
  /// Extension methods for att.fermata.vis
  /// </summary>
  public static class AttFermataVis_extensions
  {
    #region form
    
    public static void SetForm(this IAttFermataVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetForm(this IAttFermataVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }

    public static bool HasForm(this IAttFermataVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttFermataVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

    #region shape
    
    public static void SetShape(this IAttFermataVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "shape", _val);
    }

    public static XAttribute GetShape(this IAttFermataVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "shape");
    }

    public static bool HasShape(this IAttFermataVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "shape");
    }

    public static void RemoveShape(this IAttFermataVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "shape");
    }
    #endregion

  }

}