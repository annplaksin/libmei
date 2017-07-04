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
  /// Interface for att.fretlocation
  /// </summary>
  public interface IAttFretlocation : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.fretlocation
  /// </summary>
  public static class AttFretlocation_extensions
  {
    #region fret
    
    public static void SetFret(this IAttFretlocation e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "fret", _val);
    }

    public static XAttribute GetFret(this IAttFretlocation e)
    {
      return MeiAtt_controller.GetAttribute(e, "fret");
    }

    public static bool HasFret(this IAttFretlocation e)
    {
      return MeiAtt_controller.HasAttribute(e, "fret");
    }

    public static void RemoveFret(this IAttFretlocation e)
    {
      MeiAtt_controller.RemoveAttribute(e, "fret");
    }
    #endregion

  }

}