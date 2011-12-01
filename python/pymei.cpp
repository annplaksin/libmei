#include "Python.h"
#include <mei/meinamespace.h>
#include <mei/meielement.h>
#include <mei/meiattribute.h>
#include <mei/meidocument.h>
#include <mei/xmlimport.h>

#include <boost/python.hpp>
#include <boost/python/tuple.hpp>
#include <boost/python/suite/indexing/vector_indexing_suite.hpp>
#include <iostream>
#include <vector>
#include <string>

using namespace boost::python;
using namespace std;

using mei::MeiNamespace;
using mei::MeiElement;
using mei::MeiAttribute;
using mei::MeiDocument;

typedef vector<MeiElement*> MeiElementList;
typedef vector<MeiAttribute*> MeiAttributeList;
// typedef vector<MeiElement*>& MeiElementListRef;



BOOST_PYTHON_MODULE(pymei) {
    class_<MeiElementList>("MeiElementList")
        .def(vector_indexing_suite<MeiElementList>())
    ;

    class_<MeiAttributeList>("MeiAttributeList")
        .def(vector_indexing_suite<MeiAttributeList>())
    ;

    // class_<MeiElementListRef>("MeiElementListRef")
    //     .def(vector_indexing_suite<MeiElementListRef>())
    // ;

    class_<MeiNamespace>("MeiNamespace", init<string, string>())
        .def("getHref", &MeiNamespace::getHref)
        .def("getPrefix", &MeiNamespace::getPrefix)
    ;

    void (MeiElement::*addAttributeByObject)(MeiAttribute*) = &MeiElement::addAttribute;
    void (MeiElement::*addAttributeByString)(string, string) = &MeiElement::addAttribute;
    void (MeiElement::*setDocument)(MeiDocument*) = &MeiElement::setDocument;
    bool (MeiElement::*hasChildrenBool)() = &MeiElement::hasChildren;
    bool (MeiElement::*hasChildrenArgs)(string) = &MeiElement::hasChildren;
    void (MeiElement::*printAll)() = &MeiElement::print;
    void (MeiElement::*printLvl)(int) = &MeiElement::print;
    MeiElement* (MeiDocument::*getElementById)(string) = &MeiDocument::getElementById;

    class_<MeiDocument>("MeiDocument", init<>())
        .def("hasNamespace", &MeiDocument::hasNamespace)
        .def("getNamespace", &MeiDocument::getNamespace, return_value_policy<reference_existing_object>())
        .def("getNamespaces", &MeiDocument::getNamespaces)
        .def("addNamespace", &MeiDocument::addNamespace)
        .def("getVersion", &MeiDocument::getVersion)
        .def("getRootElement", &MeiDocument::getRootElement, return_value_policy<reference_existing_object>())
        .def("setRootElement", &MeiDocument::setRootElement)
        /* 
            MeiDocument has both a private and public function named getElementById. We expose
            the public one above and use it here.
        */
        .def("getElementById", getElementById, return_value_policy<reference_existing_object>())
        .def("getElementsByName", &MeiDocument::getElementsByName)
        .def("getPositionInDocument", &MeiDocument::getPositionInDocument)
        .def("addIdMap", &MeiDocument::addIdMap)
        .def("rmIdMap", &MeiDocument::rmIdMap)
        .def("getFlattenedTree", &MeiDocument::getFlattenedTree, return_value_policy<copy_const_reference>())
        .def("lookBack", &MeiDocument::lookBack, return_value_policy<reference_existing_object>())
;

    class_<MeiElement>("MeiElement", init<string>())
        .def("getId", &MeiElement::getId)
        .def("hasId", &MeiElement::hasId)
        .def("getName", &MeiElement::getName)
        .def("getTail", &MeiElement::getTail)
        .def("setTail", &MeiElement::setTail)
        .def("getValue", &MeiElement::getValue)
        .def("setValue", &MeiElement::setValue)
        .def("getAttributes", &MeiElement::getAttributes, return_value_policy<reference_existing_object>()) 
        .def("addAttribute", addAttributeByObject)
        .def("addAttribute", addAttributeByString)
        .def("getAttribute", &MeiElement::getAttribute, return_value_policy<reference_existing_object>())
        .def("removeAttribute", &MeiElement::removeAttribute)
        .def("hasAttribute", &MeiElement::hasAttribute)
        .def("hasParent", &MeiElement::hasParent)
        .def("getParent", &MeiElement::getParent, return_value_policy<reference_existing_object>())
        
        /* boost doesn't seem to like the forward declaration of MeiDocument in MeiElement.
            This construction for setDocument avoids this by explicitly masking it above
        */
        .def("setDocument", setDocument)
        .def("getDocument", &MeiElement::getDocument, return_value_policy<reference_existing_object>())
        .def("addChild", &MeiElement::addChild)
        .def("setChildren", &MeiElement::setChildren)
        .def("getChildren", &MeiElement::getChildren, return_value_policy<copy_const_reference>())
        .def("getChildrenByName", &MeiElement::getChildrenByName)
        .def("deleteAllChildren", &MeiElement::deleteAllChildren)
        .def("removeChildrenWithName", &MeiElement::removeChildrenWithName)
        .def("removeChild", &MeiElement::removeChild)
        .def("hasChildren", hasChildrenBool)
        .def("hasChildren", hasChildrenArgs)
        .def("getAncestor", &MeiElement::getAncestor, return_value_policy<reference_existing_object>())
        .def("hasAncestor", &MeiElement::hasAncestor)
        .def("getDescendants", &MeiElement::getDescendants)
        .def("getDescendantsByName", &MeiElement::getDescendantsByName)
        .def("getPeers", &MeiElement::getPeers)
        .def("getPositionInDocument", &MeiElement::getPositionInDocument)
        .def("lookBack", &MeiElement::lookBack, return_value_policy<reference_existing_object>())
        .def("flatten", &MeiElement::flatten)
        .def("print", printAll)
        .def("print", printLvl)
        .def("updateDocument", &MeiElement::updateDocument)
    ;

    class_<MeiAttribute>("MeiAttribute", init<string, string>())
        .def("getName", &MeiAttribute::getName)
        .def("setName", &MeiAttribute::setName)
        .def("getValue", &MeiAttribute::getValue)
        .def("setValue", &MeiAttribute::setValue)
        .def("hasNamespace", &MeiAttribute::hasNamespace)
        .def("getNamespace", &MeiAttribute::getNamespace, return_value_policy<reference_existing_object>())
        .def("setNamespace", &MeiAttribute::setNamespace)
    ;

}