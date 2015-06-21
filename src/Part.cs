#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

/// <summary>
/// Each part on a vessel is represented by a Part object. Plugins can add new functionality to parts by defining new
/// PartModules, which can then be added to Parts. It is also possible to define new subclasses of Part, but this
/// is deprecated in favor of PartModules.
/// </summary>
public class Part : MonoBehaviour
{
    /// <summary>
    /// Whether this part will actually activate if it schedule to be activated in the same stage as it 
    /// is decoupled from the rocket. In particular, sepratrons must have ActivatesEvenIfDisconnected set
    /// to true if they are to function properly.
    /// </summary>
    public bool ActivatesEvenIfDisconnected;
    public Transform airlock;
    public float angularDrag;
    protected bool attached;
    public Joint attachJoint;
    public AttachNodeMethod attachMethod;
    /// <summary>
    /// Whether this part is attached to its parent via a stack AttachNode or a surface AttachNode.
    /// </summary>
    public AttachModes attachMode;
    /// <summary>
    /// An AttachNode represents the link between two attached parts. attachNodes is a list of possible nodes to
    /// which other parts can be attached to this part. You can find the parts that actually are attached using
    /// AttachNode.attachedPart. 
    /// </summary>
    public List<AttachNode> attachNodes;
    public AttachRules attachRules;
    public Quaternion attRotation;
    public float breakingForce;
    public float breakingTorque;
    public float buoyancy;
    public Vector3 CenterOfBuoyancy;
    /// <summary>
    /// The parts that are children of this part in the part tree (parts that were attached to this part in the editor
    /// after this part was already part of the vessel).
    /// </summary>
    public List<Part> children;
    public int childStageOffset;
    public Collider collider;
    public CollisionEnhancer collisionEnhancer;
    public Vector3 CoMOffset;
    protected bool connected;
    public float crashTolerance;
    /// <summary>
    /// How many crew members this part can fit.
    /// </summary>
    public int CrewCapacity;
    public List<Collider> currentCollisions;
    public string customPartData;
    public static Color defaultHighlightNone;
    public static Color defaultHighlightPart;
    public int defaultInverseStage;
    /// <summary>
    /// Unused?
    /// </summary>
    public Part.DragModel dragModel;
    /// <summary>
    /// Unused?
    /// </summary>
    public string dragModelType;
    public Vector3 dragReferenceVector;
    public double dynamicPressureAtm;
    public Part editorCollision;
    public List<Part> editorLinks;
    public float explosionPotential;
    /// <summary>
    /// A unique identifider for this part. Note that despite the name, each part on the same vessel will still have a different value in this field.
    /// This value is persistent and not affected by game load or docking/undocking or similar.
    /// This is the 'uid' value at the PART level of the persistent.sfs file.
    /// </summary>
    public uint flightID;
    public FlightIntegrator flightIntegrator;
    public bool frozen;
    /// <summary>
    /// Whether this part allows fuel crossfeed.
    /// </summary>
    public bool fuelCrossFeed;
    /// <summary>
    /// In the flight scene, fuelLookupTargets is the list of fuel lines through
    /// which this part can draw fuel. Also if this part is a docking node docked
    /// to a another docking node through which it can draw fuel, then the attached
    /// docking node will also be in fuelLookupTargets.
    /// </summary>
    public List<Part> fuelLookupTargets;
    public static uint fuelRequestID;
    public List<FXGroup> fxGroups;
    public bool GroundContact;
    public bool hasHeiarchyModel;
    protected float heatConductivity;
    protected float heatDissipation;
    public Color highlightColor;
    public bool highlightRecurse;
    public Part.HighlightType highlightType;
    public string initialVesselName;
    public int inStageIndex;
    public InternalModel internalModel;
    public string InternalModelName;
    /// <summary>
    /// The stage in which this part will activate, as shown in the staging display. (Possibly called inverseStage
    /// because the stages in KSP count down instead of up).
    /// </summary>
    public int inverseStage;
    public bool isClone;
    public bool isControlSource;
    public bool isMirrored;
    public bool isPersistent;
    public uint lastFuelRequestId;
    public int manualStageOffset;
    /// <summary>
    /// The DRY mass of this part, not including the mass of any resources it contains
    /// </summary>
    public float mass;
    /// <summary>
    /// The drag coefficient of this part is equal to (total mass) * (maximum_drag)
    /// </summary>
    public float maximum_drag;
    /// <summary>
    /// The temperature at which this part will explode.
    /// </summary>
    public float maxTemp;
    /// <summary>
    /// Unused.
    /// </summary>
    public float minimum_drag;
    public Vector3 mirrorAxis;
    public Vector3 mirrorRefAxis;
    public Vector3 mirrorVector;
    /// <summary>
    /// A unique identifier assigned to the part when the vessel it is a part of is created.
    /// All parts on the vessel get the same missionID and it does not change.
    /// Splitting a vessel with a decoupler will result with two vessels whose parts have the same missionID.
    /// When two vessels spawned seperately dock, each part keeps its original missionID, undocking does not change this field either.
    /// </summary>
    public uint missionID;
    /// <summary>
    /// Specifies the name of a node through which this part will NOT draw resources. See the part.cfg of the 
    /// stock tricoupler for an example of using this to prevent fuel from flowing backwards.
    /// </summary>
    public string NoCrossFeedNodeKey;
    /// <summary>
    /// Add a function to this callback and it will be called when your part is attached to another part in the editor.
    /// </summary>
    public Callback OnEditorAttach;
    /// <summary>
    /// Add a function to this callback and it will be called when your part is deleted in the editor.
    /// </summary>
    public Callback OnEditorDestroy;
    /// <summary>
    /// Add a function to this callback and it will be called when your part is detached, or is part of a set of parts
    /// that are detached, in the editor.
    /// </summary>
    public Callback OnEditorDetach;
    /// <summary>
    /// Add a function to this callback and it will be called when your part is about to be destroyed during flight.
    /// </summary>
    public Callback OnJustAboutToBeDestroyed;
    public Vector3 orgPos;
    public Quaternion orgRot;
    public int originalStage;
    public bool packed;
    /// <summary>
    /// The parent of this part in the part tree: the part to which this part was attached in the editor.
    /// </summary>
    public Part parent;
    public PartBuoyancy partBuoyancy;
    /// <summary>
    /// Some of the part info that is displayed about this part in the editor.
    /// </summary>
    public AvailablePart partInfo;
    public string partName;
    /// <summary>
    /// If physicalSignificance == Part.PhysicalSignificance.NONE, then this part doesn't actually
    /// have any physics. In particular, it has no mass, regardless of what its "mass" field is set to, and no drag.
    /// </summary>
    public Part.PhysicalSignificance physicalSignificance;
    /// <summary>
    /// Unused?
    /// </summary>
    public int PhysicsSignificance;
    public Part potentialParent;
    public List<ProtoCrewMember> protoModuleCrew;
    // commented out to fix build error: public ProtoPart protoPartRef;
    public ProtoPartSnapshot protoPartSnapshot;
    public float rescaleFactor;
    protected List<Part> resourceTargets;
    public PartStates ResumeState;
    public float scaleFactor;
    /// <summary>
    /// IF this part is surface-attached to its parent, srfAttachNode is the attach node describing this connection.
    /// </summary>
    public AttachNode srfAttachNode;
    /// <summary>
    /// The sicon shown for this part in the staging display.
    /// </summary>
    public VStackIcon stackIcon;
    public StackIconGrouping stackIconGrouping;
    public int stackSymmetry;
    public bool stageAfter;
    public bool stageBefore;
    public int stageOffset;
    public string stagingIcon;
    public bool started;
    protected PartStates state;
    public double staticPressureAtm;
    public Vector3 surfaceAreas;
    public List<Part> symmetryCounterparts;
    public int symmetryMode;
    /// <summary>
    /// The temperature of this part, in some arbitrary units.
    /// </summary>
    public float temperature;
    public PQS_PartCollider terrainCollider;
    public AttachNode topNode;
    /// <summary>
    /// The purpose of uid is unknown. It changes everytime a vessel is swithched to, even within the same flight scene. 
    /// Swith to a nearby vessel and back with [ and ] and the uid of the parts on a vessel will change.
    /// This value does not save to persistent.sfs, the uid value at the PART level is the part.flightID value instead.
    /// </summary>
    public uint uid;
    public Vector3 vel;
    /// <summary>
    /// The vessel to which this part belongs. Beware that vessel == null in the editor.
    /// </summary>
    public Vessel vessel;
    public VesselType vesselType;
    public bool WaterContact;

