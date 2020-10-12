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
  /// Interface for att.turn.log
  /// </summary>
  public interface IAttTurnLog : IMEiAtt, IAttControlevent, IAttOrnamentaccid, IAttStartid
  {

  }


    /// <summary>
  /// Extension methods for att.turn.log
  /// </summary>
  public static class AttTurnLog_extensions
  {
    #region delayed
    
    public static void SetDelayed(this IAttTurnLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "delayed", _val);
    }

    public static XAttribute GetDelayed(this IAttTurnLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "delayed");
    }

    public static bool HasDelayed(this IAttTurnLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "delayed");
    }

    public static void RemoveDelayed(this IAttTurnLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "delayed");
    }
    #endregion

    #region form
    
    public static void SetForm(this IAttTurnLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetForm(this IAttTurnLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }

    public static bool HasForm(this IAttTurnLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttTurnLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

  }

}