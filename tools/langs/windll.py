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
    #endregion"""

ATT_METHODS_DOC = """
"""

ATTGROUP_EXTENSION_CLASS = """\n    /// <summary>
  /// Extension methods for att.common
  /// </summary>
  static class Att{attGroupNameUpper}_extensions
  {{
    {methods}
  }}
"""

ATTGROUP_INTERFACE = """\n    /// <summary>
  /// Interface for att.common
  /// </summary>
  interface IAtt{attGroupNameUpper} : IMEiAtt
  {{

  }}
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


def create(schema, outdir):
    lg.debug("Begin C# Output ... ")
    __create_att_classes(schema, outdir)
    #__create_element_classes(schema, outdir)

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
    
    for module, atgroup in sorted(schema.attribute_group_structure.items()):
        fullout = ""
        extension_classes = ""
        interfaces = ""

        if not atgroup:
            # continue if we don't have any attribute groups in this module
            continue

        for gp, atts in sorted(atgroup.items()):
            if not atts:
                continue

            methods = ""
            prefix = ""
            for att in atts:
                if len(att.split("|")) > 1:
                    # we have a namespaced attribute
                    ns,att = att.split("|")
                    prefix = NS_PREFIX_MAP[ns]
                    #nssubstr = {
                    #    "prefix": NS_PREFIX_MAP[ns],
                    #    "href": ns
                    #}
                    #nsDef = NAMESPACE_TEMPLATE.format(**nssubstr)
                    attrNs = "s, "
                else:
                    nsDef = ""
                    attrNs = ""
                docstr = __get_docstr(schema.getattdocs(att), indent=4)
                substrings = {
                    "attNameUpper" : schema.cc(schema.strpatt(att)),
                    "attNameLower" : "{0}:{1}".format(prefix, att) if prefix != "" else "{0}".format(att),
                    "attGroupNameUpper": schema.cc(schema.strpatt(gp))
                    }
                if len(methods) > 0:
                    methods += "//\n"
                methods += ATT_METHODS.format(**substrings)

            clsubstrings = {
                "methods" : methods,
                "attGroupNameUpper" : schema.cc(schema.strpatt(gp)),
                }
            intstrings = {
                "attGroupNameUpper" : schema.cc(schema.strpatt(gp)),
                }

            extension_classes += ATTGROUP_EXTENSION_CLASS.format(**clsubstrings)
            interfaces += ATTGROUP_INTERFACE.format(**intstrings)

        tplvars = {
            "license": LICENSE.format(authors=AUTHORS),
            "ext_classes" : extension_classes,
            "interfaces" : interfaces
            }

        fullout = ATT_FILE.format(**tplvars)
        fmh = open(os.path.join(outdir, "atts_{0}.cs".format(module.lower())), 'w')
        fmh.write(fullout)
        fmh.close()
        lg.debug("\tCreated atts_{0}.cs".format(module.lower()))


def parse_includes(file_dir, includes_dir):
    lg.debug("Parsing includes")

    # get the files in the includes directory
    includes = [f for f in os.listdir(includes_dir) if not f.startswith(".")]

    for dp, dn, fn in os.walk(file_dir):
        for f in fn:
            if f.startswith("."):
                continue
            methods, inc = __process_include(f, includes, includes_dir)
            if methods:
                __parse_codefile(methods, inc, dp, f)


def __process_include(fname, includes, includes_dir):
    name, ext = os.path.splitext(fname)
    new_methods, includes_block = None, None
    if "{0}.inc".format(fname) in includes:
        lg.debug("\tProcessing include for {0}".format(fname))
        f = open(os.path.join(includes_dir, "{0}.inc".format(fname)), 'r')
        includefile = f.read()
        f.close()
        new_methods, includes_block = __parse_includefile(includefile)
        return (new_methods, includes_block)
    else:
        return (None, None)


def __parse_includefile(contents):
    # parse the include file for our methods.
    ret = {}
    inc = []
    reg = re.compile(r"/\* <(?P<elementName>[^>]+)> \*/(.+?)/\* </(?P=elementName)> \*/", re.MULTILINE | re.DOTALL)
    ret = dict(re.findall(reg, contents))

    # grab the include for the includes...
    reginc = re.compile(r"/\* #include_block \*/(.+?)/\* #include_block \*/", re.MULTILINE | re.DOTALL)
    inc = re.findall(reginc, contents)
    return (ret, inc)


def __parse_codefile(methods, includes, directory, codefile):
    f = open(os.path.join(directory, codefile), 'r')
    contents = f.readlines()
    f.close()
    regmatch = re.compile(r"/\* include <(?P<elementName>[^>]+)> \*/")
    incmatch = re.compile(r"/\* #include_block \*/")
    for i, line in enumerate(contents):
        imatch = re.match(incmatch, line)
        if imatch:
            if includes:
                contents[i] = includes[0]

        match = re.match(regmatch, line)
        if match:
            if match.group("elementName") in methods.keys():
                contents[i] = methods[match.group("elementName")].lstrip("\n") + "\n"

    f = open(os.path.join(directory, codefile), 'w')
    f.writelines(contents)
    f.close()








