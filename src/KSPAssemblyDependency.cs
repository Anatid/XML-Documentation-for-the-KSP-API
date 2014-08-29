using System;

/// <summary>
/// This attribute and the KSPAssembly attribute can be used to ensure that plugin assemblies are loaded in the right order.
/// </summary>
/// <remarks>
/// Suppose Mod A depends on mod B, which is currently at version 2.6. 
/// Mod B should add the following line to the end of Properties/AssemblyInfo.cs:
/// 
/// <code>
/// [assembly: KSPAssembly("ModBName", 2, 6)]
/// </code>
///
/// where "ModBName" is the name of Mod B (Mod B's .dll?). Replace 2 and 6 with the major and minor version of
/// Mod B.
/// 
/// Then Mod A should add the following line to the end of Properties/AssemblyInfo.cs:
/// 
/// <code>
/// [assembly: KSPAssemblyDependency("ModBName", 2, 6)]
/// </code>
/// 
/// This will tell KSP that Mod A depends on version 2.6 of Mod B, and ensure the the assemblies get loaded in
/// the proper order.
/// 
/// </remarks>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class KSPAssemblyDependency : Attribute
{
    public string name;
    public int versionMajor;
    public int versionMinor;

    public extern KSPAssemblyDependency(string name, int versionMajor, int versionMinor);
}
