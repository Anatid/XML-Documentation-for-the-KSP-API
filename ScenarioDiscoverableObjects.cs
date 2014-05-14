using UnityEngine;

/// <summary>Stores information on asteroid spawning</summary>
///
/// <remarks>Executed while in Flight, Tracking Station, and Space Center scenes</remarks>
///
public class ScenarioDiscoverableObjects : ScenarioModule
{
	/// <summary>Number of untracked asteroids at which spawn rate begins to slow</summary>
	public int spawnGroupMinLimit = 3;

	/// <summary>Number of untracked asteroids at which spawn rate stops completely</summary>
	public int spawnGroupMaxLimit = 8;

	/// <summary>Sets size distribution for asteroids</summary>
	/// <remarks>
	/// The output range of [0, 1) is divided equally among the classes. So [0, 0.2) is class A, 
	/// [0.2, 0.4) is class B, ..., [0.8, 1) is class E.
	///
	/// Default curve translates to 
	///	12% class A, 13% class B, 49% class C, 13% class D, and 12% class E
	/// </remarks>
	///
	[KSPField (isPersistant = true)] public FloatCurve sizeCurve /* = new FloatCurve
	{
		{0  , 0   , 1.5  , 1.5  }, 
		{0.3, 0.45, 0.875, 0.875}, 
		{0.7, 0.55, 0.875, 0.875}, 
		{1  , 1   , 1.5  , 1.5  }
	}*/;

	/// <summary>Controls the fraction of spawn checks in which new asteroids are generated</summary>
	/// <remarks>
	/// The probability of spawning an asteroid is 1 / (1 + spawnOddsAgainst)
	/// </remarks>
	public int spawnOddsAgainst = 2;

	/// <summary>Number of seconds between asteroid checks</summary>
	///
	/// <remarks>
	/// These are seconds of time spent playing KSP, regardless of the time warp rate. The faster 
	///	your time warp, the longer the in-game interval between asteroid detections.
	/// </remarks>
	public float spawnInterval = 15.0f;

	/// <summary>Longest time an asteroid can go untracked before disappearing, in Earth days</summary>
	/// <seealso cref="DiscoveryInfo.unobservedLifetime" />
	public float maxUntrackedLifetime = 20.0f;

	/// <summary>Shortest time an asteroid can go untracked before disappearing, in Earth days</summary>
	/// <seealso cref="DiscoveryInfo.unobservedLifetime" />
	public float minUntrackedLifetime = 1.0f;

	//----------------------------------------------------------------------

	/// <summary>Returns a description of the current spawn interval and spawn odds</summary>
	///
	/// <seealso cref="spawnOddsAgainst" />
	/// <seealso cref="spawnInterval" />
	/*[ContextMenu ()]*/ public extern void debugSpawnProbability();

    public extern /*override*/ void OnAwake();
    public extern /*override*/ void OnLoad(ConfigNode node);
    public extern /*override*/ void OnSave(ConfigNode node);

	/// <summary>Creates a random asteroid and Kerbin-intercepting orbit</summary>
    /*[ContextMenu()]*/
    public extern void SpawnAsteroid();

	/// <summary>Creates a random asteroid and Kerbin-intercepting orbit.</summary>
	///
	/// <remarks>
	/// <seealso cref="SpawnAsteroid()">Asteroid is identical to the last 
	///	call of SpawnAsteroid()</seealso>
	///
	/// Intended for debugging?
	/// </remarks>
	/*[ContextMenu ()]*/ public extern void SpawnLastAsteroid ();

	public extern void Start ();
}