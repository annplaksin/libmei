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

    public string ID { get; set; }

    public MeiElement(string _name) : base(meins + _name)
    {
      this.GenerateAndSetID();
    }

    public void GenerateAndSetID()
    {
      if(ID == null)
      {
        ID = string.Concat("m-", Guid.NewGuid().ToString().ToLower());
      }
    }

    public string GetName()
    {
      return this.Name.LocalName;
    }

    public string GetValue()
    {
      return this.Value;
    }

    //SetValue(_bla) is already available as XElement.SetValue (object value)
  }
}
