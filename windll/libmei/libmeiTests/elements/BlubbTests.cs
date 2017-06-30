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
  public class BlubbTests
  {
    [TestMethod()]
    public void BlubbTest()
    {
      Blubb test = new Blubb();

      Assert.IsNotNull(test);
    }

    [TestMethod()]
    public void BlubbTest1()
    {
      Blubb test = new Blubb("content");

      Assert.AreEqual("content",test.Value.ToString());
    }

    [TestMethod()]
    public void BlubbTest2()
    {
      Blubb test = new Blubb(new XAttribute("bla", "att"), "content");

      Assert.IsNotNull(test);
    }

    [TestMethod()]
    public void HasBlaTest()
    {
      Blubb test = new Blubb(new XAttribute("bla", "att"));

      Assert.IsTrue(test.HasBla());
    }

    [TestMethod()]
    public void SetNTest()
    {
      Blubb test = new Blubb();
      test.SetN("1");

      Assert.IsNotNull(test.Attribute("n"));
    }

    [TestMethod()]
    public void SetLabelTest()
    {
      Blubb test = new Blubb();
      test.SetLabel("hallo");

      Assert.IsNotNull(test.Attribute("label"));
    }
  }
}