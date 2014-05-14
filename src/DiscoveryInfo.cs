using System;

/// <summary>Represents the "remote sensing" information available for an IDiscoverable</summary>
///
/// <invariant>this.fadeUT = this.lastObservedTime + this.unobservedLifetime</invariant>
///
[Serializable] public class DiscoveryInfo /*: IConfigNode*/ {
	/// <summary>Tracking station wrapper for IDiscoverable.RevealAltitude()</summary>
	/// 
	/// <remarks>Requires DiscoveryLevels.StateVectors</remarks>
	///
	public KnowledgeItem<double> distance;

	/// <summary>Tracking station wrapper for IDiscoverable.RevealSituationString()</summary>
	/// 
	/// <remarks>Requires DiscoveryLevels.StateVectors</remarks>
	///
	public KnowledgeItem<string> situation;

	/// <summary>Tracking station wrapper for IDiscoverable.RevealSpeed()</summary>
	/// 
	/// <remarks>Requires DiscoveryLevels.StateVectors</remarks>
	///
	public KnowledgeItem<double> speed;

	/// <summary>Tracking station wrapper for IDiscoverable.RevealMass()</summary>
	/// 
	/// <remarks>Requires DiscoveryLevels.Appearance</remarks>
	///
	public KnowledgeItem<float> mass;

	/// <summary>Tracking station wrapper for IDiscoverable.RevealType()</summary>
	/// 
	/// <remarks>Requires DiscoveryLevels.Appearance</remarks>
	///
	public KnowledgeItem<string> type;

	/// <summary>Tracking station wrapper for this.objectSize</summary>
	/// 
	/// <remarks>Always visible</remarks>
	///
	public KnowledgeItem<UntrackedObjectClass> size;

	/// <summary>Tracking station wrapper for Level?</summary>
	/// 
	/// <remarks>Always visible</remarks>
	///
	public KnowledgeItem<string> trackingStatus;

	/// <summary>Tracking station wrapper for GetSignalStrength()</summary>
	/// 
	/// <remarks>Rounded to the nearest 0.1%.
	///
	/// Always visible</remarks>
	///
	public KnowledgeItem<double> signalStrengthPercent;

	/// <summary>Tracking station wrapper for IDiscoverable.RevealName()</summary>
	/// 
	/// <remarks>Requires DiscoveryLevels.Name</remarks>
	///
	public KnowledgeItem<string> name;

	/// <summary>Tracking station wrapper for GetSignalStrengthCaption()</summary>
	/// 
	/// <remarks>Always visible</remarks>
	///
	public KnowledgeItem<string> signalStrengthLevel;

	//----------------------------------------------------------------------

	/// <summary>The time at which the asteroid is scheduled to be deleted</summary>
	public double fadeUT {
		get;
		private set;
	}

	/// <summary>The time at which the asteroid was last tracked</summary>
	///
	/// <remarks>Stored in persistence file</remarks>
	public double lastObservedTime {
		get;
		private set;
	}

	/// <summary>The asteroid's tracking state</summary>
	///
	/// <remarks>Stored in persistence file as state</remarks>
	public DiscoveryLevels Level {
		get;
		private set;
	}

	/// <summary>The size class (A-E) of the asteroid</summary>
	///
	/// <remarks>Stored in persistence file as size</remarks>
	public UntrackedObjectClass objectSize {
		get;
		private set;
	}

	/// <summary>The time for which an asteroid can go untracked if it starts at full signal strength</summary>
	///
	/// <remarks>Alternate definition: the time needed for the signal strength to fall by 1 unit.
	///
	/// Always equals 1728000 seconds, or 20 Earth days
	/// 
	/// Stored in persistence file as refTime</remarks>
	public double referenceLifetime {
		get;
		private set;
	}

	/// <summary>The time for which the asteroid can go untracked before it is deleted</summary>
	/// 
	/// <remarks>Stored in persistence file as lifetime</remarks>
	public double unobservedLifetime {
		get;
		private set;
	}

	//----------------------------------------------------------------------

	/// <summary>Initializes a Class C asteroid</summary>
	///
	/// <param name="host">The vessel or celestial body to which this DiscoveryInfo applies</param>
	/// <param name="level">The amount of knowledge for the asteroid</param>
	/// <param name="untrackedLifetime">The amount of time the asteroid can remain untracked 
	/// 	before disappearing</param>
	///
    public extern DiscoveryInfo(IDiscoverable host, DiscoveryLevels level, double untrackedLifetime);

	/// <summary>Initializes a Class C asteroid, and assumes all properties are already known.</summary>
	///
	/// <param name="host">The vessel or celestial body to which this DiscoveryInfo applies</param>
	/// <param name="untrackedLifetime">The amount of time the asteroid can remain untracked 
	/// 	before disappearing</param>
	///
    public extern DiscoveryInfo(IDiscoverable host, double untrackedLifetime);

	/// <summary>Initializes a Class C asteroid, and assumes all properties are already known.</summary>
	///
	/// <param name="host">The vessel or celestial body to which this DiscoveryInfo applies</param>
	///
    public extern DiscoveryInfo(IDiscoverable host);

	//----------------------------------------------------------------------

	/// <summary>Returns a text description of the signal strength</summary>
	/// 
	/// <returns>If <paramref name="signal"/> is in [0.0, 0.2), returns "Very Weak"</returns>
	/// <returns>If <paramref name="signal"/> is in [0.2, 0.4), returns "Weak"</returns>
	/// <returns>If <paramref name="signal"/> is in [0.4, 0.6), returns "Average"</returns>
	/// <returns>If <paramref name="signal"/> is in [0.6, 0.8), returns "Good"</returns>
	/// <returns>If <paramref name="signal"/> is in [0.8, 1.0], returns "Strong"</returns>
	///
    public static extern string GetSignalStrengthCaption(double signal);

	/// <summary>Returns long description of asteroid type</summary>
	///
	/// <param name="sizeClass">The asteroid type to label</param>
	///
	/// <returns>The asteroid class explanation printed on the tracking station's info panel.
	///
	/// <example>"Class C Objects are about average-sized..."</example>
	///
	/// If not a valid value of UntrackedObjectClass, returns "This seems to be a non-standard size class. Who knows what it'll look like?"
	/// </returns>
    public static extern string GetSizeClassDescription(UntrackedObjectClass sizeClass);

	/// <summary>Returns asteroid size displayed in map view</summary>
	///
	/// <param name="sizeClass">The asteroid type to label</param>
	///
	/// <returns>The asteroid class printed beneath an untracked asteroid.
	///
	/// <example>"C (Medium)"</example>
	///
	/// If not a valid value of UntrackedObjectClass, returns "???"
	/// </returns>
    public static extern string GetSizeClassSizes(UntrackedObjectClass sizeClass);

	//----------------------------------------------------------------------

	/// <summary>Returns the fraction of the asteroid's unobservedLifetime that remains</summary>
	///
	/// <param name="UT">The time at which the signal life is measured</param>
	/// 
	/// <remarks>GetSignalLife(t_discover) == 1.0
	/// GetSignalLife(fadeUT) == 0.0</remarks>
	///
    public extern double GetSignalLife(double UT);

	/// <summary>Returns amount of time remaining until the asteroid is lost, in units of referenceLifetime</summary>
	///
	/// <param name="UT">The time at which the signal strength is measured</param>
	/// 
	/// <remarks>GetSignalStrength(t_discover) == unobservedLifetime / referenceLifetime
	/// GetSignalStrength(fadeUT) == 0.0</remarks>
	///
    public extern double GetSignalStrength(double UT);

	/// <summary>Function testing if an asteroid has a particular discovery level</summary>
	///
	/// <param name="lvl">The flag(s) whose presence must be tested.</param>
	/// 
	/// <returns>True if at least one of the flags in <paramref name="lvl"/> is in 
	///	this object, false otherwise</returns>
	///
    public extern bool HaveKnowledgeAbout(DiscoveryLevels lvl);

    public extern void Load(ConfigNode node);
    public extern void Save(ConfigNode node);

	/// <summary>Logs an asteroid observation</summary>
	///
	/// <param name="UT">The new time of last observation</param>
	///
    public extern void SetLastObservedTime(double UT);

	/// <summary>Sets the level of knowledge the player has for the asteroid</summary>
	///
	/// <param name="level">The flags representing the asteroid's exploration state</param>
	///
    public extern void SetLevel(DiscoveryLevels level);

	/// <summary>Updates the reference lifetime</summary>
	///
	/// <param name="time">Changes the scaling of signal strength.</param>
	///
    public extern void SetReferenceLifetime(double time);

	/// <summary>Updates the time for which the asteroid can go untracked, preserving class invariants</summary>
	///
	/// <param name="time">The maximum time to track the asteroid</param>
	///
    public extern void SetUnobservedLifetime(double time);

	/// <summary>Updates the asteroid size</summary>
	///
	/// <param name="size">The asteroid class (A-E)</param>
	///
	public extern void SetUntrackedObjectSize (UntrackedObjectClass size);
}