    public extern Part();

    public extern static explicit operator Part(GameObject o);

    public extern BaseActionList Actions { get; }
    public extern int ClassID { get; }
    public extern string ClassName { get; }
    public extern string ConstructID { get; }
    public extern BaseEventList Events { get; }
    public extern BaseFieldList Fields { get; }
    public extern bool hasStagingIcon { get; }
    public extern bool isAttached { get; set; }
    public extern bool isConnected { get; set; }
    public extern bool isControllable { get; }
    public extern bool Landed { get; }
    public extern Part localRoot { get; }
    public extern PartModuleList Modules { get; }
    /// <summary>
    /// Don't use this; use Vessel.orbit instead.
    /// </summary>
    public extern Orbit orbit { get; }
    /// <summary>
    /// A list of the resources contained by this part. You can loop over them with
    /// <code>foreach(PartResource resource in part.Resources) { ... }</code>
    /// </summary>
    public extern PartResourceList Resources { get; }
    /// <summary>
    /// The rigidbody of this part. See the Unity documentation on rigidbodies for more information.
    /// </summary>
    public extern Rigidbody Rigidbody { get; }
    public extern bool Splashed { get; }
    public extern PartStates State { get; }

    public extern bool activate(int currentStage);
    public extern void addChild(Part child);
    public extern bool AddCrewmember(ProtoCrewMember crew);
    public extern InternalModel AddInternalPart(ConfigNode node);
    public extern PartModule AddModule(ConfigNode node);
    /// <summary>
    /// Add a PartModule to this part. PartModules that are dynamically added to parts and don't exist in the original
    /// part.cfg will not be properly restored from persistence.
    /// </summary>
    /// <param name="moduleName">The class name of the PartModule to add, as a string</param>
    /// <returns>The added PartModule</returns>
    public extern PartModule AddModule(string moduleName);
    public extern void AddOnMouseDown(Part.OnActionDelegate method);
    public extern void AddOnMouseEnter(Part.OnActionDelegate method);
    public extern void AddOnMouseExit(Part.OnActionDelegate method);
    public extern PartResource AddResource(ConfigNode node);
    public extern bool CheckCollision(Collision c);
    public extern bool checkLanded();
    public extern bool checkSplashed();
    public extern void cleanReferencesFromOtherParts();
    public extern void Couple(Part tgtPart);
    public extern void CreateInternalModel();
    public extern void deactivate();
    public extern void decouple(float breakForce = 0f);
    public extern void DespawnAllCrew();
    [ContextMenu("Die")]
    public extern void Die();
    public extern void disconnect(bool controlledSeparation = false);
    /// <summary>
    /// Deprecated.
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    public extern virtual bool DrainFuel(float amount);
    public extern void drawStats();
    /// <summary>
    /// Calling this causes the part to explode. But you guessed that, didn't you?
    /// </summary>
    public extern void explode();
    /// <summary>
    /// Find an AttachNode by its name, as a string.
    /// </summary>
    /// <param name="nodeId">The name of the node to search for. The names of nodes are found in the part.cfg. For instance,
    /// node_stack_top describes a node with name "stack_top."</param>
    /// <returns>The AttachNode of the given name.</returns>
    public extern AttachNode findAttachNode(string nodeId);
    /// <summary>
    /// Given a child part of this part, find the AttachNode representing the connection between this
    /// part and that child.
    /// </summary>
    /// <param name="connectedPart">A child part of this part.</param>
    /// <returns>The AttachNode connecting this part to the given child.</returns>
    public extern AttachNode findAttachNodeByPart(Part connectedPart);
    public extern AttachNode[] findAttachNodes(string partialNodeId);
    public extern T FindChildPart<T>() where T : Part;
    public extern T FindChildPart<T>(bool recursive) where T : Part;
    public extern Part FindChildPart(string childName);
    public extern Part FindChildPart(string childName, bool recursive);
    public extern T[] FindChildParts<T>() where T : Part;
    public extern T[] FindChildParts<T>(bool recursive) where T : Part;
    public extern virtual bool FindFuel(Part source, List<Part> fuelSources, uint reqId);
    public extern FXGroup findFxGroup(string groupID);
    public extern Animation[] FindModelAnimators();
    public extern Animation[] FindModelAnimators(string clipName);
    public extern T FindModelComponent<T>() where T : Component;
    public extern T FindModelComponent<T>(string childName) where T : Component;
    public extern T[] FindModelComponents<T>() where T : Component;
    public extern T[] FindModelComponents<T>(string childName) where T : Component;
    public extern Transform FindModelTransform(string childName);
    public extern Transform[] FindModelTransforms(string childName);
    public extern void FindNonPhysicslessChildren(List<Part> parts);
    /// <summary>
    /// Activates the part now, regardless of when it was scheduled to be activated in the staging order.
    /// </summary>
    [ContextMenu("Activate")]
    public extern void force_activate();
    public extern void freeze();
    public extern static Part FromGO(GameObject obj);
    public extern static T GetComponentUpwards<T>(GameObject obj) where T : Component;
    public extern static Component GetComponentUpwards(string type, GameObject obj);
    public extern void GetConnectedResources(int resourceID, List<PartResource> resources);
    public extern static uint getFuelReqId();
    /// <summary>
    /// The total mass of the resources held by the part. The total mass of the part is <code>mass + GetResourceMass()</code>
    /// </summary>
    /// <returns>Total resource mass, in tonnes</returns>
    public extern float GetResourceMass();
    public extern Part getSymmetryCounterPart(int index);
    public extern void HandleCollision(Collision c);
    public extern bool hasIndirectChild(Part tgtPart);
    public extern bool hasIndirectParent(Part tgtPart);
    public extern bool isSymmetryCounterPart(Part cPart);
    public extern void LateUpdate();
    public extern PartModule LoadModule(ConfigNode node, int moduleIndex);
    protected extern virtual void onActiveFixedUpdate();
    protected extern virtual void onActiveUpdate();
    public extern void onAttach(Part parent, bool first = true);
    public extern virtual void onBackup();
    public extern void OnCollisionEnter(Collision c);
    public extern void OnCollisionExit(Collision c);
    public extern void OnCollisionStay(Collision c);
    public extern void OnCopy(Part original, bool asSymCounterpart);
    protected extern virtual void onCopy(Part original, bool asSymCounterpart);
    protected extern virtual void onCtrlUpd(FlightCtrlState s);
    protected extern virtual void onDecouple(float breakForce);
    public extern void OnDelete();
    public extern void onDetach(bool first = true);
    protected extern virtual void onDisconnect();
    public extern virtual void OnDrawStats();
    protected extern virtual void onEditorUpdate();
    protected extern virtual void onFlightStart();
    protected extern virtual void onFlightStartAtLaunchPad();
    public extern virtual void onFlightStateLoad(Dictionary<string, KSPParseable> parsedData);
    public extern virtual void onFlightStateSave(Dictionary<string, KSPParseable> partDataCollection);
    protected extern virtual void onGamePause();
    protected extern virtual void onGameResume();
    protected extern virtual void onJointDisable();
    protected extern virtual void onJointReset();
    public extern void OnLiftOff();
    public extern void OnLoad();
    protected extern virtual void onPack();
    protected extern virtual bool onPartActivate();
    protected extern virtual void onPartAttach(Part parent);
    protected extern virtual void onPartAwake();
    protected extern virtual void onPartDeactivate();
    protected extern virtual void onPartDelete();
    protected extern virtual void onPartDestroy();
    protected extern virtual void onPartDetach();
    protected extern virtual void onPartExplode();
    protected extern virtual void onPartFixedUpdate();
    protected extern virtual void onPartLiftOff();
    protected extern virtual void onPartLoad();
    protected extern virtual void onPartSplashdown();
    protected extern virtual void onPartStart();
    protected extern virtual void onPartTouchdown();
    protected extern virtual void onPartUpdate();
    public extern void OnSplashDown();
    protected extern virtual void onStartComplete();
    public extern void OnTouchDown();
    protected extern virtual void onUnpack();
    public extern void Pack();
    public extern void propagateControlUpdate(FlightCtrlState st);
    public extern void removeChild(Part child);
    public extern void RemoveCrewmember(ProtoCrewMember crew);
    public extern void RemoveModule(PartModule module);
    public extern void RemoveOnMouseDown(Part.OnActionDelegate method);
    public extern void RemoveOnMouseEnter(Part.OnActionDelegate method);
    public extern void RemoveOnMouseExit(Part.OnActionDelegate method);
    /// <summary>
    /// Deprecated.
    /// </summary>
    /// <param name="source"></param>
    /// <param name="amount"></param>
    /// <param name="reqId"></param>
    /// <returns></returns>
    public extern virtual bool RequestFuel(Part source, float amount, uint reqId);
    /// <summary>
    /// Deprecated.
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="earliestStage"></param>
    /// <returns></returns>
    public extern virtual bool RequestRCS(float amount, int earliestStage);
    public extern double RequestResource(int resourceID, double demand);
    public extern float RequestResource(int resourceID, float demand);
    public extern double RequestResource(string resourceName, double demand);
    public extern float RequestResource(string resourceName, float demand);
    [ContextMenu("Reset Collision Ignores")]
    public extern void ResetCollisionIgnores();
    [DebuggerHidden]
    public extern IEnumerator ResetJoints();
    public extern void ResumeVelocity();
    public extern void ScheduleSetCollisionIgnores();
    public extern void SendEvent(string eventName);
    public extern void SendEvent(string eventName, BaseEventData data);
    public extern void SendEvent(string eventName, BaseEventData data, int maxDepth);
    public extern void SetCollisionIgnores();
    public extern void SetDetectCollisions(bool setState);
    public extern void SetHierarchyRoot(Part root);
    public extern void SetHighlight(bool active);
    public extern void SetHighlightColor();
    public extern void SetHighlightColor(Color color);
    public extern void SetHighlightDefault();
    public extern void SetHighlightType(Part.HighlightType type);
    protected extern void SetLayer(GameObject obj, int layer);
    public extern void SetMirror(Vector3 mirrorVector);
    public extern void setOpacity(float opacity);
    public extern void setParent(Part p = null);
    public extern void SetResource(ConfigNode node);
    public extern void SpawnCrew();
    public extern double TransferResource(int resourceID, double amount);
    public extern void Undock(DockedVesselInfo newVesselInfo);
    public extern void unfreeze();
    public extern void Unpack();
    public extern void UpdateOrgPosAndRot(Part newRoot);

    public enum DragModel
    {
        DEFAULT = 0,
        CONIC = 1,
        CYLINDRICAL = 2,
    }

    public enum HighlightType
    {
        Disabled = 0,
        OnMouseOver = 1,
        AlwaysOn = 2,
    }

    /// <summary>
    /// Represents whether a part has physics.
    /// </summary>
    public enum PhysicalSignificance
    {
        /// <summary>
        /// Part is a normal, physics-enabled part.
        /// </summary>
        FULL = 0,
        /// <summary>
        /// Part has no physics, and in particular no mass or drag.
        /// </summary>
        NONE = 1,
    }

    public delegate void OnActionDelegate(Part p);
}



/// <summary>
/// Describes the two possibilities for how a part can be attached to its parent.
/// </summary>
public enum AttachModes
{
    /// <summary>
    /// The part is attached to its parent via a stack node; for example this is
    /// how vertically stacked fuel tanks are attached
    /// </summary>
    STACK = 0,
    /// <summary>
    /// This part is attached to the surface of its parent; for example this is how
    /// radial decouplers are attached.
    /// </summary>
    SRF_ATTACH = 1,
}