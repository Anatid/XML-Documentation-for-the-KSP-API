
using Contracts;
using System;

/// <summary>
/// GameEvents are EventData or EventVoid methods called when certain conditions are met.
/// 
/// Many include some relevant data on the objects affected when they are triggered.
/// 
/// Use:
/// 
/// GameEvents.desiredEvent.Add(yourMethod);
/// 
/// and
/// 
/// GameEvents.desiredEvent.Removed(yourMethod);
/// 
/// to add and remove methods from a list of methods to be called when the event is triggered.
/// 
/// Methods are generally added in your object's Start or Awake method and generally removed
/// in your object's OnDestroy method.
/// 
/// Be sure not add methods multiple times withoud destroying them between additions.
/// </summary>
public static class GameEvents
{
	public static bool debugEvents;
	/// <summary>
	/// Triggered when a vessel docks or attaches with the grappling device;
	/// fires twice, once for each vessel
	/// </summary>
	public static EventData<Vessel> onActiveJointNeedUpdate;
	/// <summary>
	/// Triggered when two parts collide
	/// </summary>
	public static EventData<EventReport> onCollision;
	/// <summary>
	/// Triggered when a part or vessel crashes into the terrain
	/// </summary>
	public static EventData<EventReport> onCrash;
	/// <summary>
	/// Triggered when a part crashes into the ocean
	/// </summary>
	public static EventData<EventReport> onCrashSplashdown;
	/// <summary>
	/// Triggered when an EVA Kerbal boards a vessel
	/// </summary>
	public static EventData<GameEvents.FromToAction<Part, Part>> onCrewBoardVessel;
	/// <summary>
	/// Triggered whenever a Kerbal dies; either on EVA or in a crashing vessel
	/// </summary>
	public static EventData<EventReport> onCrewKilled;
	/// <summary>
	/// Triggered when a Kerbal goes on EVA
	/// </summary>
	public static EventData<GameEvents.FromToAction<Part, Part>> onCrewOnEva;
	/// <summary>
	/// Triggered when changing SOI; both objects return the new dominant CelestialBody
	/// 
	/// See also onVesselSOIChanged
	/// </summary>
	public static EventData<GameEvents.FromToAction<CelestialBody, CelestialBody>> onDominantBodyChange;
	/// <summary>
	/// Triggered when any part is added or removed from a vessel in the editor;
	/// also triggered when any tweakable settings are changed;
	/// also when undo is called
	/// </summary>
	public static EventData<ShipConstruct> onEditorShipModified;
	/// <summary>
	/// When a flag is planted by an EVA Kerbal
	/// </summary>
	public static EventData<Vessel> onFlagPlant;
	/// <summary>
	/// Triggered when a flag is selected from the space center's flag pole
	/// </summary>
	public static EventData<string> onFlagSelect;
	/// <summary>
	/// Triggered when a vessel is fully loaded
	/// </summary>
	public static EventVoid onFlightReady;
	/// <summary>
	/// Deprecated?
	/// </summary>
	public static EventData<Vector3d> onFloatingOriginShift;
	/// <summary>
	/// When Funds level changes, returns total Funds amount
	/// </summary>
	public static EventData<double> OnFundsChanged;
	/// <summary>
	/// When the game is paused
	/// </summary>
	public static EventVoid onGamePause;
	/// <summary>
	/// Triggered upon scene change requests; returns the target GameScene
	/// </summary>
	public static EventData<GameScenes> onGameSceneLoadRequested;
	/// <summary>
	/// When Game Settings are applied in the main settings menu, or the in-game settings menu
	/// </summary>
	public static EventVoid OnGameSettingsApplied;
	/// <summary>
	/// When a game is first created or loaded; returns the Game object
	/// </summary>
	public static EventData<Game> onGameStateCreated;
	/// <summary>
	/// Triggered on loading a game, returns the game's full ConfigNode from the persistent file
	/// </summary>
	public static EventData<ConfigNode> onGameStateLoad;
	/// <summary>
	/// Triggered on saving a game, returns the game's full ConfigNode from the persistent file
	/// </summary>
	public static EventData<ConfigNode> onGameStateSave;
	/// <summary>
	/// Triggered when a game is saved, returns the Game object;
	/// </summary>
	public static EventData<Game> onGameStateSaved;
	/// <summary>
	/// When the game is unpaused
	/// </summary>
	public static EventVoid onGameUnpause;
	/// <summary>
	/// When the application launcher (toolbar) is closed
	/// </summary>
	public static EventVoid onGUIApplicationLauncherDestroyed;
	/// <summary>
	/// Called when the ApplicationLauncher toolbar is ready to have buttons added to it.
	/// </summary>
	public static EventVoid onGUIApplicationLauncherReady;
	/// <summary>
	/// When the astronaut complex window closes
	/// </summary>
	public static EventVoid onGUIAstronautComplexDespawn;
	/// <summary>
	/// When the astronaut complex window opens; from the space center or editor
	/// </summary>
	public static EventVoid onGUIAstronautComplexSpawn;
	/// <summary>
	/// When the vessel selection screen is closed or a vessel is selected and launched
	/// </summary>
	public static EventVoid onGUILaunchScreenDespawn;
	/// <summary>
	/// When the launch screen (that allows you to view and select available vessels) is opened;
	/// after selecting the launchpad/runway from the space center.
	/// 
	/// See VesselSpawnInfo for more on what is returned by this callback.
	/// </summary>
	public static EventData<GameEvents.VesselSpawnInfo> onGUILaunchScreenSpawn;
	/// <summary>
	/// When a vessel is selected from the vessel selection screen at the space center
	/// </summary>
	public static EventData<ShipTemplate> onGUILaunchScreenVesselSelected;
	/// <summary>
	/// When the application launcher's message button is ready
	/// </summary>
	public static EventVoid onGUIMessageSystemReady;
	/// <summary>
	/// When the mission control center window closes
	/// </summary>
	public static EventVoid onGUIMissionControlDespawn;
	/// <summary>
	/// When the mission control center window opens
	/// </summary>
	public static EventVoid onGUIMissionControlSpawn;
	/// <summary>
	/// When the application launcher (toolbar) loads;
	/// triggers before onGUIApplicationLauncherReady and onGUIMessageSystemReady
	/// </summary>
	public static EventVoid onGUIPrefabLauncherReady;
	/// <summary>
	/// When the recovery dialog window closes
	/// </summary>
	public static EventData<MissionRecoveryDialog> onGUIRecoveryDialogDespawn;
	/// <summary>
	/// When the recovery dialog window opens
	/// </summary>
	public static EventData<MissionRecoveryDialog> onGUIRecoveryDialogSpawn;
	/// <summary>
	/// When the R&amp;D center window closes
	/// </summary>
	public static EventVoid onGUIRnDComplexDespawn;
	/// <summary>
	/// When the R&amp;D center window opens
	/// </summary>
	public static EventVoid onGUIRnDComplexSpawn;
	/// <summary>
	/// Called when the player hides the UI by pressing F2. Register for this callback (and for onShowUI)
	/// so that you can hide your UI too.
	/// </summary>
	public static EventVoid onHideUI;
	/// <summary>
	/// Triggered when input locks are activated or deactivated;
	/// when putting the mouse over one window/button locks the controls
	/// of another window/button
	/// </summary>
	public static EventData<GameEvents.FromToAction<ControlTypes, ControlTypes>> onInputLocksModified;
	/// <summary>
	/// Deprecated? Use onPartJointBreak
	/// </summary>
	public static EventData<EventReport> onJointBreak;
	/// <summary>
	/// Triggered when a new Kerbal is added in the astronaut complex scene;
	/// also triggered when a rescue Kerbal contract is generated
	/// </summary>
	public static EventData<ProtoCrewMember> onKerbalAdded;
	/// <summary>
	/// Triggered when a Kerbal is removed from the roster in the astronaut complex;
	/// also triggered when a rescue Kerbal contract is failed, expires, or declined
	/// </summary>
	public static EventData<ProtoCrewMember> onKerbalRemoved;
	/// <summary>
	/// Triggered when the ProtoCrewMember.RosterStatus changes;
	/// usually upon vessel recovery, new crew addition, or death;
	/// returns the ProtoCrewMember and its old and new status
	/// </summary>
	public static EventData<ProtoCrewMember, ProtoCrewMember.RosterStatus, ProtoCrewMember.RosterStatus> onKerbalStatusChange;
	/// <summary>
	/// Triggered when the ProtoCrewMember.KerbalType changes;
	/// KerbalTypes are possibly not fully implemented;
	/// occurs upon hiring crew or rescuing Kerbal
	/// </summary>
	public static EventData<ProtoCrewMember, ProtoCrewMember.KerbalType, ProtoCrewMember.KerbalType> onKerbalTypeChange;
	/// <summary>
	/// Triggered upon starting or stopping asteroid tracking, or when approaching an asteroid
	/// </summary>
	public static EventData<GameEvents.HostedFromToAction<IDiscoverable, DiscoveryLevels>> onKnowledgeChanged;
	/// <summary>
	/// Triggered when a vessel's velocity falls below ~750m/s
	/// </summary>
	public static EventData<Vector3d> onKrakensbaneDisengage;
	/// <summary>
	/// Triggered when a vessel's velocity reaches ~750m/s
	/// </summary>
	public static EventData<Vector3d> onKrakensbaneEngage;
	/// <summary>
	/// Triggered when launching by activating the first stage
	/// </summary>
	public static EventData<EventReport> onLaunch;
	/// <summary>
	/// Triggered when a new scene is loaded; returns that GameScene;
	/// occurs after onGameSceneLoadRequested
	/// </summary>
	public static EventData<GameScenes> onLevelWasLoaded;
	/// <summary>
	/// Triggered when selecting a new flag from in the editor;
	/// returns the flag texture's GameDatabse URL
	/// </summary>
	public static EventData<string> onMissionFlagSelect;
	/// <summary>
	/// Triggered when spawning a new asteroid or a new Kerbal for
	/// a rescue Kerbal contract
	/// </summary>
	public static EventData<Vessel> onNewVesselCreated;
	/// <summary>
	/// Triggered when a part overheats; returns an EventReport with the part name
	/// </summary>
	public static EventData<EventReport> onOverheat;
	/// <summary>
	/// Triggered when right-clicking a part; returns that part;
	/// triggered every time a part event is selected
	/// </summary>
	public static EventData<Part> onPartActionUICreate;
	/// <summary>
	/// Triggered when closing the right-click menu of a part
	/// </summary>
	public static EventData<Part> onPartActionUIDismiss;
	/// <summary>
	/// Triggered when adding a part in the editor, when docking, and when another vessel comes into range and is loaded;
	/// returns the part and its new parent part
	/// </summary>
	public static EventData<GameEvents.HostTargetAction<Part, Part>> onPartAttach;
	/// <summary>
	/// Triggered when a docking port or asteroid grappling device attaches;
	/// returns the host part and the target part
	/// </summary>
	public static EventData<GameEvents.FromToAction<Part, Part>> onPartCouple;
	/// <summary>
	/// Triggered when a part object's OnDestroy method is called;
	/// occurs any time a part or vessel is unloaded,
	/// ie scene changes or vessel moving out of loading distance
	/// </summary>
	public static EventData<Part> onPartDestroyed;
	/// <summary>
	/// Triggered when a part is destroyed, usually by exploding/crashing
	/// </summary>
	public static EventData<Part> onPartDie;
	/// <summary>
	/// Triggered when a part explodes, usually due to crashing into the ground or into another part;
	/// also triggered by a part overheating and exploding
	/// </summary>
	public static EventData<GameEvents.ExplosionReaction> onPartExplode;
	/// <summary>
	/// Triggered when a part decouples, undocks, a grappling device undocks, a strut breaks,
	/// a part is destroyed, or when a part is removed in the editor
	/// </summary>
	public static EventData<PartJoint> onPartJointBreak;
	/// <summary>
	/// Triggered when a part goes on rails (enters timewarp) or exits loading distance
	/// </summary>
	public static EventData<Part> onPartPack;
	/// <summary>
	/// Triggered when purchasing a part in the R&amp;D center;
	/// currently (KSP 0.24.2) called for all parts in a tech node when researching that node
	/// </summary>
	public static EventData<AvailablePart> OnPartPurchased;
	/// <summary>
	/// Triggered when removing a part in the editor
	/// </summary>
	public static EventData<GameEvents.HostTargetAction<Part, Part>> onPartRemove;
	/// <summary>
	/// Triggered upon undock event/action; not triggered by a docking node's decouple event;
	/// also triggered by asteroid grappling device's release event
	/// </summary>
	public static EventData<Part> onPartUndock;
	/// <summary>
	/// Triggered when a part goes off rails (exits timewarp) or comes into loading distance
	/// </summary>
	public static EventData<Part> onPartUnpack;
	/// <summary>
	/// Triggered when the map view or tracking station camera focuses on a new object;
	/// this can be a Celestial Body or vessel;
	/// also triggered when switching to or loading a new vessel
	/// </summary>
	public static EventData<MapObject> onPlanetariumTargetChanged;
	/// <summary>
	/// Triggered when a ProgressNode and all of its subNodes are completed.
	/// 
	/// See also OnProgressReached and OnProgressComplete
	/// </summary>
	public static EventData<ProgressNode> OnProgressAchieved;
	/// <summary>
	/// Triggered when all sub ProgressNodes within a given ProgressNode are completed;
	/// records the UT of node completion and returns the ProgressNode
	/// 
	/// See the ProgressTracking module in the persistent.sfs file for more on how ProgressNodes
	/// are setup and saved.
	/// 
	/// If the ProgressNode is completed upon first achievement this will also trigger OnProgressReached.
	/// 
	/// See also OnProgressReached and OnProgressAchieved
	/// </summary>
	public static EventData<ProgressNode> OnProgressComplete;
	/// <summary>
	/// Triggered when a ProgressNode is first reached but not completed;
	/// records the UT of node achievement and returns the ProgressNode.
	/// 
	/// For instance, when a vessels first enters the SOI of a new Celestial Body
	/// the event will trigger and a "reached" entry will be added to the persistent.sfs file.
	/// 
	/// If a ProgressNode is completed at the same time it is reached (ie has no ProgressNode subNodes)
	/// OnProgressCompelete will be triggered at the same time
	/// 
	/// See the ProgressTracking module in the persistent.sfs file for more on how ProgressNodes
	/// are setup and saved.
	/// 
	/// See also OnProgressComplete and OnProgressAchieved
	/// </summary>
	public static EventData<ProgressNode> OnProgressReached;
	/// <summary>
	/// When reputation level changes; returns total rep amount
	/// </summary>
	public static EventData<float> OnReputationChanged;
	/// <summary>
	/// Triggered when reference frame changes (ie from inertial to rotating);
	/// this is generally accompanied by a shift in the camera position
	/// and a debug log message ("Reference Frame: Rotating/Inertial")
	/// </summary>
	public static EventData<GameEvents.HostTargetAction<CelestialBody, bool>> onRotatingFrameTransition;
	/// <summary>
	/// Triggered when two docking ports on the same vessel dock together
	/// </summary>
	public static EventData<GameEvents.FromToAction<ModuleDockingNode, ModuleDockingNode>> onSameVesselDock;
	/// <summary>
	/// Triggered when two docking ports on the same vessel undock
	/// </summary>
	public static EventData<GameEvents.FromToAction<ModuleDockingNode, ModuleDockingNode>> onSameVesselUndock;
	/// <summary>
	/// When science level changes; returns total science amount
	/// </summary>
	public static EventData<float> OnScienceChanged;
	/// <summary>
	/// Triggered science data is transmitted or recovered; returns the amount of science and the ScienceSubject
	/// </summary>
	public static EventData<float, ScienceSubject> OnScienceRecieved;
	/// <summary>
	/// Called when the player un-hides the UI by pressing F2. Register for this callback (and onHideUI)
	/// so that you can un-hide your UI too.
	/// </summary>
	public static EventVoid onShowUI;
	/// <summary>
	/// Triggered when engine exhaust damages another part
	/// </summary>
	public static EventData<EventReport> onSplashDamage;
	/// <summary>
	/// Triggered upon staging, returns the stage number
	/// </summary>
	public static EventData<int> onStageActivate;
	/// <summary>
	/// Triggered by decoupler staging;
	/// also triggered by separation through a decoupler's right-click menu event
	/// </summary>
	public static EventData<EventReport> onStageSeparation;
	/// <summary>
	/// Triggered when researching a tech node in the R&amp;D center;
	/// triggers whether or not you have enough science to unlock the node
	/// </summary>
	public static EventData<GameEvents.HostTargetAction<RDTech, RDTech.OperationResult>> OnTechnologyResearched;
	/// <summary>
	/// Triggered whenever timewarp rate changes; applies to physics and non-physics timewarp;
	/// triggered by the key press also (called even if you are at max/min timewarp already)
	/// </summary>
	public static EventVoid onTimeWarpRateChanged;
	/// <summary>
	/// Deprecated? Use onPartUndock
	/// </summary>
	public static EventData<EventReport> onUndock;
	/// <summary>
	/// Triggered when switching to a different vessel, loading a vessel, or launching
	/// </summary>
	public static EventData<Vessel> onVesselChange;
	/// <summary>
	/// Triggered when a vessel is launched, or created by undocking, decoupling, planting a flag, or EVA;
	/// also triggered by new asteroid creation and rescue Kerbal contracts
	/// </summary>
	public static EventData<Vessel> onVesselCreate;
	/// <summary>
	/// Triggered when a vessel instance is destroyed;
	/// any time a vessel is unloaded, ie scene changes, exiting loading distance
	/// </summary>
	public static EventData<Vessel> onVesselDestroy;
	/// <summary>
	/// Triggered when a vessel is loaded on the launchpad, when a vessel enters within loading distance,
	/// or when a vessel goes off of time warp
	/// </summary>
	public static EventData<Vessel> onVesselGoOffRails;
	/// <summary>
	/// Triggered when a vessel exits loading distance or enters time warp
	/// </summary>
	public static EventData<Vessel> onVesselGoOnRails;
	/// <summary>
	/// Triggered whenever a vessel's load method is called
	/// </summary>
	public static EventData<Vessel> onVesselLoaded;
	/// <summary>
	/// Triggered when a closed orbit is reached
	/// </summary>
	public static EventData<Vessel> onVesselOrbitClosed;
	/// <summary>
	/// Triggered when orbit eccentricity becomes > 1
	/// </summary>
	public static EventData<Vessel> onVesselOrbitEscaped;
	/// <summary>
	/// Triggered after a vessel has been recovered and the science data
	/// and part values have been accounted for;
	/// occurs in the space center or tracking station.
	/// 
	/// Triggered after onVesselRecoveryProcessing
	/// </summary>
	public static EventData<ProtoVessel> onVesselRecovered;
	/// <summary>
	/// Triggered in the space center or tracking station when a vessel is recovered;
	/// occurs before onVesselRecovered
	/// </summary>
	public static EventData<ProtoVessel, MissionRecoveryDialog, float> onVesselRecoveryProcessing;
	/// <summary>
	/// Triggered a vessel is recovered (the big green button at the top) from the flight scene
	/// </summary>
	public static EventData<Vessel> OnVesselRecoveryRequested;
	/// <summary>
	/// Returns old 'from' vessel name and new 'to' vessel name
	/// </summary>
	public static EventData<GameEvents.HostedFromToAction<Vessel, string>> onVesselRename;
	/// <summary>
	/// Triggered when vessel is loaded onto the launchpad from the editor/launch selection window;
	/// called after the transition to flight scene
	/// </summary>
	public static EventData<ShipConstruct> OnVesselRollout;
	/// <summary>
	/// Returns old and new vessel situations
	/// </summary>
	public static EventData<GameEvents.HostedFromToAction<Vessel, Vessel.Situations>> onVesselSituationChange;
	/// <summary>
	/// Returns old and new Celestial Body
	/// </summary>
	public static EventData<GameEvents.HostedFromToAction<Vessel, CelestialBody>> onVesselSOIChanged;
	/// <summary>
	/// Triggered when a vessel is deleted from the tracking station
	/// </summary>
	public static EventData<ProtoVessel> onVesselTerminated;
	/// <summary>
	/// Triggered when any aspect of a vessel changes;
	/// docking, undocking, decoupling, parts breaking, crash, etc...
	/// </summary>
	public static EventData<Vessel> onVesselWasModified;
	/// <summary>
	/// Triggered when a vessel crashes, or passes into the atmosphere;
	/// when an EVA Kerbal boards, or when an asteroid is despawned
	/// </summary>
	public static EventData<Vessel> onVesselWillDestroy;

