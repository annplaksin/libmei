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
  /// Interface for att.tierend
  /// </summary>
  public interface IAttTierend : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.tierend
  /// </summary>
  public static class AttTierend_extensions
  {
    #region tie.lform
    
    public static void SetTieLform(this IAttTierend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tie.lform", _val);
    }

    public static XAttribute GetTieLform(this IAttTierend e)
    {
      return MeiAtt_controller.GetAttribute(e, "tie.lform");
    }

    public static bool HasTieLform(this IAttTierend e)
    {
      return MeiAtt_controller.HasAttribute(e, "tie.lform");
    }

    public static void RemoveTieLform(this IAttTierend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tie.lform");
    }
    #endregion

    #region tie.lwidth
    
    public static void SetTieLwidth(this IAttTierend e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "tie.lwidth", _val);
    }

    public static XAttribute GetTieLwidth(this IAttTierend e)
    {
      return MeiAtt_controller.GetAttribute(e, "tie.lwidth");
    }

    public static bool HasTieLwidth(this IAttTierend e)
    {
      return MeiAtt_controller.HasAttribute(e, "tie.lwidth");
    }

    public static void RemoveTieLwidth(this IAttTierend e)
    {
      MeiAtt_controller.RemoveAttribute(e, "tie.lwidth");
    }
    #endregion

  }

}