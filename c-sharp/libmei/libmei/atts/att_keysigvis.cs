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
  /// Interface for att.keySig.vis
  /// </summary>
  public interface IAttKeySigVis : IMEiAtt, IAttVisibility
  {

  }


    /// <summary>
  /// Extension methods for att.keySig.vis
  /// </summary>
  public static class AttKeySigVis_extensions
  {
    #region sig.showchange
    
    public static void SetSigShowchange(this IAttKeySigVis e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "sig.showchange", _val);
    }

    public static XAttribute GetSigShowchange(this IAttKeySigVis e)
    {
      return MeiAtt_controller.GetAttribute(e, "sig.showchange");
    }

    public static bool HasSigShowchange(this IAttKeySigVis e)
    {
      return MeiAtt_controller.HasAttribute(e, "sig.showchange");
    }

    public static void RemoveSigShowchange(this IAttKeySigVis e)
    {
      MeiAtt_controller.RemoveAttribute(e, "sig.showchange");
    }
    #endregion

  }

}