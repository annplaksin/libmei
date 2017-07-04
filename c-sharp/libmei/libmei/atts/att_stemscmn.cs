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
  /// Interface for att.stems.cmn
  /// </summary>
  public interface IAttStemsCmn : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.stems.cmn
  /// </summary>
  public static class AttStemsCmn_extensions
  {
    #region stem.with
    
    public static void SetStemWith(this IAttStemsCmn e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "stem.with", _val);
    }

    public static XAttribute GetStemWith(this IAttStemsCmn e)
    {
      return MeiAtt_controller.GetAttribute(e, "stem.with");
    }

    public static bool HasStemWith(this IAttStemsCmn e)
    {
      return MeiAtt_controller.HasAttribute(e, "stem.with");
    }

    public static void RemoveStemWith(this IAttStemsCmn e)
    {
      MeiAtt_controller.RemoveAttribute(e, "stem.with");
    }
    #endregion

  }

}