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
  /// Interface for att.pointing
  /// </summary>
  public interface IAttPointing : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pointing
  /// </summary>
  public static class AttPointing_extensions
  {
    #region xlink:actuate
    
    public static void SetActuate(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xlink:actuate", _val);
    }

    public static XAttribute GetActuate(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "xlink:actuate");
    }

    public static bool HasActuate(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "xlink:actuate");
    }

    public static void RemoveActuate(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xlink:actuate");
    }
    #endregion

    #region xlink:role
    
    public static void SetRole(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xlink:role", _val);
    }

    public static XAttribute GetRole(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "xlink:role");
    }

    public static bool HasRole(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "xlink:role");
    }

    public static void RemoveRole(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xlink:role");
    }
    #endregion

    #region xlink:show
    
    public static void SetShow(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "xlink:show", _val);
    }

    public static XAttribute GetShow(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "xlink:show");
    }

    public static bool HasShow(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "xlink:show");
    }

    public static void RemoveShow(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "xlink:show");
    }
    #endregion

    #region target
    
    public static void SetTarget(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "target", _val);
    }

    public static XAttribute GetTarget(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "target");
    }

    public static bool HasTarget(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "target");
    }

    public static void RemoveTarget(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "target");
    }
    #endregion

    #region targettype
    
    public static void SetTargettype(this IAttPointing e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "targettype", _val);
    }

    public static XAttribute GetTargettype(this IAttPointing e)
    {
      return MeiAtt_controller.GetAttribute(e, "targettype");
    }

    public static bool HasTargettype(this IAttPointing e)
    {
      return MeiAtt_controller.HasAttribute(e, "targettype");
    }

    public static void RemoveTargettype(this IAttPointing e)
    {
      MeiAtt_controller.RemoveAttribute(e, "targettype");
    }
    #endregion

  }

}