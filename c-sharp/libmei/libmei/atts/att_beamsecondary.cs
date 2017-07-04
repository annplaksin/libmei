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
  /// Interface for att.beamsecondary
  /// </summary>
  public interface IAttBeamsecondary : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.beamsecondary
  /// </summary>
  public static class AttBeamsecondary_extensions
  {
    #region breaksec
    
    public static void SetBreaksec(this IAttBeamsecondary e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "breaksec", _val);
    }

    public static XAttribute GetBreaksec(this IAttBeamsecondary e)
    {
      return MeiAtt_controller.GetAttribute(e, "breaksec");
    }

    public static bool HasBreaksec(this IAttBeamsecondary e)
    {
      return MeiAtt_controller.HasAttribute(e, "breaksec");
    }

    public static void RemoveBreaksec(this IAttBeamsecondary e)
    {
      MeiAtt_controller.RemoveAttribute(e, "breaksec");
    }
    #endregion

  }

}