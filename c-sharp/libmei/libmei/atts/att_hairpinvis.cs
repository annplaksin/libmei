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
  /// Interface for att.hairpin.vis
  /// </summary>
  public interface IAttHairpinVis : IMEiAtt, IAttColor, IAttLinerendBase, IAttPlacement, IAttVisualoffset, IAttVisualoffset2, IAttXy, IAttXy2
  {

  }


    /// <summary>
  /// Extension methods for att.hairpin.vis
  /// </summary>
  public static class AttHairpinVis_extensions
  {
    #region opening
    
    public static void SetOpening(this IAttHairpinVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "opening", _val);
    }

    public static XAttribute GetOpening(this IAttHairpinVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "opening");
    }

    public static bool HasOpening(this IAttHairpinVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "opening");
    }

    public static void RemoveOpening(this IAttHairpinVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "opening");
    }
    #endregion

  }

}