# -- coding: utf-8 --
import sys
import os
import re
import textwrap
import logging
lg = logging.getLogger('schemaparser')

LANG_NAME = "C#"

NS_PREFIX_MAP = {
    "http://www.w3.org/XML/1998/namespace": "xml",
    "http://www.w3.org/1999/xlink": "xlink",
    "http://www.isocat.org/ns/dcr": "datcat"
}

AUTHORS = "Anna Plaksin"

ATT_FILE ="""using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

{license}

namespace mei.atts
{{
    {interfaces}

    {ext_classes}
}}"""

ATT_METHODS = """#region {attNameLower}
    public static void Set{attNameUpper}(this IAtt{attGroupNameUpper} e, string _val)
    {{
      MeiAtt_controller.SetAttribute(e, "{attNameLower}", _val);
    }}

    public static XAttribute Get{attNameUpper}(this IAtt{attGroupNameUpper} e)
    {{
      return MeiAtt_controller.GetAttribute(e, "{attNameLower}");
    }}

    public static bool Has{attNameUpper}(this IAtt{attGroupNameUpper} e)
    {{
      return MeiAtt_controller.HasAttribute(e, "{attNameLower}");
    }}

    public static void Remove{attNameUpper}(this IAtt{attGroupNameUpper} e)
    {{
      MeiAtt_controller.RemoveAttribute(e, "{attNameLower}");
    }}
    #endregion
    """

ATT_METHODS_NS = """#region {attNameLower}
    private static readonly XNamespace ns_{attNameLower} = "{newnamespace}";

    public static void Set{attNameUpper}(this IAtt{attGroupNameUpper} e, string _val)
    {{
      MeiAtt_controller.SetAttribute(e, "{attNameLower}", ns_{attNameLower}, _val);
    }}

    public static XAttribute Get{attNameUpper}(this IAtt{attGroupNameUpper} e)
    {{
      return MeiAtt_controller.GetAttribute(e, "{attNameLower}", ns_{attNameLower});
    }}

    public static bool Has{attNameUpper}(this IAtt{attGroupNameUpper} e)
    {{
      return MeiAtt_controller.HasAttribute(e, "{attNameLower}", ns_{attNameLower});
    }}

    public static void Remove{attNameUpper}(this IAtt{attGroupNameUpper} e)
    {{
      MeiAtt_controller.RemoveAttribute(e, "{attNameLower}", ns_{attNameLower});
    }}
    #endregion
    """

ATTGROUP_EXTENSION_CLASS = """\n  /// <summary>
  /// Extension methods for {attGroupName}
  /// </summary>
  static class Att{attGroupNameUpper}_extensions
  {{
    {methods}
  }}
"""

ATTGROUP_INTERFACE = """\n  /// <summary>
  /// Interface for {attGroupName}
  /// </summary>
  interface IAtt{attGroupNameUpper} : IMEiAtt{members}
  {{

  }}
"""

ELEMENT_FILE = """using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using mei.atts;

{license}

namespace mei
{{
    /// <summary>
    /// <{elementName}/>
    /// </summary>
    public class {elementNameUpper} : MeiElement{attClassInterfaces}
    {{
        {constructors}

        //attribute methods
    }}
}}
"""
NS_DECLARATION ="""private static readonly XNamespace ns_{elementName} = "{ns}"
"""

ELEMENT_CONSTRUCTORS ="""{ns_decl}

public {elementNameUpper}() : base({elementConst}) {{ }}
"""

LICENSE = """/////////////////////////////////////////////////////////////////////////////
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
/////////////////////////////////////////////////////////////////////////////"""

# globals
TEI_NS = {"tei": "http://www.tei-c.org/ns/1.0", "rng": "http://relaxng.org/ns/structure/1.0"}

def windll_getAttClassMembers(schema, group):
    #returns a list of members of an attribute class
    memberList = schema.xpath("//tei:classSpec[@type=$att][@ident=$nm]/tei:classes/tei:memberOf/@key", att="atts", nm=group, namespaces=TEI_NS)

    if "att.id" in memberList:
        memberList.remove("att.id")

    return (memberList)

def windll_getElementNS(schema, element):
    #returns non-mei namespaces
    ns = schema.xpath("//tei:elementSpec[@ident=$el]/@ns", el = element, namespaces=TEI_NS)

    if "http://www.music-encoding.org/ns/mei" in ns:
        ns.remove("http://www.music-encoding.org/ns/mei")

    return (ns)


def create(schema, outdir):
    lg.debug("Begin C# Output ... ")
    __create_att_classes(schema, outdir)
    __create_element_classes(schema, outdir)

    lg.debug("Success!")


def __get_docstr(text, indent=0):
    """ Format a docstring. Take the first sentence (. followed by a space)
        and use it for the brief. Then put the rest of the text after a blank
        line if there is text there
    """
    # string handling is handled differently in Python 3+
    if sys.version_info >= (3, 0):
        text = text.strip()
    else:
        text = text.strip().encode("utf-8")

    dotpos = text.find(". ")
    if dotpos > 0:
        brief = text[:dotpos+1]
        content = text[dotpos+2:]
    else:
        brief = text
        content = ""
    if indent == 0:
        istr = ""
    else:
        istr = "{0:{1}}".format(" ", indent)

    brief = "\n{0} *  ".format(istr).join(textwrap.wrap(brief, 80))
    content = "\n{0} *  ".format(istr).join(textwrap.wrap(content, 80))
    docstr = "{0}/** \\brief {1}".format(istr, brief)
    if len(content) > 0:
        docstr += "\n{0} * \n{0} *  {1}".format(istr, content)
    docstr += "\n{0} */".format(istr)
    return docstr


