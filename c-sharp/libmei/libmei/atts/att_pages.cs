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
  /// Interface for att.pages
  /// </summary>
  public interface IAttPages : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.pages
  /// </summary>
  public static class AttPages_extensions
  {
    #region page.height
    
    public static void SetPageHeight(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.height", _val);
    }

    public static XAttribute GetPageHeight(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.height");
    }

    public static bool HasPageHeight(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.height");
    }

    public static void RemovePageHeight(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.height");
    }
    #endregion

    #region page.width
    
    public static void SetPageWidth(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.width", _val);
    }

    public static XAttribute GetPageWidth(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.width");
    }

    public static bool HasPageWidth(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.width");
    }

    public static void RemovePageWidth(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.width");
    }
    #endregion

    #region page.topmar
    
    public static void SetPageTopmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.topmar", _val);
    }

    public static XAttribute GetPageTopmar(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.topmar");
    }

    public static bool HasPageTopmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.topmar");
    }

    public static void RemovePageTopmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.topmar");
    }
    #endregion

    #region page.botmar
    
    public static void SetPageBotmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.botmar", _val);
    }

    public static XAttribute GetPageBotmar(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.botmar");
    }

    public static bool HasPageBotmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.botmar");
    }

    public static void RemovePageBotmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.botmar");
    }
    #endregion

    #region page.leftmar
    
    public static void SetPageLeftmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.leftmar", _val);
    }

    public static XAttribute GetPageLeftmar(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.leftmar");
    }

    public static bool HasPageLeftmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.leftmar");
    }

    public static void RemovePageLeftmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.leftmar");
    }
    #endregion

    #region page.rightmar
    
    public static void SetPageRightmar(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.rightmar", _val);
    }

    public static XAttribute GetPageRightmar(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.rightmar");
    }

    public static bool HasPageRightmar(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.rightmar");
    }

    public static void RemovePageRightmar(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.rightmar");
    }
    #endregion

    #region page.panels
    
    public static void SetPagePanels(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.panels", _val);
    }

    public static XAttribute GetPagePanels(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.panels");
    }

    public static bool HasPagePanels(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.panels");
    }

    public static void RemovePagePanels(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.panels");
    }
    #endregion

    #region page.scale
    
    public static void SetPageScale(this IAttPages e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "page.scale", _val);
    }

    public static XAttribute GetPageScale(this IAttPages e)
    {
      return MeiAtt_controller.GetAttribute(e, "page.scale");
    }

    public static bool HasPageScale(this IAttPages e)
    {
      return MeiAtt_controller.HasAttribute(e, "page.scale");
    }

    public static void RemovePageScale(this IAttPages e)
    {
      MeiAtt_controller.RemoveAttribute(e, "page.scale");
    }
    #endregion

  }

}