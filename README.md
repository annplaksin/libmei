LibMEI
------

LibMEI is a C++ library for reading and writing [MEI](http://music-encoding.org) files

It is developed by the [Distributed Digital Music Archives and Libraries Lab](http://ddmal.music.mcgill.ca/)
at the Schulich School of Music at McGill University, Montréal, Canada

This version provides a C# library to use with the .NET framework (at least 4.5.2). It puts the libMEI functionality on top of the [Linq to Xml](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/linq-to-xml) interface.


License
-------
LibMEI is released under the MIT license.

Compilation & Usage
-------------------

A Visual Studio project is provided for compilation in the 'c-sharp' directory.
The dll could be included by adding the Reference and: 
```
using mei;
```

Basic usage of libMEI.NET is possible without including Linq to Xml, but for advanced usage it could be necessary, e.g. functional construction of attributes.
To include Linq to Xml add:
```
using System.Xml.Linq;
```

Elements could be created like:
```
Note note1 = new Note();
PersName name2 = new PersName("name");
```

Attributes could be used by methods, e.g.:
```
note1.SetLabel("example");
note1.HasLabel();
note1.GetLabel();
note1.GetLabel().Value;
note1.RemoveLabel();
```

To prevent a confusion with object.GetType(), the methods for @type needs to be named as GetTypeAttribute(), HasTypeAttribute(), SetTypeAttribute(), and RemoveTypeAttribute().

Customization
-------------

The code for mei-all 3.0.0 is included in the project. 
To customize libMEI.NET use the Python script 'parseschema2.py' in the 'tools' directory with 'csharp' as language option on a compiled ODD file, e.g.:
```
python tools/parseschema2.py mei-all.xml -l csharp
```
I've tested the script with Python 2.7.
Also, within the 'c-sharp' directory a 'tools.sln' is provided to use the Python script with Visual Studio.

After running the script, replace the 'atts' and 'elements' folders in 'c-sharp\libmei\libmei' with the folders in the output. It could be necessary to remove the content of the folders within the project and add them again.