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
  /// Interface for att.height
  /// </summary>
  public interface IAttHeight : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.height
  /// </summary>
  public static class AttHeight_extensions
  {
    #region height
    
    public static void SetHeight(this IAttHeight e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "height", _val);
    }

    public static XAttribute GetHeight(this IAttHeight e)
    {
      return MeiAtt_controller.GetAttribute(e, "height");
    }

    public static bool HasHeight(this IAttHeight e)
    {
      return MeiAtt_controller.HasAttribute(e, "height");
    }

    public static void RemoveHeight(this IAttHeight e)
    {
      MeiAtt_controller.RemoveAttribute(e, "height");
    }
    #endregion

  }

}