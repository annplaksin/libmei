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
  /// Interface for att.stems
  /// </summary>
  public interface IAttStems : IMEiAtt, IAttStemsCmn
  {

  }


    /// <summary>
  /// Extension methods for att.stems
  /// </summary>
  public static class AttStems_extensions
  {
    #region stem.dir
    
    public static void SetStemDir(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.dir", _val);
    }

    public static XAttribute GetStemDir(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.dir");
    }

    public static bool HasStemDir(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.dir");
    }

    public static void RemoveStemDir(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.dir");
    }
    #endregion

    #region stem.len
    
    public static void SetStemLen(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.len", _val);
    }

    public static XAttribute GetStemLen(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.len");
    }

    public static bool HasStemLen(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.len");
    }

    public static void RemoveStemLen(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.len");
    }
    #endregion

    #region stem.mod
    
    public static void SetStemMod(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.mod", _val);
    }

    public static XAttribute GetStemMod(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.mod");
    }

    public static bool HasStemMod(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.mod");
    }

    public static void RemoveStemMod(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.mod");
    }
    #endregion

    #region stem.pos
    
    public static void SetStemPos(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.pos", _val);
    }

    public static XAttribute GetStemPos(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.pos");
    }

    public static bool HasStemPos(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.pos");
    }

    public static void RemoveStemPos(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.pos");
    }
    #endregion

    #region stem.x
    
    public static void SetStemX(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.x", _val);
    }

    public static XAttribute GetStemX(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.x");
    }

    public static bool HasStemX(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.x");
    }

    public static void RemoveStemX(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.x");
    }
    #endregion

    #region stem.y
    
    public static void SetStemY(this IAttStems e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.y", _val);
    }

    public static XAttribute GetStemY(this IAttStems e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.y");
    }

    public static bool HasStemY(this IAttStems e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.y");
    }

    public static void RemoveStemY(this IAttStems e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.y");
    }
    #endregion

  }

}