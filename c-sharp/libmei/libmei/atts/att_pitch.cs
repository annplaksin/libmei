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
  /// Interface for att.pitch
  /// </summary>
  public interface IAttPitch : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pitch
  /// </summary>
  public static class AttPitch_extensions
  {
    #region pname
    
    public static void SetPname(this IAttPitch e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "pname", _val);
    }

    public static XAttribute GetPname(this IAttPitch e)
    {
      return MeiAtt_controller.GetAttribute(e, "pname");
    }

    public static bool HasPname(this IAttPitch e)
    {
      return MeiAtt_controller.HasAttribute(e, "pname");
    }

    public static void RemovePname(this IAttPitch e)
    {
      MeiAtt_controller.RemoveAttribute(e, "pname");
    }
    #endregion

  }

}