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
  /// Interface for att.timestamp.musical
  /// </summary>
  public interface IAttTimestampMusical : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.timestamp.musical
  /// </summary>
  public static class AttTimestampMusical_extensions
  {
    #region tstamp
    
    public static void SetTstamp(this IAttTimestampMusical e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tstamp", _val);
    }

    public static XAttribute GetTstamp(this IAttTimestampMusical e)
    {
      return MeiAtt_controller.GetAttribute(e, "tstamp");
    }

    public static bool HasTstamp(this IAttTimestampMusical e)
    {
      return MeiAtt_controller.HasAttribute(e, "tstamp");
    }

    public static void RemoveTstamp(this IAttTimestampMusical e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tstamp");
    }
    #endregion

  }

}