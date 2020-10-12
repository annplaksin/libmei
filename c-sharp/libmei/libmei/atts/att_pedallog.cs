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
  /// Interface for att.pedal.log
  /// </summary>
  public interface IAttPedalLog : IMEiAtt, IAttControlevent, IAttStartendid
  {

  }


    /// <summary>
  /// Extension methods for att.pedal.log
  /// </summary>
  public static class AttPedalLog_extensions
  {
    #region dir
    
    public static void SetDir(this IAttPedalLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dir", _val);
    }

    public static XAttribute GetDir(this IAttPedalLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "dir");
    }

    public static bool HasDir(this IAttPedalLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "dir");
    }

    public static void RemoveDir(this IAttPedalLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dir");
    }
    #endregion

  }

}