	/// <summary>
	/// Game events related to contract status changes;
	/// the contract in question is returned as EventData for most events
	/// </summary>
	public static class Contract
	{
		/// <summary>
		/// Triggered when a contract is accepted through the mission control center
		/// </summary>
		public static EventData<Contracts.Contract> onAccepted;
		/// <summary>
		/// Triggered upon cancellation of an active contract through the mission control center
		/// </summary>
        public static EventData<Contracts.Contract> onCancelled;
		/// <summary>
		/// Triggered upon successful contract completion
		/// </summary>
        public static EventData<Contracts.Contract> onCompleted;
		/// <summary>
		/// Triggered when a new contract is offered, or a contract expires or completes
		/// </summary>
		public static EventVoid onContractsListChanged;
		/// <summary>
		/// Triggered by the ContractSystem Scenario Module loading existing contracts
		/// </summary>
		public static EventVoid onContractsLoaded;
		/// <summary>
		/// Triggered by declining an offered contract from the mission control center
		/// </summary>
        public static EventData<Contracts.Contract> onDeclined;
		/// <summary>
		/// Triggered when a contract fails for any reason
		/// </summary>
        public static EventData<Contracts.Contract> onFailed;
		/// <summary>
		/// Triggered when a contract finishes for any reason, success or failure
		/// </summary>
        public static EventData<Contracts.Contract> onFinished;
		/// <summary>
		/// Triggered when the contract is first offered in the mission control center
		/// </summary>
        public static EventData<Contracts.Contract> onOffered;
		/// <summary>
		/// Triggered whenever an individual contract parameter changes state;
		/// from Incomplete to complete for example
		/// </summary>
        public static EventData<Contracts.Contract, ContractParameter> onParameterChange;
	}

