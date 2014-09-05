using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

/// <summary>
/// A Vessel object represents a single vessel. Parts that break off from a vessel become their own Vessels. Vessels that merge
/// via docking become one Vessel.
/// </summary>
public class Vessel /*: MonoBehaviour, ITargetable, IShipconstruct, IDiscoverable*/
{
    /// <summary>
    /// Presumably, this is the current acceleration vector of the vessel, in m/s^2?
    /// </summary>
    public Vector3d acceleration;
    /// <summary>
    /// Presumably, this is the current altitude above sea of the vessel, in meters?
    /// Is equal to pqsAltitude + heightFromTerrain (where heightFromTerrain is not -1).
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
    /// <summary>
    /// The set of flight inputs currently being fed to the vessel. For example the current
    /// throttle being applied to the vesesl is vessel.ctrlState.mainThrottle.
    /// </summary>
    public FlightCtrlState ctrlState;
    /// <summary>
    /// Presumably, the current stage of the vessel as seen e.g. in the staging display
    /// </summary>
    public int currentStage;
    public FlightIntegrator flightIntegrator;
    public double geeForce;
    public double geeForce_immediate;
    /// <summary>
    /// Appears to always be -1?
    /// </summary>
    public float heightFromSurface;
    /// <summary>
    /// The vertical distance in meters between the vessel and the nearest terrain (including buildings), 
    /// or -1 when sea depth is greater than 600m (terrainAltitude &lt;= -600).
    /// </summary>
    public float heightFromTerrain;
    /// <summary>
    /// Presumably, the horizontal component of srf_velocity, in m/s.
    /// </summary>
    public double horizontalSrfSpeed;
    /// <summary>
    /// A unique identifier assigned to a vessel. When two vessels dock, the combined vessel has the id of the vessel docked to.
    /// On undock, the vessel undocked from keeps its id, the vessel that undocks gets a new id. 
    /// Note that this id is always fresh, a vessel gets a different id when it undocks then it had before docking.
    /// This is the pid value in the persistent.sfs at the VESSEL level.
    /// </summary>
    public Guid id;
    /// <summary>
    /// Presumably, whether this vessel is an EVAing kerbal.
    /// </summary>
    public bool isEVA;
    /// <summary>
    /// Whether the vessel is currently sitting on the ground.
    /// </summary>
    public bool Landed;
    public string landedAt;
    /// <summary>
    /// The current latitude of the vessel over the current mainBody, in degrees.
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
    /// <summary>
    /// The current longitude of the vessel over the current mainBody, in degrees
    /// </summary>
    public double longitude;
    /// <summary>
    /// Mission elapsed time, in seconds, maybe?
    /// </summary>
    public double missionTime;
    public Vector3 MOI;
    /// <summary>
    /// The current velocity of the vessel, in world coordinates, in the nonrotating inertial reference frame.
    /// </summary>
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
    /// <summary>
    /// Presumably, the height in meters of the planet's terrain QuadSphere directly under the vessel, compared to sea level.
    /// This does not take the height of buildings into account. It is generally within +/- 1m of terrainAltitude, 
    /// except when over buildings (terrainAltitude does account for buildings) or sea with a depth of greater
    /// than 600m (terrainAltitude &lt;= -600, heightFromTerrain == -1).
    /// </summary>
    public double pqsAltitude;
    /// <summary>
    /// The protoVessel can be used to get some saved information about unloaded vessels.
    /// </summary>
    public ProtoVessel protoVessel;
    public Vector3 rb_velocity;
    /// <summary>
    /// This is the flightID of the part that is the current 'Control from Here' part.
    /// This is the root part until changed by the player.
    /// The vessel transform is set to the transform of this part.
    /// This is the 'ref' value in the persistent.sfs at the VESSEL level.
    /// </summary>
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
    /// The velocity of the vessel in the "surface" reference frame, the reference frame that rotates with the planet.
    /// </summary>
    public Vector3d srf_velocity;
    public Quaternion srfRelRotation;
    public Vessel.State state;
    /// <summary>
    /// Presumably, the atmospheric pressure at the vessel's current location.
    /// </summary>
    public double staticPressure;
    /// <summary>
    /// The height in meters of the nearest terrain (including buildings) directly under the vessel, compared to sea level.
    /// Ground which is underwater will have a negative terrainAltitude.
    /// </summary>
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
    /// <summary>Describes to what extent this object has been explored</summary>
    public extern DiscoveryInfo DiscoveryInfo { get; }
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
    /// Get a part by its index, in some order.
    /// </summary>
    /// <param name="index">Index of the part to get.</param>
    /// <returns>The "index"th part in the vessel.</returns>
    public extern Part this[int index] { get; }
    /// <summary>
    /// Get a part by its part.flightID value
    /// </summary>
    /// <param name="flightID">The flightID value of some part in the vessel</param>
    /// <returns>The matching part, or null if there is  no part with that flightID.</returns>
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
	/// <summary>
    /// Broken Function with expensive runtime. Do not use. (If it worked it'd do as the name says but it doesn't as of 0.23.5)
    /// </summary>
    /// <returns></returns>
    public extern Vector3 findLocalCenterOfPressure();
    public extern Vector3 findLocalMOI();
    /// <summary>Returns the vessel's moment of inertia around its center of mass.</summary>
    /// <warning>Returns nonsense answers; DO NOT USE</warning>
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
    /// <summary>
    /// Gets the transform of the part the vessel is being controlled from (i.e., the part
    /// set by the "control from here" right click option).
    /// </summary>
    /// <returns></returns>
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

    /// <summary>Returns the vessel's altitude above the reference sphere of 
    ///		the CelestialBody it orbits</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern double RevealAltitude();

    /// <summary>Returns the vessel's mass, in tons</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern float RevealMass();

    /// <summary>Returns the vessel's tracking station name</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealName();

    /// <summary>Describes the state of the vessel</summary>
    ///
    /// <returns>A string containing the sphere of influence and trajectory of the object</returns>
    /// 
    /// <example>"Orbiting the Sun"</example>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealSituationString();

    /// <summary>Returns the vessel's speed</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern double RevealSpeed();

    /// <summary>Returns the type of the vessel</summary>
    ///
    /// <returns>A string representation of vesselType</returns>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealType();

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
