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
  /// Interface for att.distances
  /// </summary>
  public interface IAttDistances : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.distances
  /// </summary>
  public static class AttDistances_extensions
  {
    #region dynam.dist
    
    public static void SetDynamDist(this IAttDistances e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "dynam.dist", _val);
    }

    public static XAttribute GetDynamDist(this IAttDistances e)
    {
      return MeiAtt_controller.GetAttribute(e, "dynam.dist");
    }

    public static bool HasDynamDist(this IAttDistances e)
    {
      return MeiAtt_controller.HasAttribute(e, "dynam.dist");
    }

    public static void RemoveDynamDist(this IAttDistances e)
    {
      MeiAtt_controller.RemoveAttribute(e, "dynam.dist");
    }
    #endregion

    #region harm.dist
    
    public static void SetHarmDist(this IAttDistances e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "harm.dist", _val);
    }

    public static XAttribute GetHarmDist(this IAttDistances e)
    {
      return MeiAtt_controller.GetAttribute(e, "harm.dist");
    }

    public static bool HasHarmDist(this IAttDistances e)
    {
      return MeiAtt_controller.HasAttribute(e, "harm.dist");
    }

    public static void RemoveHarmDist(this IAttDistances e)
    {
      MeiAtt_controller.RemoveAttribute(e, "harm.dist");
    }
    #endregion

    #region text.dist
    
    public static void SetTextDist(this IAttDistances e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "text.dist", _val);
    }

    public static XAttribute GetTextDist(this IAttDistances e)
    {
      return MeiAtt_controller.GetAttribute(e, "text.dist");
    }

    public static bool HasTextDist(this IAttDistances e)
    {
      return MeiAtt_controller.HasAttribute(e, "text.dist");
    }

    public static void RemoveTextDist(this IAttDistances e)
    {
      MeiAtt_controller.RemoveAttribute(e, "text.dist");
    }
    #endregion

  }

}