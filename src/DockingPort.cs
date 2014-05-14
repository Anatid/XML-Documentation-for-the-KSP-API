#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// An unused class; use ModuleDockingNode instead.
/// </summary>
public class DockingPort : Part
{
    public Vector3 dockingNodeOrientation;
    public Vector3 dockingNodePosition;
    public float ejectionForce;

    public extern DockingPort();

    [KSPEvent(guiName = "AutoDock", guiActive = true)]
    public extern void ActivateAutoDock();
    public extern override void OnDrawStats();
    protected extern override void onFlightStart();
    protected extern override bool onPartActivate();
    protected extern override void onPartStart();
    [KSPEvent(guiName = "Undock", guiActive = true)]
    public extern void Undock();
}
