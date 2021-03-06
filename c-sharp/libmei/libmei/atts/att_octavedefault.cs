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
  /// Interface for att.octavedefault
  /// </summary>
  public interface IAttOctavedefault : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.octavedefault
  /// </summary>
  public static class AttOctavedefault_extensions
  {
    #region octave.default
    
    public static void SetOctaveDefault(this IAttOctavedefault e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "octave.default", _val);
    }

    public static XAttribute GetOctaveDefault(this IAttOctavedefault e)
    {
      return MeiAtt_controller.GetAttribute(e, "octave.default");
    }

    public static bool HasOctaveDefault(this IAttOctavedefault e)
    {
      return MeiAtt_controller.HasAttribute(e, "octave.default");
    }

    public static void RemoveOctaveDefault(this IAttOctavedefault e)
    {
      MeiAtt_controller.RemoveAttribute(e, "octave.default");
    }
    #endregion

  }

}