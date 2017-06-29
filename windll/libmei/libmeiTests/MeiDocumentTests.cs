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
  public class MeiDocumentTests
  {
    [TestMethod()]
    public void SetSchemaLocationTest()
    {
      string schemaLoc = "bla";
      MeiDocument testDoc = new MeiDocument(new Blubb(new XAttribute("bla","foo")));

      testDoc.SetSchemaLocation(schemaLoc);

      Assert.AreEqual(schemaLoc, testDoc.SchemaLocation);
    }

    [TestMethod()]
    public void MeiDocumentTest()
    {
      Blubb blubb = new Blubb();
      MeiDocument testDoc = new MeiDocument(blubb);

      Assert.IsNotNull(testDoc);
    }
  }
}