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
  /// Interface for att.facsimile
  /// </summary>
  public interface IAttFacsimile : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.facsimile
  /// </summary>
  public static class AttFacsimile_extensions
  {
    #region facs
    
    public static void SetFacs(this IAttFacsimile e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "facs", _val);
    }

    public static XAttribute GetFacs(this IAttFacsimile e)
    {
      return MeiAtt_controller.GetAttribute(e, "facs");
    }

    public static bool HasFacs(this IAttFacsimile e)
    {
      return MeiAtt_controller.HasAttribute(e, "facs");
    }

    public static void RemoveFacs(this IAttFacsimile e)
    {
      MeiAtt_controller.RemoveAttribute(e, "facs");
    }
    #endregion

  }

}