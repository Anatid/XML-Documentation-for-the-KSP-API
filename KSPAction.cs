#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// Apply this attribute to a function to allow it to be called via action groups.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class KSPAction : Attribute
{
    /// <summary>
    /// Which action groups this action is currently a part of? Probably you can test
    /// whether this action is part of a given action group (say, the Abort group) with
    /// 
    /// <para><code>if((actionGroup & KSPActionGroup.Abort) != 0)</code></para>
    /// </summary>
    public KSPActionGroup actionGroup;
    /// <summary>
    /// The name of this action as it appears in the action group editor.
    /// </summary>
    public string guiName;

    public extern KSPAction(string guiName);
    public extern KSPAction(string guiName, KSPActionGroup actionGroup);
}
