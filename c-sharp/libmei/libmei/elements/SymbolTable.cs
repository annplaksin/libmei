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
    /// <symbolTable/>
    /// </summary>
    public class SymbolTable : MeiElement, IAttCommon, IAttCommonPart
    {
        
        public SymbolTable() : base("symbolTable") { }

        public SymbolTable(object _content) : base("symbolTable", _content) { }

        public SymbolTable(params object[] _content) : base("symbolTable", _content) { }


        
    }
}
