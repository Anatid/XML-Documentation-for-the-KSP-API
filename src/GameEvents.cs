#region Assembly Assembly-CSharp.dll, v1.0.0.0
// C:\greg\ksp\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

public static class GameEvents
{
    public static bool debugEvents;
    public static EventData<Vessel> onActiveJointNeedUpdate;
    public static EventData<EventReport> onCollision;
    public static EventData<EventReport> onCrash;
    public static EventData<EventReport> onCrashSplashdown;
    public static EventData<GameEvents.FromToAction<Part, Part>> onCrewBoardVessel;
    public static EventData<EventReport> onCrewKilled;
    public static EventData<GameEvents.FromToAction<Part, Part>> onCrewOnEva;
    public static EventData<GameEvents.FromToAction<CelestialBody, CelestialBody>> onDominantBodyChange;
    public static EventData<ShipConstruct> onEditorShipModified;
    public static EventData<Vessel> onFlagPlant;
    public static EventData<string> onFlagSelect;
    public static EventVoid onFlightReady;
    public static EventData<Vector3d> onFloatingOriginShift;
    public static EventData<double> OnFundsChanged;
    public static EventVoid onGamePause;
    public static EventData<GameScenes> onGameSceneLoadRequested;
    public static EventVoid OnGameSettingsApplied;
    public static EventData<Game> onGameStateCreated;
    public static EventData<ConfigNode> onGameStateLoad;
    public static EventData<ConfigNode> onGameStateSave;
    public static EventData<Game> onGameStateSaved;
    public static EventVoid onGameUnpause;
    public static EventVoid onGUIApplicationLauncherDestroyed;
    public static EventVoid onGUIApplicationLauncherReady;
    public static EventVoid onGUIAstronautComplexDespawn;
    public static EventVoid onGUIAstronautComplexSpawn;
    public static EventVoid onGUILaunchScreenDespawn;
    public static EventData<GameEvents.VesselSpawnInfo> onGUILaunchScreenSpawn;
    public static EventData<ShipTemplate> onGUILaunchScreenVesselSelected;
    public static EventVoid onGUIMessageSystemReady;
    public static EventVoid onGUIMissionControlDespawn;
    public static EventVoid onGUIMissionControlSpawn;
    public static EventVoid onGUIPrefabLauncherReady;
    public static EventData<MissionRecoveryDialog> onGUIRecoveryDialogDespawn;
    public static EventData<MissionRecoveryDialog> onGUIRecoveryDialogSpawn;
    public static EventVoid onGUIRnDComplexDespawn;
    public static EventVoid onGUIRnDComplexSpawn;
    public static EventVoid onHideUI;
    public static EventData<GameEvents.FromToAction<ControlTypes, ControlTypes>> onInputLocksModified;
    public static EventData<EventReport> onJointBreak;
    public static EventData<ProtoCrewMember> onKerbalAdded;
    public static EventData<ProtoCrewMember> onKerbalRemoved;
    public static EventData<ProtoCrewMember, ProtoCrewMember.RosterStatus, ProtoCrewMember.RosterStatus> onKerbalStatusChange;
    public static EventData<ProtoCrewMember, ProtoCrewMember.KerbalType, ProtoCrewMember.KerbalType> onKerbalTypeChange;
    public static EventData<GameEvents.HostedFromToAction<IDiscoverable, DiscoveryLevels>> onKnowledgeChanged;
    public static EventData<Vector3d> onKrakensbaneDisengage;
    public static EventData<Vector3d> onKrakensbaneEngage;
    public static EventData<EventReport> onLaunch;
    public static EventData<GameScenes> onLevelWasLoaded;
    public static EventData<string> onMissionFlagSelect;
    public static EventData<Vessel> onNewVesselCreated;
    public static EventData<EventReport> onOverheat;
    public static EventData<Part> onPartActionUICreate;
    public static EventData<Part> onPartActionUIDismiss;
    public static EventData<GameEvents.HostTargetAction<Part, Part>> onPartAttach;
    /// <summary>
    /// Called on docking. Passes your event handler a FromToAction&lt;Part, Part&gt; ev.
    /// ev.from and ev.to are the two parts (docking nodes) that have been coupled together.
    /// Actually this event fires twice on docking, with ev.from and ev.to swapped the second time.
    /// </summary>
    public static EventData<GameEvents.FromToAction<Part, Part>> onPartCouple;
    public static EventData<Part> onPartDestroyed;
    public static EventData<Part> onPartDie;
    public static EventData<GameEvents.ExplosionReaction> onPartExplode;
    public static EventData<PartJoint> onPartJointBreak;
    public static EventData<Part> onPartPack;
    public static EventData<AvailablePart> OnPartPurchased;
    public static EventData<GameEvents.HostTargetAction<Part, Part>> onPartRemove;
    public static EventData<Part> onPartUndock;
    public static EventData<Part> onPartUnpack;
    public static EventData<MapObject> onPlanetariumTargetChanged;
    public static EventData<ProgressNode> OnProgressAchieved;
    public static EventData<ProgressNode> OnProgressComplete;
    public static EventData<ProgressNode> OnProgressReached;
    public static EventData<float> OnReputationChanged;
    public static EventData<GameEvents.HostTargetAction<CelestialBody, bool>> onRotatingFrameTransition;
    public static EventData<GameEvents.FromToAction<ModuleDockingNode, ModuleDockingNode>> onSameVesselDock;
    public static EventData<GameEvents.FromToAction<ModuleDockingNode, ModuleDockingNode>> onSameVesselUndock;
    public static EventData<float> OnScienceChanged;
    public static EventData<float, ScienceSubject> OnScienceRecieved;
    public static EventVoid onShowUI;
    public static EventData<EventReport> onSplashDamage;
    public static EventData<int> onStageActivate;
    public static EventData<EventReport> onStageSeparation;
    public static EventData<GameEvents.HostTargetAction<RDTech, RDTech.OperationResult>> OnTechnologyResearched;
    public static EventVoid onTimeWarpRateChanged;
    public static EventData<EventReport> onUndock;
    public static EventData<Vessel> onVesselChange;
    public static EventData<Vessel> onVesselCreate;
    public static EventData<Vessel> onVesselDestroy;
    public static EventData<Vessel> onVesselGoOffRails;
    public static EventData<Vessel> onVesselGoOnRails;
    public static EventData<Vessel> onVesselLoaded;
    public static EventData<Vessel> onVesselOrbitClosed;
    public static EventData<Vessel> onVesselOrbitEscaped;
    public static EventData<ProtoVessel> onVesselRecovered;
    public static EventData<ProtoVessel, MissionRecoveryDialog, float> onVesselRecoveryProcessing;
    public static EventData<Vessel> OnVesselRecoveryRequested;
    public static EventData<GameEvents.HostedFromToAction<Vessel, string>> onVesselRename;
    public static EventData<ShipConstruct> OnVesselRollout;
    public static EventData<GameEvents.HostedFromToAction<Vessel, Vessel.Situations>> onVesselSituationChange;
    public static EventData<GameEvents.HostedFromToAction<Vessel, CelestialBody>> onVesselSOIChanged;
    public static EventData<ProtoVessel> onVesselTerminated;
    public static EventData<Vessel> onVesselWasModified;
    public static EventData<Vessel> onVesselWillDestroy;

