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
    /// <relatedItem/>
    /// </summary>
    public class RelatedItem : MeiElement, IAttDatapointing, IAttCommon, IAttCommonPart, IAttBibl, IAttFacsimile, IAttPointing, IAttTargeteval, IAttTyped
    {
        
        public RelatedItem() : base("relatedItem") { }

        public RelatedItem(object _content) : base("relatedItem", _content) { }

        public RelatedItem(params object[] _content) : base("relatedItem", _content) { }


        #region rel
    
    public void SetRel(string _val)
    {
      MeiAtt_controller.SetAttribute(this, "rel", _val);
    }

    public XAttribute GetRel()
    {
      return MeiAtt_controller.GetAttribute(this, "rel");
    }

    public bool HasRel()
    {
      return MeiAtt_controller.HasAttribute(this, "rel");
    }

    public void RemoveRel()
    {
      MeiAtt_controller.RemoveAttribute(this, "rel");
    }
    #endregion

    }
}
