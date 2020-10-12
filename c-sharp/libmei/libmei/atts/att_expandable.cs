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
  /// Interface for att.expandable
  /// </summary>
  public interface IAttExpandable : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.expandable
  /// </summary>
  public static class AttExpandable_extensions
  {
    #region expand
    
    public static void SetExpand(this IAttExpandable e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "expand", _val);
    }

    public static XAttribute GetExpand(this IAttExpandable e)
    {
      return MeiAtt_controller.GetAttribute(e, "expand");
    }

    public static bool HasExpand(this IAttExpandable e)
    {
      return MeiAtt_controller.HasAttribute(e, "expand");
    }

    public static void RemoveExpand(this IAttExpandable e)
    {
      MeiAtt_controller.RemoveAttribute(e, "expand");
    }
    #endregion

  }

}