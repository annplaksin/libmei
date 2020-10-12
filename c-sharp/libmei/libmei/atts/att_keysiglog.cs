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
  /// Interface for att.keySig.log
  /// </summary>
  public interface IAttKeySigLog : IMEiAtt, IAttAccidental, IAttPitch
  {

  }


    /// <summary>
  /// Extension methods for att.keySig.log
  /// </summary>
  public static class AttKeySigLog_extensions
  {
    #region sig
    
    public static void SetSig(this IAttKeySigLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "sig", _val);
    }

    public static XAttribute GetSig(this IAttKeySigLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "sig");
    }

    public static bool HasSig(this IAttKeySigLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "sig");
    }

    public static void RemoveSig(this IAttKeySigLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "sig");
    }
    #endregion

    #region sig.mixed
    
    public static void SetSigMixed(this IAttKeySigLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "sig.mixed", _val);
    }

    public static XAttribute GetSigMixed(this IAttKeySigLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "sig.mixed");
    }

    public static bool HasSigMixed(this IAttKeySigLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "sig.mixed");
    }

    public static void RemoveSigMixed(this IAttKeySigLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "sig.mixed");
    }
    #endregion

    #region mode
    
    public static void SetMode(this IAttKeySigLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mode", _val);
    }

    public static XAttribute GetMode(this IAttKeySigLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "mode");
    }

    public static bool HasMode(this IAttKeySigLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "mode");
    }

    public static void RemoveMode(this IAttKeySigLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mode");
    }
    #endregion

  }

}