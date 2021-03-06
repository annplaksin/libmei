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
  /// Interface for att.space.vis
  /// </summary>
  public interface IAttSpaceVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.space.vis
  /// </summary>
  public static class AttSpaceVis_extensions
  {
    #region compressable
    
    public static void SetCompressable(this IAttSpaceVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "compressable", _val);
    }

    public static XAttribute GetCompressable(this IAttSpaceVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "compressable");
    }

    public static bool HasCompressable(this IAttSpaceVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "compressable");
    }

    public static void RemoveCompressable(this IAttSpaceVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "compressable");
    }
    #endregion

  }

}