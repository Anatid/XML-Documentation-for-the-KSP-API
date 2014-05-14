#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// FlightInputHandler stores some global information about the control of the current active vessel.
/// </summary>
public class FlightInputHandler : MonoBehaviour
{
    public static int currentTarget;
    /// <summary>
    /// Use this FlightInputHandler instance to access non-static members of the class.
    /// </summary>
    public static FlightInputHandler fetch;
    public bool hasFocus;
    public Renderer[] inputGaugeRenderers;
    [Obsolete("Use vessel.OnFlyByWire instead.")]
    public static FlightInputCallback OnFlyByWire;
    /// <summary>
    /// Presumably, whether precision mode is engaged.
    /// </summary>
    public bool precisionMode;
    public float rcsDeadZone;
    /// <summary>
    /// Whether RCS is enabled.
    /// </summary>
    public bool rcslock;
    /// <summary>
    /// Presumably, whether staging has been locked via Alt-L.
    /// </summary>
    public bool stageLock;
    /// <summary>
    /// The FlightCtrlState that represents player input. You can change the on-screen throttle
    /// by setting FlightCtrlState.state.mainThrottle.
    /// </summary>
    public static FlightCtrlState state;
    public float throttleResponsiveness;

    public extern FlightInputHandler();

    /// <summary>
    /// Whether RCS is enabled.
    /// </summary>
    public extern static bool RCSLock { get; }

    public extern void OnDestroy();
    /// <summary>
    /// Call this to set neutral controls; in particular this wil turn off the throttle.
    /// </summary>
    public extern static void SetNeutralControls();
}
