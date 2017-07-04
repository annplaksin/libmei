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
  /// Interface for att.multiRest.vis
  /// </summary>
  public interface IAttMultiRestVis : IMEiAtt, IAttAltsym, IAttExtsym, IAttStaffloc, IAttStafflocPitched, IAttTypography
  {

  }


    /// <summary>
  /// Extension methods for att.multiRest.vis
  /// </summary>
  public static class AttMultiRestVis_extensions
  {
    #region block
    
    public static void SetBlock(this IAttMultiRestVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "block", _val);
    }

    public static XAttribute GetBlock(this IAttMultiRestVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "block");
    }

    public static bool HasBlock(this IAttMultiRestVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "block");
    }

    public static void RemoveBlock(this IAttMultiRestVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "block");
    }
    #endregion

  }

}