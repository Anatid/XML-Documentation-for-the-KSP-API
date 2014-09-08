You can find me on #kspmodders or the KSP forums as **The_Duck**.

Web documentation
-----------------

This project is used to build the **[web documentation](http://anatid.github.io/XML-Documentation-for-the-KSP-API/index.html)** using Doxygen.

IDE integration
---------------

To get documentation in tooltips and the object browser in Visual Studio or MonoDevelop:

1. Download **[Assembly-CSharp.xml](https://raw.githubusercontent.com/Anatid/XML-Documentation-for-the-KSP-API/master/Assembly-CSharp.xml)** and **[UnityEngine.xml](https://raw.githubusercontent.com/Anatid/XML-Documentation-for-the-KSP-API/master/UnityEngine.xml)**
2. Place Assembly-CSharp.xml and UnityEngine.xml in the same place as the Assembly-CSharp.dll and UnityEngine.dll that you link to when building your KSP plugin (the KSP_Data/Managed folder). 
3. Restart your IDE.

Now when you use the object browser to examine the contents of Assembly-CSharp.dll you will find helpful comments for some classes. These comments will also show up through IntelliSense when writing code.


How to contribute to this documentation
---------------------------------------

This documentation is only as good as the effort that the community puts into it! You can help.

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
