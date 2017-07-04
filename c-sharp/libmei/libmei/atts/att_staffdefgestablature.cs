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
  /// Interface for att.staffDef.ges.tablature
  /// </summary>
  public interface IAttStaffDefGesTablature : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.staffDef.ges.tablature
  /// </summary>
  public static class AttStaffDefGesTablature_extensions
  {
    #region tab.strings
    
    public static void SetTabStrings(this IAttStaffDefGesTablature e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tab.strings", _val);
    }

    public static XAttribute GetTabStrings(this IAttStaffDefGesTablature e)
    {
      return MeiAtt_controller.GetAttribute(e, "tab.strings");
    }

    public static bool HasTabStrings(this IAttStaffDefGesTablature e)
    {
      return MeiAtt_controller.HasAttribute(e, "tab.strings");
    }

    public static void RemoveTabStrings(this IAttStaffDefGesTablature e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tab.strings");
    }
    #endregion

  }

}