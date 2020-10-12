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
  /// Interface for att.ornamentaccid
  /// </summary>
  public interface IAttOrnamentaccid : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.ornamentaccid
  /// </summary>
  public static class AttOrnamentaccid_extensions
  {
    #region accidupper
    
    public static void SetAccidupper(this IAttOrnamentaccid e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "accidupper", _val);
    }

    public static XAttribute GetAccidupper(this IAttOrnamentaccid e)
    {
      return MeiAtt_controller.GetAttribute(e, "accidupper");
    }

    public static bool HasAccidupper(this IAttOrnamentaccid e)
    {
      return MeiAtt_controller.HasAttribute(e, "accidupper");
    }

    public static void RemoveAccidupper(this IAttOrnamentaccid e)
    {
      MeiAtt_controller.RemoveAttribute(e, "accidupper");
    }
    #endregion

    #region accidlower
    
    public static void SetAccidlower(this IAttOrnamentaccid e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "accidlower", _val);
    }

    public static XAttribute GetAccidlower(this IAttOrnamentaccid e)
    {
      return MeiAtt_controller.GetAttribute(e, "accidlower");
    }

    public static bool HasAccidlower(this IAttOrnamentaccid e)
    {
      return MeiAtt_controller.HasAttribute(e, "accidlower");
    }

    public static void RemoveAccidlower(this IAttOrnamentaccid e)
    {
      MeiAtt_controller.RemoveAttribute(e, "accidlower");
    }
    #endregion

  }

}