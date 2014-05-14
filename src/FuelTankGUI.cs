#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;

/// <summary>
/// An unused class.
/// </summary>
public class FuelTankGUI : Part
{
    [KSPField(guiName = "Flow", guiActive = true)]
    public bool allowFlow;
    public float drainRate;
    public float dryMass;
    public float ejectionForce;
    public float emptyExplosionPotential;
    [KSPField(guiName = "Fuel", guiUnits = "L", guiActive = true)]
    public float fuel;
    public float fullExplosionPotential;

    public extern FuelTankGUI();

    protected extern override void onDecouple(float breakForce);
    public extern override void OnDrawStats();
    protected extern override void onFlightStart();
    public extern override void onFlightStateLoad(Dictionary<string, KSPParseable> parsedData);
    public extern override void onFlightStateSave(Dictionary<string, KSPParseable> partDataCollection);
    protected extern override bool onPartActivate();
    protected extern override void onPartAwake();
    protected extern override void onPartStart();
    public extern override bool RequestFuel(Part source, float amount, uint reqId);
}
