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
  /// Interface for att.internetmedia
  /// </summary>
  public interface IAttInternetmedia : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.internetmedia
  /// </summary>
  public static class AttInternetmedia_extensions
  {
    #region mimetype
    
    public static void SetMimetype(this IAttInternetmedia e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "mimetype", _val);
    }

    public static XAttribute GetMimetype(this IAttInternetmedia e)
    {
      return MeiAtt_controller.GetAttribute(e, "mimetype");
    }

    public static bool HasMimetype(this IAttInternetmedia e)
    {
      return MeiAtt_controller.HasAttribute(e, "mimetype");
    }

    public static void RemoveMimetype(this IAttInternetmedia e)
    {
      MeiAtt_controller.RemoveAttribute(e, "mimetype");
    }
    #endregion

  }

}