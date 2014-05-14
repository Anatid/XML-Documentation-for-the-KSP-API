/// <summary>Key module in PART[PotatoRoid]</summary>
///
/// <remarks> 
/// Although this module is included in the PotatoRoid config file, it is not saved 
/// in the VESSEL trees of unvisited asteroids. The module is initialized when an asteroid 
/// first enters physics range
/// </remarks>
public class ModuleAsteroid : PartModule, IVesselAutoRename
{
	/// <summary>Density of asteroid, in tons/m^3. Used to calculate part mass.</summary>
	[KSPField] public float density = 0.03;

	/// <summary>Largest allowed radius relative to nominal radius for that asteroid class</summary>
	[KSPField] public float maxRadiusMultiplier = 1.25;

	/// <summary>The fraction of science recovered by transmitting back to Kerbin.</summary>
	[KSPField] public float sampleExperimentXmitScalar = 0.3;

	/// <summary>The science experiment triggered by sampling this asteroid.</summary>
	[KSPField] public string sampleExperimentId = "asteroidSample";

	/// <summary>Smallest allowed radius relative to nominal radius for that asteroid class</summary>
	[KSPField] public float minRadiusMultiplier = 0.75;

	/// <summary>Stores the original name of the asteroid, before any ships docked with it</summary>
	[KSPField (isPersistant = true)] public string AsteroidName;

	/// <summary>Used to generate asteroid mesh</summary>
	[KSPField (isPersistant = true)] public int seed;

	/// <summary>Stores some kind of resource.</summary>
	///
	/// <example>"Procedural/PA_C"</example>
	[KSPField (isPersistant = true)] public string prefabBaseURL;

	//----------------------------------------------------------------------

	/// <summary>Returns asteroid name</summary>
	///
	/// <returns>The original asteroid name, not that of any docked ships</returns>
	///
	/// <remarks>Implements IVesselAutoRename</remarks>
	public string GetVesselName ();

	/// <summary>Returns the ship class</summary>
	///
	/// <returns>Returns VesselType.SpaceObject</returns>
	///
	/// <remarks>Implements IVesselAutoRename</remarks>
	public VesselType GetVesselType ();

	/// <summary>Called when the player selects the asteroid's center of mass as their target</summary>
	[KSPEvent] public void MakeTarget ();

	/// <summary>Initializes the asteroid</summary>
	public override void OnStart (PartModule.StartState state);

	[DebuggerHidden] public IEnumerator PostInit ();

	/// <summary> Called when the player manually renames the asteroid</summary>
	[KSPEvent] public void RenameAsteroidEvent ();

	/// <summary>Called when the player takes a surface sample</summary>
	[KSPEvent] public void TakeSampleEVAEvent ();
}
