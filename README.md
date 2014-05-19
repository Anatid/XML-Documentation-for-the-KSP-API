How to use this documentation
-----------------------------

1. Download [Assembly-CSharp.xml](https://raw.githubusercontent.com/Anatid/XML-Documentation-for-the-KSP-API/master/Assembly-CSharp.xml) and [UnityEngine.xml](https://raw.githubusercontent.com/Anatid/XML-Documentation-for-the-KSP-API/master/UnityEngine.xml)
2. Place Assembly-CSharp.xml and UnityEngine.xml in the same place as the Assembly-CSharp.dll and UnityEngine.dll that you link to when building your KSP plugin (the KSP_Data/Managed folder). 
3. Restart Visual Studio.

Now when you use the Object Browser to examine the contents of Assembly-CSharp.dll you will find helpful comments for some classes. These comments will also show up through IntelliSense when writing code.

Probably you can use Assembly-CSharp.xml in MonoDevelop too but I don't use MonoDevelop so I don't know.

You can also check out [this web version](http://anatid.github.io/XML-Documentation-for-the-KSP-API/annotated.html) of the documentation, generated using Doxygen. Currently only classes that have at least some documentation appear in the web documentation.

How to contribute to this documentation
---------------------------------------

To add new info on a class that already has some documentation: 

1. Fork this project
2. Add your comments in the appropriate .cs file.
3. Send me a pull request.

To add info on a new class: 

1. Highlight the class in the source code of your KSP plugin.
2. Press F12. Visual Studio will create a fake source file for the class. 
3. Copy Visual Studio's uneditable source file into a new file you can edit.
4. Add your comments to the fake source file. 
5. Fork this project.
6. Add your new fake source file to your version of the project. 
7. Send me a pull request.
