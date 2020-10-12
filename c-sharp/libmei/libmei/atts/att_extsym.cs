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
  /// Interface for att.extsym
  /// </summary>
  public interface IAttExtsym : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.extsym
  /// </summary>
  public static class AttExtsym_extensions
  {
    #region glyphname
    
    public static void SetGlyphname(this IAttExtsym e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "glyphname", _val);
    }

    public static XAttribute GetGlyphname(this IAttExtsym e)
    {
      return MeiAtt_controller.GetAttribute(e, "glyphname");
    }

    public static bool HasGlyphname(this IAttExtsym e)
    {
      return MeiAtt_controller.HasAttribute(e, "glyphname");
    }

    public static void RemoveGlyphname(this IAttExtsym e)
    {
      MeiAtt_controller.RemoveAttribute(e, "glyphname");
    }
    #endregion

    #region glyphnum
    
    public static void SetGlyphnum(this IAttExtsym e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "glyphnum", _val);
    }

    public static XAttribute GetGlyphnum(this IAttExtsym e)
    {
      return MeiAtt_controller.GetAttribute(e, "glyphnum");
    }

    public static bool HasGlyphnum(this IAttExtsym e)
    {
      return MeiAtt_controller.HasAttribute(e, "glyphnum");
    }

    public static void RemoveGlyphnum(this IAttExtsym e)
    {
      MeiAtt_controller.RemoveAttribute(e, "glyphnum");
    }
    #endregion

  }

}