def __create_att_classes(schema, outdir):
    lg.debug("Creating Attribute Classes")

    outdir_att = os.path.join(outdir, "atts")
    os.mkdir(outdir_att)
    
    for module, atgroup in sorted(schema.attribute_group_structure.items()):
        fullout = ""

        if not atgroup:
            # continue if we don't have any attribute groups in this module
            continue

        for gp, atts in sorted(atgroup.items()):
            
            extension_classes = ""
            interfaces = ""

            if not atts:
                continue

            methods = ""
            prefix = ""
            namespace = ""

            gp_members = windll_getAttClassMembers(schema.schema, gp)

            for att in atts:
                if len(att.split("|")) > 1:
                    # we have a namespaced attribute
                    ns,att = att.split("|")
                    
                    #nssubstr = {
                    #    "prefix": NS_PREFIX_MAP[ns],
                    #    "href": ns
                    #}
                    #nsDef = NAMESPACE_TEMPLATE.format(**nssubstr)
                    attrNs = "s, "
                    if ns in NS_PREFIX_MAP:
                        prefix = NS_PREFIX_MAP[ns]
                    else:
                        # handling of unkown namespaces
                        namespace = ns
                else:
                    nsDef = ""
                    attrNs = ""
                docstr = __get_docstr(schema.getattdocs(att), indent=4)
                substrings = {
                    "attNameUpper" : schema.cc(schema.strpatt(att)),
                    "attNameLower" : "{0}:{1}".format(prefix, att) if prefix != "" else "{0}".format(att),
                    "attGroupNameUpper": schema.cc(schema.strpatt(gp)),
                    }
                substrings_ns = {
                    "attNameUpper" : schema.cc(schema.strpatt(att)),
                    "attNameLower" : "{0}:{1}".format(prefix, att) if prefix != "" else "{0}".format(att),
                    "attGroupNameUpper": schema.cc(schema.strpatt(gp)),
                    "newnamespace" : namespace
                    }
                if len(methods) > 0:
                    methods += "//\n"

                # if attribute has an unkown namespace, write methods with explicit namespace
                if namespace != "":
                    methods += ATT_METHODS_NS.format(**substrings_ns)
                else:
                    methods += ATT_METHODS.format(**substrings)

            clsubstrings = {
                "methods" : methods,
                "attGroupNameUpper" : schema.cc(schema.strpatt(gp)),
                "attGroupName" : gp,
                }
            #add List of members
            members = ""
            for member in gp_members:
                members += ", I{0}".format(schema.cc(member))

            intstrings = {
                "attGroupNameUpper" : schema.cc(schema.strpatt(gp)),
                "attGroupName" : gp,
                "members" : members
                }

            extension_classes += ATTGROUP_EXTENSION_CLASS.format(**clsubstrings)
            interfaces += ATTGROUP_INTERFACE.format(**intstrings)

            tplvars = {
                "license": LICENSE.format(authors=AUTHORS),
                "ext_classes" : extension_classes,
                "interfaces" : interfaces
                }

            fullout = ATT_FILE.format(**tplvars)
            
            fmh = open(os.path.join(outdir_att, "att_{0}.cs".format(schema.cc(schema.strpatt(gp)).lower())), 'w')
            fmh.write(fullout)
            fmh.close()
            lg.debug("\tCreated att_{0}.cs".format(schema.cc(schema.strpatt(gp)).lower()))

def __create_element_classes(schema, outdir):
    lg.debug("Creating Element Classes")

    outdir_el = os.path.join(outdir, "elements")
    os.mkdir(outdir_el)

    for module, elements in sorted(schema.element_structure.items()):
        
        if not elements:
            continue

        for element, atgroups in sorted(elements.items()):
            fullout = ""
            at_interfaces = ""
            ns_nonmei = ""
            class_constuctors = ""

            # Look for attribute classes and attributes within elementSpec
            for attribute in atgroups:
                if isinstance(attribute, list):
                    continue

                else:
                    at_interfaces += ", I{0}".format(schema.cc(attribute))

            # Build constructors
            # First, look for non-mei namespaces
            ns_nonmei = windll_getElementNS(schema.schema, element)
            ns_readonly = ""
            if len(ns_nonmei) > 0:
                ns_strings = {
                    "elementName" : element,
                    "ns" : ns_nonmei[len(ns_nonmei)-1]
                    }
                ns_readonly += NS_DECLARATION.format(**ns_strings)

            element_const = "\"{0}\"".format(element) if ns_readonly == "" else "ns_{0}, \"{0}\"".format(element)

            const_strings = {
                "ns_decl" : ns_readonly if ns_readonly != "" else "//bla",
                "elementConst" : element_const,
                "elementNameUpper" : schema.cc(element)
                }

            class_constuctors += ELEMENT_CONSTRUCTORS.format(**const_strings)

            el_docstrings = {
                "elementName" : element,
                "elementNameUpper" : schema.cc(element),
                "attClassInterfaces" : at_interfaces,
                "constructors" : class_constuctors,
                "license": LICENSE.format(authors=AUTHORS),
                }

            fullout += ELEMENT_FILE.format(**el_docstrings)
            
            fmi = open(os.path.join(outdir_el, "{0}.cs".format(schema.cc(element))), 'w')
            fmi.write(fullout)
            fmi.close()
            lg.debug("\tCreated {0}.cs".format(schema.cc(element)))



