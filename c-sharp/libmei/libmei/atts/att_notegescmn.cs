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
  /// Interface for att.note.ges.cmn
  /// </summary>
  public interface IAttNoteGesCmn : IMEiAtt, IAttGraced
  {

  }


    /// <summary>
  /// Extension methods for att.note.ges.cmn
  /// </summary>
  public static class AttNoteGesCmn_extensions
  {
    #region gliss
    
    public static void SetGliss(this IAttNoteGesCmn e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "gliss", _val);
    }

    public static XAttribute GetGliss(this IAttNoteGesCmn e)
    {
      return MeiAtt_controller.GetAttribute(e, "gliss");
    }

    public static bool HasGliss(this IAttNoteGesCmn e)
    {
      return MeiAtt_controller.HasAttribute(e, "gliss");
    }

    public static void RemoveGliss(this IAttNoteGesCmn e)
    {
      MeiAtt_controller.RemoveAttribute(e, "gliss");
    }
    #endregion

  }

}