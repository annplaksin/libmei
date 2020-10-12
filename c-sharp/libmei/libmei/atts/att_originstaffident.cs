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
  /// Interface for att.origin.staffident
  /// </summary>
  public interface IAttOriginStaffident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.origin.staffident
  /// </summary>
  public static class AttOriginStaffident_extensions
  {
    #region origin.staff
    
    public static void SetOriginStaff(this IAttOriginStaffident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "origin.staff", _val);
    }

    public static XAttribute GetOriginStaff(this IAttOriginStaffident e)
    {
      return MeiAtt_controller.GetAttribute(e, "origin.staff");
    }

    public static bool HasOriginStaff(this IAttOriginStaffident e)
    {
      return MeiAtt_controller.HasAttribute(e, "origin.staff");
    }

    public static void RemoveOriginStaff(this IAttOriginStaffident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "origin.staff");
    }
    #endregion

  }

}