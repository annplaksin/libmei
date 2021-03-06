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
  /// Interface for att.uneume.log
  /// </summary>
  public interface IAttUneumeLog : IMEiAtt, IAttEvent, IAttSyltext
  {

  }


    /// <summary>
  /// Extension methods for att.uneume.log
  /// </summary>
  public static class AttUneumeLog_extensions
  {
    #region form
    
    public static void SetForm(this IAttUneumeLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "form", _val);
    }

    public static XAttribute GetForm(this IAttUneumeLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "form");
    }

    public static bool HasForm(this IAttUneumeLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "form");
    }

    public static void RemoveForm(this IAttUneumeLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "form");
    }
    #endregion

    #region name
    
    public static void SetName(this IAttUneumeLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "name", _val);
    }

    public static XAttribute GetName(this IAttUneumeLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "name");
    }

    public static bool HasName(this IAttUneumeLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "name");
    }

    public static void RemoveName(this IAttUneumeLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "name");
    }
    #endregion

  }

}