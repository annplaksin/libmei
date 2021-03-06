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
  /// Interface for att.altsym
  /// </summary>
  public interface IAttAltsym : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.altsym
  /// </summary>
  public static class AttAltsym_extensions
  {
    #region altsym
    
    public static void SetAltsym(this IAttAltsym e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "altsym", _val);
    }

    public static XAttribute GetAltsym(this IAttAltsym e)
    {
      return MeiAtt_controller.GetAttribute(e, "altsym");
    }

    public static bool HasAltsym(this IAttAltsym e)
    {
      return MeiAtt_controller.HasAttribute(e, "altsym");
    }

    public static void RemoveAltsym(this IAttAltsym e)
    {
      MeiAtt_controller.RemoveAttribute(e, "altsym");
    }
    #endregion

  }

}