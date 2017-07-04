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
  /// Interface for att.harpPedal.log
  /// </summary>
  public interface IAttHarpPedalLog : IMEiAtt, IAttControlevent, IAttStartendid
  {

  }


    /// <summary>
  /// Extension methods for att.harpPedal.log
  /// </summary>
  public static class AttHarpPedalLog_extensions
  {
    #region c
    
    public static void SetC(this IAttHarpPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "c", _val);
    }

    public static XAttribute GetC(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "c");
    }

    public static bool HasC(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "c");
    }

    public static void RemoveC(this IAttHarpPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "c");
    }
    #endregion

    #region d
    
    public static void SetD(this IAttHarpPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "d", _val);
    }

    public static XAttribute GetD(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "d");
    }

    public static bool HasD(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "d");
    }

    public static void RemoveD(this IAttHarpPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "d");
    }
    #endregion

    #region e
    
    public static void SetE(this IAttHarpPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "e", _val);
    }

    public static XAttribute GetE(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "e");
    }

    public static bool HasE(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "e");
    }

    public static void RemoveE(this IAttHarpPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "e");
    }
    #endregion

    #region f
    
    public static void SetF(this IAttHarpPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "f", _val);
    }

    public static XAttribute GetF(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "f");
    }

    public static bool HasF(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "f");
    }

    public static void RemoveF(this IAttHarpPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "f");
    }
    #endregion

    #region g
    
    public static void SetG(this IAttHarpPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "g", _val);
    }

    public static XAttribute GetG(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "g");
    }

    public static bool HasG(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "g");
    }

    public static void RemoveG(this IAttHarpPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "g");
    }
    #endregion

    #region a
    
    public static void SetA(this IAttHarpPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "a", _val);
    }

    public static XAttribute GetA(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "a");
    }

    public static bool HasA(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "a");
    }

    public static void RemoveA(this IAttHarpPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "a");
    }
    #endregion

    #region b
    
    public static void SetB(this IAttHarpPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "b", _val);
    }

    public static XAttribute GetB(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "b");
    }

    public static bool HasB(this IAttHarpPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "b");
    }

    public static void RemoveB(this IAttHarpPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "b");
    }
    #endregion

  }

}