#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;

/// <summary>
/// The old, deprecated class that implemented fuel tanks before the resource system.
/// Don't use this class: to allow a part to store a resource add a RESOURCE block to the part.cfg.
/// </summary>
public class FuelTank : Part
{
    [KSPField]
    public bool allowFlow;
    [KSPField(guiName = "Flow Rate", guiUnits = "L/sec", guiFormat = "0.0", isPersistant = false, guiActive = true)]
    public float drainRate;
    public float dryMass;
    public float emptyExplosionPotential;
    [KSPField(guiName = "Fuel", guiUnits = "L", guiFormat = "F1", isPersistant = false, guiActive = true)]
    public float fuel;
    public float fullExplosionPotential;

    public extern FuelTank();

    public extern override bool DrainFuel(float amount);
    public extern override bool FindFuel(Part source, List<Part> fuelSources, uint reqId);
    protected extern override void onDecouple(float breakForce);
    public extern override void OnDrawStats();
    protected extern override void onFlightStart();
    public extern override void onFlightStateLoad(Dictionary<string, KSPParseable> parsedData);
    public extern override void onFlightStateSave(Dictionary<string, KSPParseable> partDataCollection);
    protected extern override bool onPartActivate();
    protected extern override void onPartAwake();
    protected extern override void onPartFixedUpdate();
    protected extern override void onPartStart();
    public extern override bool RequestFuel(Part source, float amount, uint reqId);
}
