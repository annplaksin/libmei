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
  /// Interface for att.fingGrp.vis
  /// </summary>
  public interface IAttFingGrpVis : IMEiAtt, IAttAltsym, IAttExtender, IAttPlacement, IAttVisualoffset, IAttXy
  {

  }


    /// <summary>
  /// Extension methods for att.fingGrp.vis
  /// </summary>
  public static class AttFingGrpVis_extensions
  {
    #region orient
    
    public static void SetOrient(this IAttFingGrpVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "orient", _val);
    }

    public static XAttribute GetOrient(this IAttFingGrpVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "orient");
    }

    public static bool HasOrient(this IAttFingGrpVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "orient");
    }

    public static void RemoveOrient(this IAttFingGrpVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "orient");
    }
    #endregion

  }

}