	/// <summary>
	/// Game events related to vessel situation changes;
	/// mostly related to progress tracking.
	/// 
	/// The Celestial Body in question and the vessel being
	/// used are returned as EventData in most cases
	/// </summary>
	public static class VesselSituation
	{
		/// <summary>
		/// Triggered upon escaping a celestial body's orbit;
		/// triggered by onVesselSOIChanged, not by simply attaining an escape trajectory
		/// </summary>
		public static EventData<Vessel, CelestialBody> onEscape;
		/// <summary>
		/// Triggered upon entering a new celestial bodies SOI, the inverse of onEscape;
		/// may not apply to the Sun, ie requires eccentricity > 1
		/// </summary>
		public static EventData<Vessel, CelestialBody> onFlyBy;
		/// <summary>
		/// Triggered upon landing or splashing down
		/// </summary>
		public static EventData<Vessel, CelestialBody> onLand;
		/// <summary>
		/// Triggered upon entering orbit;
		/// must be stable, with periapsis above the max atmospheric height and eccentricity &lt; 1
		/// </summary>
		public static EventData<Vessel, CelestialBody> onOrbit;
		/// <summary>
		/// Triggered the first time a sub-orbital situation is achieved
		/// </summary>
		public static EventData<Vessel> onReachSpace;
		/// <summary>
		/// Triggered when landing on Kerbin after a flyby or orbiting a Celestial Body
		/// </summary>
		public static EventData<Vessel, CelestialBody> onReturnFromOrbit;
		/// <summary>
		/// Triggered when landing on Kerbin after landing on a Celestial Body
		/// </summary>
		public static EventData<Vessel, CelestialBody> onReturnFromSurface;
	}

