#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stock fuel lines are not yet PartModules, but are implemented through this class.
/// </summary>
public class FuelLine : Part
{
    public Vector3 direction;
    public Transform endCap;
    public FuelLine.FuelFlowDirection flowDirection;
    public bool fuelLineOpen;
    public Part fuelLookupTarget;
    public Transform line;
    public float maxLength;
    public Transform startCap;
    /// <summary>
    /// The part that can draw fuel through this fuel line. This fuel line in turn draws fuel from its parent.
    /// </summary>
    public Part target;
    public Transform targetAnchor;
    public Vector3 targetPosition;

    public extern FuelLine();

    public extern void BreakLine();
    public extern void CloseFuelLine();
    public extern override bool FindFuel(Part source, List<Part> fuelSources, uint reqId);
    public extern override void onBackup();
    protected extern override void onCopy(Part original, bool asSymCPart);
    public extern override void OnDrawStats();
    protected extern override void onEditorUpdate();
    protected extern override void onFlightStart();
    protected extern override void onPartAttach(Part parent);
    protected extern override void onPartDestroy();
    protected extern override void onPartDetach();
    protected extern override void onPartFixedUpdate();
    protected extern override void onPartLoad();
    protected extern override void onPartStart();
    public extern bool raycastTarget();
    public extern bool raycastTarget(Vector3 dir);
    public extern override bool RequestFuel(Part requester, float amount, uint reqId);
    public extern void SetFuelSource(Part requester);

    public enum FuelFlowDirection
    {
        AUTO = 0,
        TO_PARENT = 1,
        TO_TARGET = 2,
    }
}
