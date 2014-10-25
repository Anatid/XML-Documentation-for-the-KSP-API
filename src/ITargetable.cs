using UnityEngine;

/// <summary>
/// Represents something that can be set as target while controlling
/// a vessel. This is implemented by <see cref="Vessel"/>, <see cref="CelestialBody"/>,
/// and <see cref="ModuleDockingNode"/>.
/// </summary>
public interface ITargetable
{
  Transform GetTransform();

  Vector3 GetObtVelocity();

  Vector3 GetSrfVelocity();

  Vector3 GetFwdVector();

  Vessel GetVessel();

  /// <summary>
  /// The name of this target.
  /// </summary>
  string GetName();

  Orbit GetOrbit();

  OrbitDriver GetOrbitDriver();

  VesselTargetModes GetTargetingMode();
}
