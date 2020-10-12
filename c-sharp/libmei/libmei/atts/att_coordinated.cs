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
  /// Interface for att.coordinated
  /// </summary>
  public interface IAttCoordinated : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.coordinated
  /// </summary>
  public static class AttCoordinated_extensions
  {
    #region ulx
    
    public static void SetUlx(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "ulx", _val);
    }

    public static XAttribute GetUlx(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "ulx");
    }

    public static bool HasUlx(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "ulx");
    }

    public static void RemoveUlx(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "ulx");
    }
    #endregion

    #region uly
    
    public static void SetUly(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "uly", _val);
    }

    public static XAttribute GetUly(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "uly");
    }

    public static bool HasUly(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "uly");
    }

    public static void RemoveUly(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "uly");
    }
    #endregion

    #region lrx
    
    public static void SetLrx(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lrx", _val);
    }

    public static XAttribute GetLrx(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "lrx");
    }

    public static bool HasLrx(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "lrx");
    }

    public static void RemoveLrx(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lrx");
    }
    #endregion

    #region lry
    
    public static void SetLry(this IAttCoordinated e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "lry", _val);
    }

    public static XAttribute GetLry(this IAttCoordinated e)
    {
      return MeiAtt_controller.GetAttribute(e, "lry");
    }

    public static bool HasLry(this IAttCoordinated e)
    {
      return MeiAtt_controller.HasAttribute(e, "lry");
    }

    public static void RemoveLry(this IAttCoordinated e)
    {
      MeiAtt_controller.RemoveAttribute(e, "lry");
    }
    #endregion

  }

}