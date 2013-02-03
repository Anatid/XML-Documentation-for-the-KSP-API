#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// The physics simulation has problems if vessels move too fast relative to 
/// the underlying reference frame used by the simulation, or get too far from
/// the origin of the coordinate system. Krakensbane shifts the reference frame
/// origin and velocity so that the active vessel is always near the origin of,
/// and moving slowly with respect to, the underlying coordinate system used by the
/// physics simulation.
/// </summary>
public class Krakensbane : MonoBehaviour
{
    public Vector3d excessV;
    public Vector3d FrameVel;
    public Vector3d lastCorrection;
    public float MaxV;
    public Vector3d RBVel;
    public Vector3d totalVel;

    public extern Krakensbane();

    /// <summary>
    /// Returns the velocity of the Krakensbane velocity frame.
    /// </summary>
    /// <returns></returns>
    public extern static Vector3d GetFrameVelocity();
    /// <summary>
    /// Returns the velocity of the Krakensbane velocity frame as a single-precision vector.
    /// </summary>
    /// <returns></returns>
    public extern static Vector3 GetFrameVelocityV3f();
    /// <summary>
    /// Returns the last velocity correction performed.
    /// </summary>
    /// <returns></returns>
    public extern static Vector3d GetLastCorrection();
    /// <summary>
    /// sets the frame velocity back to 0m/s. Use this if setting the worldspace velocity of vessels directly.
    /// </summary>
    public extern static void ResetVelocityFrame();
    /// <summary>
    /// Moves all vessels not on rails by the given position offset. This will usually only affect the active vessel,
    /// unless there are other vessels nearby. The offset can be very large and the vessels
    /// will not break, unlike for Vessel.SetPosition.
    /// </summary>
    /// <param name="offset"></param>
    public extern void setOffset(Vector3d offset);
}
