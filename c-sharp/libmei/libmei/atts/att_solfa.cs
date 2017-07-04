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
  /// Interface for att.solfa
  /// </summary>
  public interface IAttSolfa : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.solfa
  /// </summary>
  public static class AttSolfa_extensions
  {
    #region psolfa
    
    public static void SetPsolfa(this IAttSolfa e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "psolfa", _val);
    }

    public static XAttribute GetPsolfa(this IAttSolfa e)
    {
      return MeiAtt_controller.GetAttribute(e, "psolfa");
    }

    public static bool HasPsolfa(this IAttSolfa e)
    {
      return MeiAtt_controller.HasAttribute(e, "psolfa");
    }

    public static void RemovePsolfa(this IAttSolfa e)
    {
      MeiAtt_controller.RemoveAttribute(e, "psolfa");
    }
    #endregion

  }

}