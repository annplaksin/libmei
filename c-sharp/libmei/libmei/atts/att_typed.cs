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
  /// Interface for att.typed
  /// </summary>
  public interface IAttTyped : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.typed
  /// </summary>
  public static class AttTyped_extensions
  {
    #region typeAttribute
    
    public static void SetTypeAttribute(this IAttTyped e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "type", _val);
    }

    public static XAttribute GetTypeAttribute(this IAttTyped e)
    {
      return MeiAtt_controller.GetAttribute(e, "type");
    }

    public static bool HasTypeAttribute(this IAttTyped e)
    {
      return MeiAtt_controller.HasAttribute(e, "type");
    }

    public static void RemoveTypeAttribute(this IAttTyped e)
    {
      MeiAtt_controller.RemoveAttribute(e, "type");
    }
    #endregion

    #region subtype
    
    public static void SetSubtype(this IAttTyped e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "subtype", _val);
    }

    public static XAttribute GetSubtype(this IAttTyped e)
    {
      return MeiAtt_controller.GetAttribute(e, "subtype");
    }

    public static bool HasSubtype(this IAttTyped e)
    {
      return MeiAtt_controller.HasAttribute(e, "subtype");
    }

    public static void RemoveSubtype(this IAttTyped e)
    {
      MeiAtt_controller.RemoveAttribute(e, "subtype");
    }
    #endregion

  }

}