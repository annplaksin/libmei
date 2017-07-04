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
  public class MeiElementTests
  {
    [TestMethod()]
    public void BasicConstructorTest()
    {
      Note test = new Note();

      Assert.IsNotNull(test);
    }

    [TestMethod()]
    public void ConstructorContentTest()
    {
      Note test = new Note("content");

      Assert.AreEqual("content",test.Value.ToString());
    }

    [TestMethod()]
    public void ConstructorContentArrayTest()
    {
      Note test = new Note(new XAttribute("label", "att"), "content");

      Assert.IsNotNull(test);
    }

    [TestMethod()]
    public void HasAttributeTest()
    {
      Note test = new Note(new XAttribute("label", "att"));

      Assert.IsTrue(test.HasLabel());
    }

    [TestMethod()]
    public void SetNTest()
    {
      Note test = new Note();
      test.SetN("1");

      Assert.AreEqual("1", test.Attribute("n").Value);
    }

    [TestMethod()]
    public void SetLabelTest()
    {
      Note test = new Note();
      test.SetLabel("hallo");

      Assert.AreEqual("hallo", test.Attribute("label").Value);
    }

    [TestMethod()]
    public void GetLabelTest()
    {
      Note test = new Note();
      test.SetLabel("test");

      XAttribute check = test.GetLabel();

      Assert.IsNotNull(check);
    }

    [TestMethod]
    public void GetTypeTest()
    {
      Section testAttClass = new Section();
      Div testDirectAtt = new Div();

      testAttClass.SetTypeAttribute("test");
      testDirectAtt.SetTypeAttribute("test");

      Assert.IsInstanceOfType(testDirectAtt.GetTypeAttribute(), typeof(XAttribute));
      Assert.IsInstanceOfType(testAttClass.GetTypeAttribute(), typeof(XAttribute));
    }
  }
}