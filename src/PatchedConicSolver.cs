#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Each vessel has a PatchedConicSolver, which stores the predicted patched conics trajectory and
/// any maneuver nodes that currently exist.
/// </summary>
[RequireComponent(typeof(OrbitDriver))]
public class PatchedConicSolver : MonoBehaviour
{
    public bool debug_disableEscapeCheck;
    public List<Orbit> flightPlan;
    public int GeoSolverIterations;
    /// <summary>
    /// A list of the maneuver nodes that are currently planned for this vessel.
    /// </summary>
    public List<ManeuverNode> maneuverNodes;
    public int maxGeometrySolverIterations;
    public int maxTimeSolverIterations;
    public int maxTotalPatches;
    public bool MorePatchesAhead;
    public OrbitDriver obtDriver;
    public double outerReaches;
    public List<Orbit> patches;
    public int patchesAhead;
    public CelestialBody targetBody;
    public int TimeSolverIterations1;
    public int TimeSolverIterations2;

    public extern PatchedConicSolver();

    public extern Orbit LastActivePatch { get; }
    public extern Orbit orbit { get; }

    /// <summary>
    /// Add a maneuver node to the flight plan.
    /// </summary>
    /// <param name="UT">The universal time of the maneuver node.</param>
    /// <returns>A reference to the maneuver node</returns>
    public extern ManeuverNode AddManeuverNode(double UT);
    [ContextMenu("Decrease Patch Limit")]
    public extern void DecreasePatchLimit();
    [ContextMenu("Increase Patch Limit")]
    public extern void IncreasePatchLimit();
    /// <summary>
    /// Remove a maneuver node from the flight plane.
    /// </summary>
    /// <param name="node">The maneuver node to be removed.</param>
    public extern void RemoveManeuverNode(ManeuverNode node);
    public extern void Update();
    public extern void UpdateFlightPlan();
}