    public static class Contract
    {
        public static EventData<Contracts.Contract> onAccepted;
        public static EventData<Contracts.Contract> onCancelled;
        public static EventData<Contracts.Contract> onCompleted;
        public static EventVoid onContractsListChanged;
        public static EventVoid onContractsLoaded;
        public static EventData<Contracts.Contract> onDeclined;
        public static EventData<Contracts.Contract> onFailed;
        public static EventData<Contracts.Contract> onFinished;
        public static EventData<Contracts.Contract> onOffered;
        public static EventData<Contracts.Contract, Contracts.ContractParameter> onParameterChange;
    }

    public static class VesselSituation
    {
        public static EventData<Vessel, CelestialBody> onEscape;
        public static EventData<Vessel, CelestialBody> onFlyBy;
        public static EventData<Vessel, CelestialBody> onLand;
        public static EventData<Vessel, CelestialBody> onOrbit;
        public static EventData<Vessel> onReachSpace;
        public static EventData<Vessel, CelestialBody> onReturnFromOrbit;
        public static EventData<Vessel, CelestialBody> onReturnFromSurface;
    }

    public struct ExplosionReaction
    {
        public float distance;
        public float magnitude;

        public extern ExplosionReaction(float distance, float magnitude);
    }

    public struct FromToAction<A, B>
    {
        public A from;
        public B to;

        public extern FromToAction(A from, B to);
    }

    public struct HostedFromToAction<A, B>
    {
        public B from;
        public A host;
        public B to;

        public extern HostedFromToAction(A host, B from, B to);
    }

    public struct HostTargetAction<A, B>
    {
        public A host;
        public B target;

        public extern HostTargetAction(A host, B target);
    }

    public struct VesselSpawnInfo
    {
        public string craftSubfolder;
        public VesselSpawnDialog.CraftSelectedCallback OnFileSelected;
        public string profileName;

        public extern VesselSpawnInfo(string craftSubfolder, string profileName, VesselSpawnDialog.CraftSelectedCallback OnFileSelected);
    }
}
