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
  /// Interface for att.intervalharmonic
  /// </summary>
  public interface IAttIntervalharmonic : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.intervalharmonic
  /// </summary>
  public static class AttIntervalharmonic_extensions
  {
    #region inth
    
    public static void SetInth(this IAttIntervalharmonic e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "inth", _val);
    }

    public static XAttribute GetInth(this IAttIntervalharmonic e)
    {
      return MeiAtt_controller.GetAttribute(e, "inth");
    }

    public static bool HasInth(this IAttIntervalharmonic e)
    {
      return MeiAtt_controller.HasAttribute(e, "inth");
    }

    public static void RemoveInth(this IAttIntervalharmonic e)
    {
      MeiAtt_controller.RemoveAttribute(e, "inth");
    }
    #endregion

  }

}