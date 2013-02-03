#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// An old, deprecated class that used to be used to implement decouplers before PartModules.
/// Use ModuleDecouple or ModuleAnchoredDecoupler instead.
/// </summary>
public class DecouplerGUI : Part
{
    public float ejectionForce;

    public extern DecouplerGUI();

    [KSPAction("Decouple")]
    public extern void DecoupleAction(KSPActionParam param);
    [KSPEvent(guiName = "Decouple", guiActive = true)]
    public extern void GUIDecouple();
    public extern override void OnDrawStats();
    protected extern override bool onPartActivate();
    protected extern override void onPartStart();
}
