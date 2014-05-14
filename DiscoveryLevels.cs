using System;

/// <summary>Describes an IDiscoverable object's state regarding tracking and exploration</summary>
[Flags] public enum DiscoveryLevels {
	None,
	/// <summary>Object has been detected in tracking station</summary>
	Presence = 1,
	/// <summary>Object has been tracked</summary>
	Name = 4,
	/// <summary>Object is currently tracked</summary>
	StateVectors = 8,
	/// <summary>Unlocks mass and type fields; intended for discoverable CelestialBodies?</summary>
	Appearance = 16,
	/// <summary>Alias for "all flags"</summary>
	/// 
	/// <remarks>Set for docked asteroids and all normal ship parts.</remarks>
	Owned
}