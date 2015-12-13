using UnityEngine;

public class Game {
	public ConfigNode config;

	public uint launchID;

	public string flagURL;

	public int file_version_revision;

	public int file_version_minor;

	public int file_version_major;

	public bool compatible;

	public ConfigNode additionalSystems;

	/// <summary>
	/// A list of all scenario templates in the currently loaded game.
	/// </summary>
	/// 
	/// <remarks>Since most ProtoScenarioModules contain a reference to the Scenario that represents 
	/// them, this member is the easiest way to locate a specific Scenario in most cases. It is 
	/// recommended that ProtoScenarioModules be searched by <c>ProtoScenarioModule.moduleName</c>, 
	/// not by <c>ProtoScenarioModule.moduleRef</c>, as the latter may be null.</remarks>
	public List<ProtoScenarioModule> scenarios;

	public GameParameters Parameters;

	public FlightState flightState;

	public KerbalRoster CrewRoster;

	public GameScenes startScene;

	public Game.GameStatus Status;

	public Game.Modes Mode;

	public string linkCaption;

	public string linkURL;

	public string Description;

	public string Title;

	public EditorFacility editorFacility;

	public double UniversalTime {
		get;
	}

	/// <summary>
	/// Creates a new scenario of the specified type. Once created, the scenario will persist 
	/// automatically.
	/// </summary>
	/// <returns>A ProtoScenarioModule corresponding to the newly installed scenario.</returns>
	/// <param name="typeOfScnModule">The scenario module to create. The object represented by 
	/// this type must be a subclass of ScenarioModule.</param>
	/// <param name="scenes">The scenes in which the scenario should automatically load itself.</param>
	public extern ProtoScenarioModule AddProtoScenarioModule(Type typeOfScnModule, params GameScenes[] scenes);

	public extern ProtoVessel AddVessel(ConfigNode protoVesselNode);

	public extern bool DestroyVessel(Vessel v);

	public extern bool IsResumable();

	public extern void Load();

	/// <summary>
	/// Unregisters a ProtoScenarioModule from the game. It will not persist until the scenario 
	/// is re-added.</summary>
	/// <remarks>IMPORTANT: calling this method DOES NOT remove the Scenario object itself, which will 
	/// continue to run until the next scene change.</remarks>
	/// <returns><c>true</c>, if the ProtoScenarioModule was removed, <c>false</c> if it could not 
	/// be found.</returns>
	/// <param name="typeOfScnModule">The scenario module to de-persist. The object represented by 
	/// this type must be a subclass of ScenarioModule.</param>
	public extern bool RemoveProtoScenarioModule(Type typeOfScnModule);

	public extern void Save(ConfigNode rootNode);

	public extern void Start();

	public extern Game Updated();

	public enum GameStatus {
		UNSTARTED,
		ONGOING,
		FAILED_OR_ABORTED,
		COMPLETED
	}

	public enum Modes {
		SANDBOX,
		CAREER,
		SCENARIO,
		SCENARIO_NON_RESUMABLE,
		SCIENCE_SANDBOX
	}
}
