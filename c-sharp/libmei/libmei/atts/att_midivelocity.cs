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
  /// Interface for att.midivelocity
  /// </summary>
  public interface IAttMidivelocity : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.midivelocity
  /// </summary>
  public static class AttMidivelocity_extensions
  {
    #region vel
    
    public static void SetVel(this IAttMidivelocity e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "vel", _val);
    }

    public static XAttribute GetVel(this IAttMidivelocity e)
    {
      return MeiAtt_controller.GetAttribute(e, "vel");
    }

    public static bool HasVel(this IAttMidivelocity e)
    {
      return MeiAtt_controller.HasAttribute(e, "vel");
    }

    public static void RemoveVel(this IAttMidivelocity e)
    {
      MeiAtt_controller.RemoveAttribute(e, "vel");
    }
    #endregion

  }

}