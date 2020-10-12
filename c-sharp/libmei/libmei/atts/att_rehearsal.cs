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
  /// Interface for att.rehearsal
  /// </summary>
  public interface IAttRehearsal : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.rehearsal
  /// </summary>
  public static class AttRehearsal_extensions
  {
    #region reh.enclose
    
    public static void SetRehEnclose(this IAttRehearsal e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "reh.enclose", _val);
    }

    public static XAttribute GetRehEnclose(this IAttRehearsal e)
    {
      return MeiAtt_controller.GetAttribute(e, "reh.enclose");
    }

    public static bool HasRehEnclose(this IAttRehearsal e)
    {
      return MeiAtt_controller.HasAttribute(e, "reh.enclose");
    }

    public static void RemoveRehEnclose(this IAttRehearsal e)
    {
      MeiAtt_controller.RemoveAttribute(e, "reh.enclose");
    }
    #endregion

  }

}