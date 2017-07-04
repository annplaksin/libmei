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
  /// Interface for att.filing
  /// </summary>
  public interface IAttFiling : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.filing
  /// </summary>
  public static class AttFiling_extensions
  {
    #region nonfiling
    
    public static void SetNonfiling(this IAttFiling e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "nonfiling", _val);
    }

    public static XAttribute GetNonfiling(this IAttFiling e)
    {
      return MeiAtt_controller.GetAttribute(e, "nonfiling");
    }

    public static bool HasNonfiling(this IAttFiling e)
    {
      return MeiAtt_controller.HasAttribute(e, "nonfiling");
    }

    public static void RemoveNonfiling(this IAttFiling e)
    {
      MeiAtt_controller.RemoveAttribute(e, "nonfiling");
    }
    #endregion

  }

}