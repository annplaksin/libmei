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
  /// Interface for att.pb.vis
  /// </summary>
  public interface IAttPbVis : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pb.vis
  /// </summary>
  public static class AttPbVis_extensions
  {
    #region folium
    
    public static void SetFolium(this IAttPbVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "folium", _val);
    }

    public static XAttribute GetFolium(this IAttPbVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "folium");
    }

    public static bool HasFolium(this IAttPbVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "folium");
    }

    public static void RemoveFolium(this IAttPbVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "folium");
    }
    #endregion

  }

}