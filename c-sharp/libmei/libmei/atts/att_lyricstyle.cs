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
  /// Interface for att.lyricstyle
  /// </summary>
  public interface IAttLyricstyle : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.lyricstyle
  /// </summary>
  public static class AttLyricstyle_extensions
  {
    #region lyric.align
    
    public static void SetLyricAlign(this IAttLyricstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lyric.align", _val);
    }

    public static XAttribute GetLyricAlign(this IAttLyricstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "lyric.align");
    }

    public static bool HasLyricAlign(this IAttLyricstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "lyric.align");
    }

    public static void RemoveLyricAlign(this IAttLyricstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lyric.align");
    }
    #endregion

    #region lyric.fam
    
    public static void SetLyricFam(this IAttLyricstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lyric.fam", _val);
    }

    public static XAttribute GetLyricFam(this IAttLyricstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "lyric.fam");
    }

    public static bool HasLyricFam(this IAttLyricstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "lyric.fam");
    }

    public static void RemoveLyricFam(this IAttLyricstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lyric.fam");
    }
    #endregion

    #region lyric.name
    
    public static void SetLyricName(this IAttLyricstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lyric.name", _val);
    }

    public static XAttribute GetLyricName(this IAttLyricstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "lyric.name");
    }

    public static bool HasLyricName(this IAttLyricstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "lyric.name");
    }

    public static void RemoveLyricName(this IAttLyricstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lyric.name");
    }
    #endregion

    #region lyric.size
    
    public static void SetLyricSize(this IAttLyricstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lyric.size", _val);
    }

    public static XAttribute GetLyricSize(this IAttLyricstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "lyric.size");
    }

    public static bool HasLyricSize(this IAttLyricstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "lyric.size");
    }

    public static void RemoveLyricSize(this IAttLyricstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lyric.size");
    }
    #endregion

    #region lyric.style
    
    public static void SetLyricStyle(this IAttLyricstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lyric.style", _val);
    }

    public static XAttribute GetLyricStyle(this IAttLyricstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "lyric.style");
    }

    public static bool HasLyricStyle(this IAttLyricstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "lyric.style");
    }

    public static void RemoveLyricStyle(this IAttLyricstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lyric.style");
    }
    #endregion

    #region lyric.weight
    
    public static void SetLyricWeight(this IAttLyricstyle e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lyric.weight", _val);
    }

    public static XAttribute GetLyricWeight(this IAttLyricstyle e)
    {
      return MeiAtt_controller.GetAttribute(e, "lyric.weight");
    }

    public static bool HasLyricWeight(this IAttLyricstyle e)
    {
      return MeiAtt_controller.HasAttribute(e, "lyric.weight");
    }

    public static void RemoveLyricWeight(this IAttLyricstyle e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lyric.weight");
    }
    #endregion

  }

}