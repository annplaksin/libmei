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
  /// Interface for att.slurrend
  /// </summary>
  public interface IAttSlurrend : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.slurrend
  /// </summary>
  public static class AttSlurrend_extensions
  {
    #region slur.lform
    
    public static void SetSlurLform(this IAttSlurrend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "slur.lform", _val);
    }

    public static XAttribute GetSlurLform(this IAttSlurrend e)
    {
      return MeiAtt_controller.GetAttribute(e, "slur.lform");
    }

    public static bool HasSlurLform(this IAttSlurrend e)
    {
      return MeiAtt_controller.HasAttribute(e, "slur.lform");
    }

    public static void RemoveSlurLform(this IAttSlurrend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "slur.lform");
    }
    #endregion

    #region slur.lwidth
    
    public static void SetSlurLwidth(this IAttSlurrend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "slur.lwidth", _val);
    }

    public static XAttribute GetSlurLwidth(this IAttSlurrend e)
    {
      return MeiAtt_controller.GetAttribute(e, "slur.lwidth");
    }

    public static bool HasSlurLwidth(this IAttSlurrend e)
    {
      return MeiAtt_controller.HasAttribute(e, "slur.lwidth");
    }

    public static void RemoveSlurLwidth(this IAttSlurrend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "slur.lwidth");
    }
    #endregion

  }

}