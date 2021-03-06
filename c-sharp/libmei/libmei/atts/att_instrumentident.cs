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
  /// Interface for att.instrumentident
  /// </summary>
  public interface IAttInstrumentident : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.instrumentident
  /// </summary>
  public static class AttInstrumentident_extensions
  {
    #region instr
    
    public static void SetInstr(this IAttInstrumentident e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "instr", _val);
    }

    public static XAttribute GetInstr(this IAttInstrumentident e)
    {
      return MeiAtt_controller.GetAttribute(e, "instr");
    }

    public static bool HasInstr(this IAttInstrumentident e)
    {
      return MeiAtt_controller.HasAttribute(e, "instr");
    }

    public static void RemoveInstr(this IAttInstrumentident e)
    {
      MeiAtt_controller.RemoveAttribute(e, "instr");
    }
    #endregion

  }

}