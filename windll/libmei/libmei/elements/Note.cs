using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using mei.atts;

namespace mei
{
  /// <summary>
  /// <note/>
  /// </summary>
  public class Note : MeiElement, IAttCommon
  {
    public Note() : base("note") { }

    public Note(object _content) : base("note", _content) { }

    public Note(object[] _content) : base("note", _content) { }
  }

}
