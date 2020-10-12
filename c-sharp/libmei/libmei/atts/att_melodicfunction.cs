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
  /// Interface for att.melodicfunction
  /// </summary>
  public interface IAttMelodicfunction : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.melodicfunction
  /// </summary>
  public static class AttMelodicfunction_extensions
  {
    #region mfunc
    
    public static void SetMfunc(this IAttMelodicfunction e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mfunc", _val);
    }

    public static XAttribute GetMfunc(this IAttMelodicfunction e)
    {
      return MeiAtt_controller.GetAttribute(e, "mfunc");
    }

    public static bool HasMfunc(this IAttMelodicfunction e)
    {
      return MeiAtt_controller.HasAttribute(e, "mfunc");
    }

    public static void RemoveMfunc(this IAttMelodicfunction e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mfunc");
    }
    #endregion

  }

}