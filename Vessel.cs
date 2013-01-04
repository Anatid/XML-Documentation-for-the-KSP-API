#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Vessel : MonoBehaviour
{
    /// <summary>
    /// Presumably, this is the current acceleration vector of the vessel, in m/s^2?
    /// </summary>
    public Vector3d acceleration;
    /// <summary>
    /// Presumably, this is the current altitude above sea of the vessel, in meters?
    /// </summary>
    public double altitude;
    /// <summary>
    /// Presumably, this is the current angular momentum of the vessel?
    /// </summary>
    public Vector3 angularMomentum;
    /// <summary>
    /// The current angular velocity vector of the vessel.
    /// </summary>
    public Vector3 angularVelocity;
    /// <summary>
    /// Presumably, this is the current density of the atmosphere at the vessel's position?
    /// </summary>
    public double atmDensity;
    /// <summary>
    /// Presumably, this is the position of the center of mass of the vessel?
    /// </summary>
    public Vector3 CoM;
    public FlightCtrlState ctrlState;
    /// <summary>
    /// Presumably, the current stage of the vessel as seen e.g. in the staging display
    /// </summary>
    public int currentStage;
    public FlightIntegrator flightIntegrator;
    public double geeForce;
    public double geeForce_immediate;
    public float heightFromSurface;
    public float heightFromTerrain;
    public double horizontalSrfSpeed;
    public Guid id;
    /// <summary>
    /// Presumably, which this vessel is an EVAing kerbal.
    /// </summary>
    public bool isEVA;
    /// <summary>
    /// Whether the vessel is currently sitting on the ground.
    /// </summary>
    public bool Landed;
    public string landedAt;
    /// <summary>
    /// Presumably, the current latitude of the vessel in degrees.
    /// </summary>
    public double latitude;
    /// <summary>
    /// The universal time at which the vessel was launched, in seconds?
    /// </summary>
    public double launchTime;
    public static float loadDistance;
    /// <summary>
    /// Whether the vessel is currently loaded. Vessels are only loaded when they come
    /// within about 2.5km of the active vessel.
    /// </summary>
    public bool loaded;
    public Vector3 localCoM;
    public double longitude;
    public double missionTime;
    public Vector3 MOI;
    public Vector3d obt_velocity;
    /// <summary>
    /// You can add your own function to this callback to register a function that can provide flight control input
    /// to the vessel. Once you've registered this callback, it will be called once per FixedUpdate. Provide flight
    /// control input by modifying the FlightCtrlState passed to your function. This FlightCtrlState will already
    /// contain the player's input, which you can modify or override as desired.
    /// </summary>
    /// <example>
    /// <code>
    /// void MyAutopilotFunction(FlightCtrlState s) {
    ///   s.yaw = 1;
    /// }
    /// ...
    /// vessel.OnFlyByWire += MyAutopilotFunction
    /// </code>
    /// This will create an autopilot that always yaws hard to the right. You can probably devise something more useful, though...
    /// </example>
    public FlightInputCallback OnFlyByWire;
    /// <summary>
    /// You can add a function to this callback, and the function will be called when the vessel is "just about to be destroyed."
    /// </summary>
    public Callback OnJustAboutToBeDestroyed;
    public OrbitDriver orbitDriver;
    public OrbitTargeter orbitTargeter;
    /// <summary>
    /// Whether the vessel is currently packed. Vessels are only packed when the come within about 300m of the active vessel.
    /// </summary>
    public bool packed;
    /// <summary>
    /// A list of the parts in the vessel. Note that when the vessel is not loaded, this list will be empty.
    /// </summary>
    public List<Part> parts;
    public PatchedConicRenderer patchedConicRenderer;
    /// <summary>
    /// Among other things, the patchedConicSolver stores information about the player's current set of maneuver nodes.
    /// </summary>
    public PatchedConicSolver patchedConicSolver;
    public Vector3d perturbation;
    public double pqsAltitude;
    /// <summary>
    /// The protoVessel can be used to get some saved information about unloaded vessels.
    /// </summary>
    public ProtoVessel protoVessel;
    public Vector3 rb_velocity;
    public uint referenceTransformId;
    /// <summary>
    /// The root of the tree of parts that comprises the vessel. Usually this is the original command pod placed when constructing the vessel.
    /// </summary>
    public Part rootPart;
    /// <summary>
    /// Some coarse information about the current state of the vessel.
    /// </summary>
    public Vessel.Situations situation;
    public double specificAcceleration;
    /// <summary>
    /// Whether the vessel is currently splashed down.
    /// </summary>
    public bool Splashed;
    /// <summary>
    /// Presumably, the velocity of the vessel in the "surface" reference frame.
    /// </summary>
    public Vector3d srf_velocity;
    public Quaternion srfRelRotation;
    public Vessel.State state;
    /// <summary>
    /// Presumably, the atmospheric pressure at the vessel's current location.
    /// </summary>
    public double staticPressure;
    public double terrainAltitude;
    public Vector3 terrainNormal;
    public static float unloadDistance;
    /// <summary>
    /// Presumably, a unit vector in the up (radially outward from the planet) direction.
    /// </summary>
    public Vector3d upAxis;
    /// <summary>
    /// Presumably, the vertical speed of the vessel in m/s.
    /// </summary>
    public double verticalSpeed;
    /// <summary>
    /// The name of the vessel as it appears in e.g. the tracking station.
    /// </summary>
    public string vesselName;
    /// <summary>
    /// The type of the vessel, as shown by the type of icon on the map view.
    /// </summary>
    public VesselType vesselType;

    public extern Vessel();

    public extern ActionGroupList ActionGroups { get; }
    public extern bool HoldPhysics { get; }
    /// <summary>
    /// Whether the player is currently controlling this vessel.
    /// </summary>
    public extern bool isActiveVessel { get; }
    public extern bool isCommandable { get; }
    public extern bool IsControllable { get; }
    public extern bool isPersistent { get; set; }
    /// <summary>
    /// Landed || Splashed; use this to determined whether the vessel is on the ground somewhere, whether on land or water.
    /// </summary>
    public extern bool LandedOrSplashed { get; }
    /// <summary>
    /// The body whose sphere of influence the vessel is currently in.
    /// </summary>
    public extern CelestialBody mainBody { get; }
    /// <summary>
    /// The current orbit of the vessel. 
    /// </summary>
    public extern Orbit orbit { get; }
    /// <summary>
    /// A list of the parts this vessel is composed of.
    /// </summary>
    public extern List<Part> Parts { get; }
    public extern Transform ReferenceTransform { get; }

    /// <summary>
    /// Presumably, this lets you access the vessel's parts by index.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public extern Part this[int index] { get; }
    public extern Part this[uint flightID] { get; }

    public extern ProtoVessel BackupVessel();
    /// <summary>
    /// Add a given velocity offset to the vessels current velocity, instantaneously (may only work for loaded vessels?)
    /// </summary>
    /// <param name="velOffset"></param>
    public extern void ChangeWorldVelocity(Vector3d velOffset);
    public extern bool checkLanded();
    public extern bool checkSplashed();
    public extern bool checkVisibility();
    public extern void ClearStaging();
    public extern void DespawnCrew();
    public extern void DestroyVesselComponents();
    public extern void Die();
    public extern void FallBackReferenceTransform();
    public extern void FeedInputFeed();
    public extern VesselType FindDefaultVesselType();
    public extern Vector3 findLocalCenterOfMass();
    public extern Vector3 findLocalCenterOfPressure();
    public extern Vector3 findLocalMOI();
    public extern Vector3 findLocalMOI(Vector3 worldCoM);
    /// <summary>
    /// Computes and returns the position of the center of mass of the vessel, in world coordinates.
    /// </summary>
    /// <returns></returns>
    public extern Vector3 findWorldCenterOfMass();
    public extern List<Part> GetActiveParts();
    public extern int GetCrewCapacity();
    /// <summary>
    /// The number of kerbals inside the vessel. This is ONLY reliable when the vessel is loaded (vessel.loaded == true). 
    /// When the vessel is unloaded you can compute the crew count as 
    /// <code>vessel.protoVessel.protoPartSnapshots.Sum(pps => pps.protoModuleCrew.Count))</code>
    /// </summary>
    /// <returns></returns>
    public extern int GetCrewCount();
    public extern Vector3 GetFwdVector();
    public extern float GetHeightFromSurface();
    public extern float GetHeightFromTerrain();
    public extern static string GetMETString(Vessel v);
    public extern string GetName();
    public extern Vector3 GetObtVelocity();
    public extern Orbit GetOrbit();
    public extern OrbitDriver GetOrbitDriver();
    public extern static string GetSituationString(Vessel v);
    public extern Vector3 GetSrfVelocity();
    public extern float GetTotalMass();
    public extern Transform GetTransform();
    public extern Vessel GetVessel();
    public extern List<ProtoCrewMember> GetVesselCrew();
    public extern Vector3d GetWorldPos3D();
    /// <summary>
    /// Pulls the vessel off rails?
    /// </summary>
    public extern void GoOffRails();
    /// <summary>
    /// Puts the vessel on rails?
    /// </summary>
    public extern void GoOnRails();
    public extern bool HasControlSources();
    public extern void Initialize(bool fromShipAssembly = false);
    public extern ClearToSaveStatus IsClearToSave();
    public extern static bool IsValidVesselName(string name);
    [ContextMenu("Load")]
    public extern void Load();
    public extern void MakeActive();
    public extern void MakeInactive();
    public extern void OnDestroy();
    public extern void OnLoadFlightState(Dictionary<string, KSPParseable> dataPool);
    public extern void OnSaveFlightState(Dictionary<string, KSPParseable> dataPool);
    [ContextMenu("Print All Collisions")]
    public extern void printCollisions();
    [ContextMenu("Print Ground Contacts")]
    public extern void printGroundContacts();
    [ContextMenu("Rename Vessel")]
    public extern void RenameVessel();
    [ContextMenu("Reset Collision Ignores")]
    public extern void ResetCollisionIgnores();
    public extern void ResumeStaging();
    public extern void SetActiveInternalPart();
    public extern void SetActiveInternalPart(List<Part> visibleParts);
    public extern void SetActiveInternalPart(Part visiblePart);
    public extern void SetPosition(Vector3 position);
    public extern void SetPosition(Vector3 position, bool usePristineCoords);
    public extern void SetReferenceTransform(Part p);
    public extern void SetReferenceTransform(Transform t);
    public extern void SetRotation(Quaternion rotation);
    /// <summary>
    /// Sets the velocity of the vessel to a new value, instantaneously. May only work for loaded vessels?
    /// </summary>
    /// <param name="vel"></param>
    public extern void SetWorldVelocity(Vector3d vel);
    public extern void SpawnCrew();
    public extern void StartFromBackup(ProtoVessel pv);
    public extern void Translate(Vector3 offset);
    [ContextMenu("Unload")]
    public extern void Unload();

    /// <summary>
    /// The type of Vessel.situation
    /// </summary>
    public enum Situations
    {
        LANDED = 0,
        SPLASHED = 1,
        /// <summary>
        /// Waiting on the launchpad, ready to be launched
        /// </summary>
        PRELAUNCH = 2,
        FLYING = 3,
        /// <summary>
        /// On a collision course with the ground
        /// </summary>
        SUB_ORBITAL = 4,
        ORBITING = 5,
        /// <summary>
        /// On a hyperbolic trajectory
        /// </summary>
        ESCAPING = 6,
        DOCKED = 7,
    }

    public enum State
    {
        INACTIVE = 0,
        ACTIVE = 1,
        DEAD = 2,
    }
}