	/// <summary>
	/// Used by onPartExplode
	/// </summary>
	public struct ExplosionReaction
	{
		/// <summary>
		/// The distance between the exploding part and the active vessel
		/// </summary>
		public float distance;
		/// <summary>
		/// Some explosion magnitude variable; related to fuel content of the exploding part
		/// </summary>
		public float magnitude;

		public extern ExplosionReaction(float distance, float magnitude);
	}

	/// <summary>
	/// Two objects; of the same type in all stock uses.
	/// 
	/// See onPartCouple for an example
	/// </summary>
	/// <typeparam name="A">The "originating" object</typeparam>
	/// <typeparam name="B">The "target" object</typeparam>
	public struct FromToAction<A, B>
	{
		public A from;
		public B to;

		public extern FromToAction(A from, B to);
	}

	/// <summary>
	/// Two potentially different object types;
	/// the From/To object (B) returns two values, generally the old and new.
	/// 
	/// See onVesselSOIChanged for an example
	/// </summary>
	/// <typeparam name="A">Host object</typeparam>
	/// <typeparam name="B">From/To Object</typeparam>
	public struct HostedFromToAction<A, B>
	{
		public B from;
		public A host;
		public B to;

        public extern HostedFromToAction(A host, B from, B to);
	}

	/// <summary>
	/// Two objects of the same or different type;
	/// used generally in a manner similar to FromToAction.
	/// 
	/// See OnTechnologyResearched for an example
	/// </summary>
	/// <typeparam name="A">Host object</typeparam>
	/// <typeparam name="B">Target object</typeparam>
	public struct HostTargetAction<A, B>
	{
		public A host;
		public B target;

        public extern HostTargetAction(A host, B target);
	}

	/// <summary>
	/// Used by onGUILaunchScreenSpawn
	/// 
	/// Exposes information on saved .craft files
	/// </summary>
	public struct VesselSpawnInfo
	{
		public string craftSubfolder;
		public VesselSpawnDialog.CraftSelectedCallback OnFileSelected;
		public string profileName;

        public extern VesselSpawnInfo(string craftSubfolder, string profileName, VesselSpawnDialog.CraftSelectedCallback OnFileSelected);
	}
}
