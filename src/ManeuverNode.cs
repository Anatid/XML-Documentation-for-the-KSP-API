#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;


/// <summary>
/// Represents a maneuver node.
/// </summary>
[Serializable]
public class ManeuverNode
{
    public ManeuverGizmo attachedGizmo;
    /// <summary>
    /// The delta-V of the burn represented by this maneuver node, in m/s. NOTE: maneuver nodes use a special coordinate system for delta-V.
    /// The x-component of DeltaV represents the delta-V in the radial-plus direction. The y-component of DeltaV 
    /// represents the delta-V in the normal-minus direction. The z-component of DeltaV represents the delta-V in the
    /// prograde direction.
    /// </summary>
    public Vector3d DeltaV;
    /// <summary>
    /// The orbit patch that starts at this maneuver node.
    /// </summary>
    public Orbit nextPatch;
    public Quaternion nodeRotation;
    /// <summary>
    /// The orbit patch that ends at this maneuver node?
    /// </summary>
    public Orbit patch;
    public Transform scaledSpaceTarget;
    public PatchedConicSolver solver;
    /// <summary>
    /// The universal time of the burn represented by this maneuver node.
    /// </summary>
    public double UT;

    public extern ManeuverNode();

    public extern void AttachGizmo(GameObject gizmoPrefab, PatchedConicRenderer renderer, PatchRendering pr);
    public extern void DetachGizmo();
    /// <summary>
    /// Perhaps this translates the DeltaV vector into a world-space vector?
    /// </summary>
    /// <param name="currentOrbit"></param>
    /// <returns></returns>
    public extern Vector3d GetBurnVector(Orbit currentOrbit);
    /// <summary>
    /// You can call this function to change the delta-V and time of a maneuver node.
    /// </summary>
    /// <param name="dV">The new delta-V. See the DeltaV for notes about the coordinate system used.</param>
    /// <param name="ut">The new universal time.</param>
    public extern void OnGizmoUpdated(Vector3d dV, double ut);
    public extern void RemoveSelf();
}
