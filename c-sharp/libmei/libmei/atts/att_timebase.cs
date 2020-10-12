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
  /// Interface for att.timebase
  /// </summary>
  public interface IAttTimebase : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.timebase
  /// </summary>
  public static class AttTimebase_extensions
  {
    #region ppq
    
    public static void SetPpq(this IAttTimebase e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ppq", _val);
    }

    public static XAttribute GetPpq(this IAttTimebase e)
    {
      return MeiAtt_controller.GetAttribute(e, "ppq");
    }

    public static bool HasPpq(this IAttTimebase e)
    {
      return MeiAtt_controller.HasAttribute(e, "ppq");
    }

    public static void RemovePpq(this IAttTimebase e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ppq");
    }
    #endregion

  }

}