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
  /// Interface for att.arpeg.log
  /// </summary>
  public interface IAttArpegLog : IMEiAtt, IAttControlevent, IAttStartid
  {

  }


    /// <summary>
  /// Extension methods for att.arpeg.log
  /// </summary>
  public static class AttArpegLog_extensions
  {
    #region order
    
    public static void SetOrder(this IAttArpegLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "order", _val);
    }

    public static XAttribute GetOrder(this IAttArpegLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "order");
    }

    public static bool HasOrder(this IAttArpegLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "order");
    }

    public static void RemoveOrder(this IAttArpegLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "order");
    }
    #endregion

  }

}