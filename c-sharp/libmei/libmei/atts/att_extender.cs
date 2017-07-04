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
  /// Interface for att.extender
  /// </summary>
  public interface IAttExtender : IMEiAtt, IAttLinerend
  {

  }


    /// <summary>
  /// Extension methods for att.extender
  /// </summary>
  public static class AttExtender_extensions
  {
    #region extender
    
    public static void SetExtender(this IAttExtender e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "extender", _val);
    }

    public static XAttribute GetExtender(this IAttExtender e)
    {
      return MeiAtt_controller.GetAttribute(e, "extender");
    }

    public static bool HasExtender(this IAttExtender e)
    {
      return MeiAtt_controller.HasAttribute(e, "extender");
    }

    public static void RemoveExtender(this IAttExtender e)
    {
      MeiAtt_controller.RemoveAttribute(e, "extender");
    }
    #endregion

  }

}