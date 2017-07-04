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
  /// Interface for att.tabular
  /// </summary>
  public interface IAttTabular : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.tabular
  /// </summary>
  public static class AttTabular_extensions
  {
    #region colspan
    
    public static void SetColspan(this IAttTabular e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "colspan", _val);
    }

    public static XAttribute GetColspan(this IAttTabular e)
    {
      return MeiAtt_controller.GetAttribute(e, "colspan");
    }

    public static bool HasColspan(this IAttTabular e)
    {
      return MeiAtt_controller.HasAttribute(e, "colspan");
    }

    public static void RemoveColspan(this IAttTabular e)
    {
      MeiAtt_controller.RemoveAttribute(e, "colspan");
    }
    #endregion

    #region rowspan
    
    public static void SetRowspan(this IAttTabular e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "rowspan", _val);
    }

    public static XAttribute GetRowspan(this IAttTabular e)
    {
      return MeiAtt_controller.GetAttribute(e, "rowspan");
    }

    public static bool HasRowspan(this IAttTabular e)
    {
      return MeiAtt_controller.HasAttribute(e, "rowspan");
    }

    public static void RemoveRowspan(this IAttTabular e)
    {
      MeiAtt_controller.RemoveAttribute(e, "rowspan");
    }
    #endregion

  }

}