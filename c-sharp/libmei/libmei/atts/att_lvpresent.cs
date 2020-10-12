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
  /// Interface for att.lvpresent
  /// </summary>
  public interface IAttLvpresent : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.lvpresent
  /// </summary>
  public static class AttLvpresent_extensions
  {
    #region lv
    
    public static void SetLv(this IAttLvpresent e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lv", _val);
    }

    public static XAttribute GetLv(this IAttLvpresent e)
    {
      return MeiAtt_controller.GetAttribute(e, "lv");
    }

    public static bool HasLv(this IAttLvpresent e)
    {
      return MeiAtt_controller.HasAttribute(e, "lv");
    }

    public static void RemoveLv(this IAttLvpresent e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lv");
    }
    #endregion

  }

}