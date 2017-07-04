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
  /// Interface for att.mordent.log
  /// </summary>
  public interface IAttMordentLog : IMEiAtt, IAttControlevent, IAttStartendid, IAttOrnamentaccid
  {

  }


    /// <summary>
  /// Extension methods for att.mordent.log
  /// </summary>
  public static class AttMordentLog_extensions
  {
    #region form
    
    public static void SetForm(this IAttMordentLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetForm(this IAttMordentLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }

    public static bool HasForm(this IAttMordentLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttMordentLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

    #region long
    
    public static void SetLong(this IAttMordentLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "long", _val);
    }

    public static XAttribute GetLong(this IAttMordentLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "long");
    }

    public static bool HasLong(this IAttMordentLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "long");
    }

    public static void RemoveLong(this IAttMordentLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "long");
    }
    #endregion

  }

}