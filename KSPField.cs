#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// Apply this attribute to a field in a PartModule or ScenarioModule to make the field 
/// get automatically initialized from the cfg file, and optionally persistent. See
/// 
/// http://forum.kerbalspaceprogram.com/showthread.php/10296-0-15-code-update-PartModule-KSPField-KSPEvent-ConfigNode-and-PartResource
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class KSPField : Attribute
{
    public string category;
    /// <summary>
    /// Whether to show the value of this field in the right click menu of the part.
    /// </summary>
    public bool guiActive;
    /// <summary>
    /// The format string that will be passed to ToString when displaying the value of your field
    /// in the right click menu of the part?
    /// E.g. "F3" for a floating point number with 3 digits past the decimal point.
    /// </summary>
    public string guiFormat;
    /// <summary>
    /// The name that will be shown for this field in the right click menu of the part.
    /// </summary>
    public string guiName;
    /// <summary>
    /// The units that will be shown for this field in the right click menu of the part.
    /// </summary>
    public string guiUnits;
    /// <summary>
    /// Whether to store the value of this field in persistent.sfs when the game state is saved, and
    /// reload it from persistent.sfs when the game state is loaded.
    /// </summary>
    public bool isPersistant;

    public extern KSPField();
}
