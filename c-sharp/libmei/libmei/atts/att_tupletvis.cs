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
  /// Interface for att.tuplet.vis
  /// </summary>
  public interface IAttTupletVis : IMEiAtt, IAttColor, IAttNumberplacement
  {

  }


    /// <summary>
  /// Extension methods for att.tuplet.vis
  /// </summary>
  public static class AttTupletVis_extensions
  {
    #region bracket.place
    
    public static void SetBracketPlace(this IAttTupletVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "bracket.place", _val);
    }

    public static XAttribute GetBracketPlace(this IAttTupletVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "bracket.place");
    }

    public static bool HasBracketPlace(this IAttTupletVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "bracket.place");
    }

    public static void RemoveBracketPlace(this IAttTupletVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "bracket.place");
    }
    #endregion

    #region bracket.visible
    
    public static void SetBracketVisible(this IAttTupletVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "bracket.visible", _val);
    }

    public static XAttribute GetBracketVisible(this IAttTupletVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "bracket.visible");
    }

    public static bool HasBracketVisible(this IAttTupletVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "bracket.visible");
    }

    public static void RemoveBracketVisible(this IAttTupletVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "bracket.visible");
    }
    #endregion

    #region dur.visible
    
    public static void SetDurVisible(this IAttTupletVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dur.visible", _val);
    }

    public static XAttribute GetDurVisible(this IAttTupletVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "dur.visible");
    }

    public static bool HasDurVisible(this IAttTupletVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "dur.visible");
    }

    public static void RemoveDurVisible(this IAttTupletVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dur.visible");
    }
    #endregion

    #region num.format
    
    public static void SetNumFormat(this IAttTupletVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "num.format", _val);
    }

    public static XAttribute GetNumFormat(this IAttTupletVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "num.format");
    }

    public static bool HasNumFormat(this IAttTupletVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "num.format");
    }

    public static void RemoveNumFormat(this IAttTupletVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "num.format");
    }
    #endregion

  }

}