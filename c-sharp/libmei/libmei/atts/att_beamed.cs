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
  /// Interface for att.beamed
  /// </summary>
  public interface IAttBeamed : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.beamed
  /// </summary>
  public static class AttBeamed_extensions
  {
    #region beam
    
    public static void SetBeam(this IAttBeamed e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "beam", _val);
    }

    public static XAttribute GetBeam(this IAttBeamed e)
    {
      return MeiAtt_controller.GetAttribute(e, "beam");
    }

    public static bool HasBeam(this IAttBeamed e)
    {
      return MeiAtt_controller.HasAttribute(e, "beam");
    }

    public static void RemoveBeam(this IAttBeamed e)
    {
      MeiAtt_controller.RemoveAttribute(e, "beam");
    }
    #endregion

  }

}