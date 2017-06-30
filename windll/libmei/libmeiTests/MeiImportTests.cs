using Microsoft.VisualStudio.TestTools.UnitTesting;
using mei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei.Tests
{
  [TestClass()]
  public class MeiImportTests
  {
    [TestMethod()]
    public void ImportDocumentTest()
    {
      Assert.Fail();
    }

    [TestMethod()]
    public void XmlToMeiTest()
    {
      XElement testelement = new XElement("blubb", new XElement("note","bla"));

      MeiElement compare = new Blubb();

      MeiElement test = MeiImport.XmlToMei(testelement);
      
      Assert.IsInstanceOfType(test, compare.GetType());
    }

    [TestMethod()]
    public void TestIDHandling()
    {
      XElement testelement = new XElement("blubb", new XElement("note", "bla", new XAttribute("label","test")), new XAttribute(XNamespace.Xml + "id", "t-123"));

      MeiElement test = MeiImport.XmlToMei(testelement);

      Assert.AreEqual(test.GetId().Value, "t-123");
      Assert.IsNotNull(test.Element<Note>().GetId());
    }
  }
}