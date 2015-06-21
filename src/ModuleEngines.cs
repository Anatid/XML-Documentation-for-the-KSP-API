#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A PartModule that can be configured to behave like many different kinds of engines. All stock
/// propulsion systems except for RCS are implemented through ModuleEngines.
/// </summary>
public class ModuleEngines : PartModule
{
    [KSPField]
    public bool allowRestart;
    [KSPField]
    public bool allowShutdown;
    /// <summary>
    /// Represents the specific impulse (Isp) of the engine as a function of altitude. To get
    /// the Isp at a certain height h (in meters), use <code>atmosphereCurve.Evaluate(h)</code>.
    /// </summary>
    [KSPField]
    public FloatCurve atmosphereCurve;
    [KSPField]
    public bool autoPositionFX;
    /// <summary>
    /// The current *internal* throttle of the engine, which may be different from the current
    /// throttle set by the player if <c>useEngineResponseTime</c> is true.
    /// </summary>
    [KSPField(isPersistant = true)]
    public float currentThrottle;
    /// <summary>
    /// How quickly the engine spools up when the user-set throttle is higher than 
    /// <c>currentThrottle</c>. 
    /// </summary>
    /// <remarks>
    /// Each frame, if the user throttle is higher than
    /// the engine's <c>currentThrottle</c>, <c>currentThrottle</c>
    /// is updated according to the formula
    /// 
    /// <code>currentThrottle += (user throttle - currentThrottle) * engineAccelerationSpeed * dt</code>
    /// 
    /// <c>engineAccelerationSpeed</c> has units of inverse seconds.
    /// </remarks>
    [KSPField]
    public float engineAccelerationSpeed;
    /// <summary>
    /// How quickly the engine spools down when the user-set throttle is higher than 
    /// <c>currentThrottle</c>. 
    /// </summary>
    /// <remarks>
    /// Each frame, if the user throttle is lower than
    /// the engine's <c>currentThrottle</c>, <c>currentThrottle</c>
    /// is updated according to the formula
    /// 
    /// <code>currentThrottle += (user throttle - currentThrottle) * engineDecelerationSpeed * dt</code>
    /// 
    /// <c>engineDecelerationSpeed</c> has units of inverse seconds.
    /// </remarks>
    [KSPField]
    public float engineDecelerationSpeed;
    /// <summary>
    /// Whether the engine has ever been turned on?
    /// </summary>
    [KSPField(isPersistant = true)]
    public bool EngineIgnited;
    [KSPField(isPersistant = true)]
    public bool engineShutdown;
    /// <summary>
    /// Whether the engine's exhaust will damage parts that it hits. A ray is cast back
    /// along the engine's thrust vector and if that ray hits a part then that part gets heated
    /// up, and may explode if it exceeds its maximum temperature.
    /// </summary>
    [KSPField]
    public bool exhaustDamage;
    [KSPField(guiName = "Thrust", guiUnits = "kN", guiFormat = "F1", guiActive = true)]
    public float finalThrust;
    [KSPField(isPersistant = true)]
    public bool flameout;
    [KSPField(guiName = "Fuel Flow", guiUnits = "U", guiFormat = "F5", guiActive = true)]
    public float fuelFlowGui;
    [KSPField]
    public string fxGroupPrefix;
    [KSPField]
    public Vector3 fxOffset;
    public float G;
    [KSPField]
    public float heatProduction;
    [KSPField]
    public float ignitionThreshold;
    /// <summary>
    /// The thrust this engine produces at maximum throttle.
    /// </summary>
    [KSPField]
    public float maxThrust;
    /// <summary>
    /// The thrust this engine produces at minimum throttle.
    /// </summary>
    [KSPField]
    public float minThrust;
    public float mixtureDensity;
    /// <summary>
    /// <para>The resources used by this engine, and their relative ratios.</para>
    /// </summary>
    public List<ModuleEngines.Propellant> propellants;
    /// <summary>
    /// The current specific impulse of this engine, in seconds.
    /// </summary>
    [KSPField(guiName = "Specific Impulse", guiUnits = "s", guiFormat = "F1", guiActive = true)]
    public float realIsp;
    public float requestedThrottle;
    public float requestedThrust;
    [KSPField(isPersistant = true)]
    public bool staged;
    [KSPField(guiName = "Status", guiActive = true)]
    public string status;
    [KSPField(guiName = " ", guiActive = true)]
    public string statusL2;
    /// <summary>
    /// Whether this engine always produces maximum thrust once activated (like solid rocket boosters).
    /// </summary>
    [KSPField]
    public bool throttleLocked;
    /// <summary>
    /// These transforms store the locations and directions at which the thrust this engine generates is applied to the part.
    /// Which component of the transform rotation gives the thrust vector?
    /// </summary>
    public List<Transform> thrustTransforms;
    [KSPField]
    public string thrustVectorTransformName;
    /// <summary>
    /// Whether the engine has a nonzero spool-up and spool-down time.
    /// </summary>
    /// <remarks>
    /// If <c>useEngineResponseTime</c> is true, then the engine does not
    /// spool up or down instantly when the throttle changes, but uses the
    /// <c>engineAccelerationSpeed</c> and <c>engineDecelerationSpeed</c>
    /// variables.
    /// </remarks>
    [KSPField]
    public bool useEngineResponseTime;
    /// <summary>
    /// Whether this engine's thrust varies with airspeed?
    /// </summary>
    [KSPField]
    public bool useVelocityCurve;
    /// <summary>
    /// How this engine's thrust varies with airspeed?
    /// </summary>
    [KSPField]
    public FloatCurve velocityCurve;

    public extern ModuleEngines();

    /// <summary>
    /// If this is true, the engine is not producing thrust because it can't get enough resources.
    /// </summary>
    public extern bool getFlameoutState { get; }
    public extern bool getIgnitionState { get; }
    public extern float normalizedThrustOutput { get; }

    public extern void AutoPlaceFXGroup(FXGroup group, Transform thruster);
    public extern void BurstFlameoutGroups();
    public extern float CalculateThrust();
    public extern void EngineExhaustDamage();
    public extern void FixedUpdate();
    public extern override string GetInfo();
    public extern override void OnActive();
    public extern override void OnAwake();
    public extern void OnCenterOfThrustQuery(CenterOfThrustQuery qry);
    public extern override void OnLoad(ConfigNode node);
    public extern override void OnSave(ConfigNode node);
    public extern override void OnStart(PartModule.StartState state);
    public extern double RequestPropellant(double mass);
    public extern void SetPowerGroupsActive(bool active);
    public extern void SetRunningGroupsActive(bool active);
    public extern void SetupFXGroups();
    public extern void SetupPropellant();
    public extern void UpdateThrottle();

    /// <summary>
    /// A class that represents the resource requirements of an engine.
    /// </summary>
    [Serializable]
    public class Propellant
    {
        public double currentAmount;
        public double currentRequirement;
        public bool drawStackGauge;
        /// <summary>
        /// The integer ID of the resource consumed.
        /// </summary>
        public int id;
        public bool isDeprived;
        /// <summary>
        /// The string name of the resource consumed, e.g. "LiquidFuel"
        /// </summary>
        public string name;
        /// <summary>
        /// How much of this resource is consumed by the engine, in proportion to other resources. For example if the
        /// engine consumes three resources (A, B, C) with A.ratio = 3, B.ratio = 2, C.ratio = 1, then 3 units of every
        /// will be consumed for every 2 units of B and 1 unit of C.
        /// </summary>
        public float ratio;

        public extern Propellant();

        public extern void Load(ConfigNode node);
        public extern void Save(ConfigNode node);
    }
}
