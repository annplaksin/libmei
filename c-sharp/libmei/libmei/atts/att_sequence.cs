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
  /// Interface for att.sequence
  /// </summary>
  public interface IAttSequence : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.sequence
  /// </summary>
  public static class AttSequence_extensions
  {
    #region seq
    
    public static void SetSeq(this IAttSequence e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "seq", _val);
    }

    public static XAttribute GetSeq(this IAttSequence e)
    {
      return MeiAtt_controller.GetAttribute(e, "seq");
    }

    public static bool HasSeq(this IAttSequence e)
    {
      return MeiAtt_controller.HasAttribute(e, "seq");
    }

    public static void RemoveSeq(this IAttSequence e)
    {
      MeiAtt_controller.RemoveAttribute(e, "seq");
    }
    #endregion

  }

}