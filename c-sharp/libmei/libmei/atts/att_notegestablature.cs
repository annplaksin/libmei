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
  /// Interface for att.note.ges.tablature
  /// </summary>
  public interface IAttNoteGesTablature : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.note.ges.tablature
  /// </summary>
  public static class AttNoteGesTablature_extensions
  {
    #region tab.fret
    
    public static void SetTabFret(this IAttNoteGesTablature e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tab.fret", _val);
    }

    public static XAttribute GetTabFret(this IAttNoteGesTablature e)
    {
      return MeiAtt_controller.GetAttribute(e, "tab.fret");
    }

    public static bool HasTabFret(this IAttNoteGesTablature e)
    {
      return MeiAtt_controller.HasAttribute(e, "tab.fret");
    }

    public static void RemoveTabFret(this IAttNoteGesTablature e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tab.fret");
    }
    #endregion

    #region tab.string
    
    public static void SetTabString(this IAttNoteGesTablature e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tab.string", _val);
    }

    public static XAttribute GetTabString(this IAttNoteGesTablature e)
    {
      return MeiAtt_controller.GetAttribute(e, "tab.string");
    }

    public static bool HasTabString(this IAttNoteGesTablature e)
    {
      return MeiAtt_controller.HasAttribute(e, "tab.string");
    }

    public static void RemoveTabString(this IAttNoteGesTablature e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tab.string");
    }
    #endregion

  }

}