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
  /// Interface for att.pad.log
  /// </summary>
  public interface IAttPadLog : IMEiAtt, IAttEvent
  {

  }


    /// <summary>
  /// Extension methods for att.pad.log
  /// </summary>
  public static class AttPadLog_extensions
  {
    #region num
    
    public static void SetNum(this IAttPadLog e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "num", _val);
    }

    public static XAttribute GetNum(this IAttPadLog e)
    {
      return MeiAtt_controller.GetAttribute(e, "num");
    }

    public static bool HasNum(this IAttPadLog e)
    {
      return MeiAtt_controller.HasAttribute(e, "num");
    }

    public static void RemoveNum(this IAttPadLog e)
    {
      MeiAtt_controller.RemoveAttribute(e, "num");
    }
    #endregion

  }

}