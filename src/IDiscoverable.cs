/// <summary>Methods allowing information for celestial bodies or ships to be hidden at game start</summary>
///
/// <remarks>
/// These methods appear to be used in the tracking station.
///
/// Implemented by CelestialBody
/// Implemented by Vessel
/// </remarks>
public interface IDiscoverable
{
	/// <summary>Describes to what extent this object has been explored</summary>
	DiscoveryInfo DiscoveryInfo {
		get;
	}

	/// <summary>Returns the object's altitude</summary>
	/// 
	/// <returns>The height above the reference sphere of the Celestial Body in 
	///	whose sphere of influence the object lies, in meters.</returns>
	///
	double RevealAltitude ();

	/// <summary>Returns the object's mass</summary>
	///
	/// <remarks>Units are implementation-dependent.</remarks>
	float RevealMass ();

	/// <summary>Returns the object's tracking station name</summary>
	///
	/// <returns>The string to display in the tracking station</returns>
	/// 
	string RevealName ();

	/// <summary>Describes the state of the object</summary>
	///
	/// <returns>A string containing the sphere of influence and trajectory of the object
	/// 
	/// <example>"Orbiting the Sun"</example>
	/// </returns>
	string RevealSituationString ();

	/// <summary>Returns the speed of the object</summary>
	///
	/// <returns>The inertial speed relative to the Celestial Body in whose sphere of influence 
	///	the object lies, in meters per second.</returns>
	///
	double RevealSpeed ();

	/// <summary>Gives the type of object used</summary>
	/// 
	/// <remarks>Meaning is implementation-dependent.</remarks>
	string RevealType ();
}
