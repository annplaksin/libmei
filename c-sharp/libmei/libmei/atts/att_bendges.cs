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
  /// Interface for att.bend.ges
  /// </summary>
  public interface IAttBendGes : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.bend.ges
  /// </summary>
  public static class AttBendGes_extensions
  {
    #region amount
    
    public static void SetAmount(this IAttBendGes e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "amount", _val);
    }

    public static XAttribute GetAmount(this IAttBendGes e)
    {
      return MeiAtt_controller.GetAttribute(e, "amount");
    }

    public static bool HasAmount(this IAttBendGes e)
    {
      return MeiAtt_controller.HasAttribute(e, "amount");
    }

    public static void RemoveAmount(this IAttBendGes e)
    {
      MeiAtt_controller.RemoveAttribute(e, "amount");
    }
    #endregion

  }

}