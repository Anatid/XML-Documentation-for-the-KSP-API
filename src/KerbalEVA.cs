#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// Kerbals on EVA are represented as vessels with a single part. That part contains a KerbalEVA PartModule.
/// </summary>
public class KerbalEVA : PartModule
{
    public KerbalAnimationManager Animations;
    public float boundAttack;
    public float boundFallThreshold;
    public float boundForce;
    public float boundFrequency;
    public float boundRelease;
    public float boundSharpness;
    public float boundSpeed;
    public float boundThreshold;
    public bool canRecover;
    public Collider[] characterColliders;
    public bool CharacterFrameMode;
    public bool CharacterFrameModeToggle;
    public Vector3 fFwd;
    public Transform footPivot;
    public Vector3 fRgt;
    public KerbalFSM fsm;
    [KSPField(guiName = "Pack Fuel", guiUnits = "%", guiFormat = "0.0", isPersistant = true, guiActive = true)]
    public float Fuel;
    public float FuelCapacity;
    public float FuelConsumption;
    public Vector3 fUp;
    public GameObject headLamp;
    public float hopThreshold;
    public float initialMass;
    public bool isRagdoll;
    public bool JetpackDeployed;
    public float Kd;
    public float Ki;
    public float Kp;
    public float ladderClimbSpeed;
    public Transform ladderPivot;
    public float ladderPushoffForce;
    public bool lampOn;
    public float linPower;
    public float massMultiplier;
    public float maxJumpForce;
    public float minRunningGee;
    public float minWalkingGee;
    public Collider[] otherRagdollColliders;
    public KerbalRagdollNode[] ragdollNodes;
    public float recoverThreshold;
    public float recoverTime;
    public float rotPower;
    public float runSpeed;
    public bool splatEnabled;
    public GameObject splatPrefab;
    public float splatSpeed;
    public float splatThreshold;
    public float strafeSpeed;
    public float stumbleThreshold;
    public float swimSpeed;
    public float turnRate;
    public Transform upperTorso;
    public float walkSpeed;

    public extern KerbalEVA();

    /// <summary>
    /// Whether the kerbal is currently hanging on to a ladder.
    /// </summary>
    public extern bool OnALadder { get; }
    public extern bool Ready { get; }
    public extern bool VesselUnderControl { get; }

    public extern void BoardPart(Part p);
    public extern int CompareContactsByNormalToSurface(ContactPoint c1, ContactPoint c2);
    public extern void OnCollisionEnter(Collision c);
    public extern void OnCollisionExit(Collision c);
    public extern void OnCollisionStay(Collision c);
    public extern override void OnLoad(ConfigNode node);
    public extern void OnPartDie();
    public extern override void OnSave(ConfigNode node);
    public extern override void OnStart(PartModule.StartState state);
    public extern void OnVesselPack();
    public extern void OnVesselUnpack();
    [ContextMenu("Reconfigure Animations")]
    public extern void SetupAnimations();
    public extern void SetWaypoint(Vector3 tgtPos);
}
