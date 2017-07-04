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
  /// Interface for att.ornam
  /// </summary>
  public interface IAttOrnam : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.ornam
  /// </summary>
  public static class AttOrnam_extensions
  {
    #region ornam
    
    public static void SetOrnam(this IAttOrnam e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ornam", _val);
    }

    public static XAttribute GetOrnam(this IAttOrnam e)
    {
      return MeiAtt_controller.GetAttribute(e, "ornam");
    }

    public static bool HasOrnam(this IAttOrnam e)
    {
      return MeiAtt_controller.HasAttribute(e, "ornam");
    }

    public static void RemoveOrnam(this IAttOrnam e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ornam");
    }
    #endregion

  }

}