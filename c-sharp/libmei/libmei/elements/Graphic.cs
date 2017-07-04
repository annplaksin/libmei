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
    /// <graphic/>
    /// </summary>
    public class Graphic : MeiElement, IAttCommon, IAttCommonPart, IAttDeclaring, IAttHeight, IAttWidth, IAttInternetmedia, IAttFacsimile, IAttPointing, IAttMeasurement, IAttStartid, IAttTyped, IAttVisualoffsetHo, IAttVisualoffsetTo, IAttVisualoffsetVo
    {
        
        public Graphic() : base("graphic") { }

        public Graphic(object _content) : base("graphic", _content) { }

        public Graphic(params object[] _content) : base("graphic", _content) { }


        #region ulx
    
    public void SetUlx(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "ulx", _val);
    }

    public XAttribute GetUlx()
    {
      return MeiAtt_controller.GetAttribute(this, "ulx");
    }

    public bool HasUlx()
    {
      return MeiAtt_controller.HasAttribute(this, "ulx");
    }

    public void RemoveUlx()
    {
      MeiAtt_controller.RemoveAttribute(this, "ulx");
    }
    #endregion

        #region uly
    
    public void SetUly(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "uly", _val);
    }

    public XAttribute GetUly()
    {
      return MeiAtt_controller.GetAttribute(this, "uly");
    }

    public bool HasUly()
    {
      return MeiAtt_controller.HasAttribute(this, "uly");
    }

    public void RemoveUly()
    {
      MeiAtt_controller.RemoveAttribute(this, "uly");
    }
    #endregion

    }
}
