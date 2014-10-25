/// <summary>
/// Describes what "properties" of a target (<see cref="ITargetable"/>) are targetable.
/// </summary>
public enum VesselTargetModes
{
  /// <summary>
  /// None. How is this useful?
  /// </summary>
  None,
  /// <summary>
  /// Only the direction of the taget. Used by <see cref="CelestialBody"/>.
  /// </summary>
  Direction,
  /// <summary>
  /// Direction and velocity. Used by <see cref="Vessel"/>.
  /// </summary>
  DirectionAndVelocity,
  /// <summary>
  /// Direction, velocity, and orientation. Used by <see cref="ModuleDockingNode"/>.
  /// </summary>
  DirectionVelocityAndOrientation,
}
