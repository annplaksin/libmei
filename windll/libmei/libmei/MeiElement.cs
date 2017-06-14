using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mei
{
  public class MeiElement : XElement
  {
    public static readonly XNamespace meins = "http://www.music-encoding.org/ns/mei";

    public MeiElement(string _name) : base(meins + _name)
    {
      this.GenerateAndSetID();
    }

    private void GenerateAndSetID()
    {

    }
  }
}
