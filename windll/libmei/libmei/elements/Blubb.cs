﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using mei.atts;

namespace mei
{
  /// <summary>
  /// Blubb
  /// </summary>
  public class Blubb : MeiElement, IAttCommon
  {
    private static readonly XNamespace ns_blubb = "http://github.com/annplaksin/bla";

    /// <summary>
    /// Constructor with explicit namespace
    /// </summary>
    public Blubb() : base(ns_blubb, "blubb") { }

    /// <summary>
    /// Attribute method for attributes defined within an elementSpec
    /// </summary>
    private void Test()
    {
      MeiAtt_controller.HasAttribute(this, "bla");
    }
  }

}