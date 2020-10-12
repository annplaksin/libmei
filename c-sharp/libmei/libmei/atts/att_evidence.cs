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
  /// Interface for att.evidence
  /// </summary>
  public interface IAttEvidence : IMEiAtt
  {

  }


    /// <summary>
  /// Extension methods for att.evidence
  /// </summary>
  public static class AttEvidence_extensions
  {
    #region cert
    
    public static void SetCert(this IAttEvidence e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "cert", _val);
    }

    public static XAttribute GetCert(this IAttEvidence e)
    {
      return MeiAtt_controller.GetAttribute(e, "cert");
    }

    public static bool HasCert(this IAttEvidence e)
    {
      return MeiAtt_controller.HasAttribute(e, "cert");
    }

    public static void RemoveCert(this IAttEvidence e)
    {
      MeiAtt_controller.RemoveAttribute(e, "cert");
    }
    #endregion

    #region evidence
    
    public static void SetEvidence(this IAttEvidence e, string _val)
    {
      MeiAtt_controller.SetAttribute(e, "evidence", _val);
    }

    public static XAttribute GetEvidence(this IAttEvidence e)
    {
      return MeiAtt_controller.GetAttribute(e, "evidence");
    }

    public static bool HasEvidence(this IAttEvidence e)
    {
      return MeiAtt_controller.HasAttribute(e, "evidence");
    }

    public static void RemoveEvidence(this IAttEvidence e)
    {
      MeiAtt_controller.RemoveAttribute(e, "evidence");
    }
    #endregion

  }

}