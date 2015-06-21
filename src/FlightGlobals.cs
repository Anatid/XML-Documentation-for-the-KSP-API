#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FlightGlobals contains lists of all CelestialBodies and Vessels in the game. 
/// It also provides static utility functions for computing the atmospheric and gravitational properties of CelestialBodies.
/// </summary>
public class FlightGlobals : MonoBehaviour
{
    public static Part activeTarget;
    public Vessel activeVessel;
    public List<CelestialBody> bodies;
    public static double camera_altitude;
    public static Vector3d camera_position;
    public static CelestialBody currentMainBody;
    public float drag_multiplier;
    /// <summary>
    /// Use this FlightGlobals instance to access non-static members of FlightGlobals.
    /// For example, the current target is FlightGlobals.fetch.VesselTarget.
    /// </summary>
    public static FlightGlobals fetch;
    public static FoRModes FoRMode;
    public Camera mainCameraRef;
    public static bool overrideOrbit;
    public static List<GameObject> physicalObjects;
    public static bool ready;
    public static Vector3d ship_acceleration;
    public static double ship_altitude;
    public static Vector3 ship_angularMomentum;
    public static Vector3d ship_angularVelocity;
    public static Vector3d ship_CoM;
    public static double ship_dns;
    public static double ship_geeForce;
    public static float ship_heading;
    public static double ship_latitude;
    public static double ship_longitude;
    public static Vector3 ship_MOI;
    public static double ship_obtSpeed;
    public static Vector3d ship_obtVelocity;
    public static Orbit ship_orbit;
    public static Quaternion ship_orientation;
    public static Quaternion ship_orientation_offset;
    public static Vector3d ship_position;
    public static Quaternion ship_rotation;
    public static double ship_srfSpeed;
    public static Vector3d ship_srfVelocity;
    public static double ship_stP;
    public static double ship_tgtSpeed;
    public static Vector3d ship_tgtVelocity;
    public static Vector3d ship_upAxis;
    public static Vector3d ship_velocity;
    public static double ship_verticalSpeed;
    public List<Vessel> vessels;
    [HideInInspector]
    public Vector3 vesselTargetDelta;
    [HideInInspector]
    public Vector3 vesselTargetDirection;
    public Transform vesselTargetTransform;
    public static bool warpDriveActive;

    public extern FlightGlobals();

    /// <summary>
    /// The vessel the player is currently controlling.
    /// </summary>
    public extern static Vessel ActiveVessel { get; }
    /// <summary>
    /// A list of all CelestialBodies in the universe. Contents in 0.18.2: 
    /// <para>Bodies[0] = Sun</para>
    /// <para>Bodies[1] = Kerbin</para>
    /// <para>Bodies[2] = Mun</para>
    /// <para>Bodies[3] = Minmus</para>
    /// <para>Bodies[4] = Moho</para>
    /// <para>Bodies[5] = Eve</para>
    /// <para>Bodies[6] = Dun</para>
    /// <para>Bodies[7] = Ike</para>
    /// <para>Bodies[8] = Jool</para>
    /// <para>Bodies[9] = Laythe</para>
    /// <para>Bodies[10] = Vall</para>
    /// <para>Bodies[11] = Bop</para>
    /// <para>Bodies[12] = Tylo</para>
    /// <para>Bodies[13] = Gilly</para>
    /// <para>Bodies[14] = Pol</para>
    /// <para>Bodies[15] = Dres</para>
    /// <para>Bodies[16] = Eeloo</para>
    /// </summary>
    public extern static List<CelestialBody> Bodies { get; }
    /// <summary>
    /// The KSP formula for the drag force on a part is
    /// (1/2) * DragMultiplier * part.mass * part.mass_drag * airspeed^2
    /// </summary>
    public extern static float DragMultiplier { get; }
    /// <summary>
    /// Whether KSP is doing its computations in an inertial reference frame, or the reference frame that 
    /// rotates with the current dominant celestial body.
    /// </summary>
    public extern static bool RefFrameIsRotating { get; }
    // commented out to fix build error: public extern static SurfaceRadius terrain { get; }
    public extern static Vector3d upAxis { get; }
    public extern static float vacuumTemperature { get; }
    /// <summary>
    /// A list of all the Vessels that currently exist
    /// </summary>
    public extern static List<Vessel> Vessels { get; }
    /// <summary>
    /// The currently selected target vessel, celestial body, or docking node. If no target is selected, this is null.
    /// </summary>
    public extern ITargetable VesselTarget { get; }
    public extern FlightGlobals.VesselTargetModes vesselTargetMode { get; }

    public extern static void addPhysicalObject(GameObject pObject);
    public extern static ClearToSaveStatus ClearToSave();
    public extern static void ForceSetActiveVessel(Vessel v);
    /// <summary>
    /// The altitude above the sea level of the current main body of the given world space position. 
    /// </summary>
    /// <param name="position">World space position</param>
    /// <returns>Altitude above sea level</returns>
    public extern static float getAltitudeAtPos(Vector3 position);
    /// <summary>
    /// The altitude above the sea level of the current main body of the given world space position. 
    /// </summary>
    /// <param name="position">World space position</param>
    /// <returns>Altitude above sea level</returns>
    public extern static double getAltitudeAtPos(Vector3d position);
    /// <summary>
    /// The altitude above the sea level of the given body of the given world space position. 
    /// </summary>
    /// <param name="position">World space position</param>
    /// <param name="body">The body in question</param>
    /// <returns>Altitude above sea level</returns>
    public extern static double getAltitudeAtPos(Vector3d position, CelestialBody body);
    /// <summary>
    /// Converts an atmospheric pressure into an atmospheric density. Atmospheric density is what
    /// appears in the KSP drag equation. This function seems to just multiply the input by 1.2230948554874
    /// </summary>
    /// <param name="pressure">Use the output of getStaticPressure</param>
    /// <returns>An atmospheric density, suitable for use in calculating drag.</returns>
    public extern static double getAtmDensity(double pressure);
    public extern static Vector3d getCentrifugalAcc(Vector3d pos, CelestialBody body);
    public extern static Vector3d getCoriolisAcc(Vector3d vel, CelestialBody body);
    /// <summary>
    /// Finds the temperature at a given world space position.
    /// </summary>
    /// <param name="pos">World space position</param>
    /// <returns>Temperature</returns>
    public extern static float getExternalTemperature(Vector3d pos);
    /// <summary>
    /// Finds the temperature at a given altitude above a given body.
    /// </summary>
    /// <param name="altitude">An altitude (in meters?)</param>
    /// <param name="body">The body of interest</param>
    /// <returns>Temperture</returns>
    public extern static float getExternalTemperature(float altitude, CelestialBody body);
    public extern static Quaternion GetFoR(FoRModes mode);
    public extern Quaternion getFoR(FoRModes mode);
    /// <summary>
    /// Returns the gravitational *acceleration* vector at a given position.
    /// Contrary to its name, it does *not* return force.
    /// </summary>
    /// <param name="pos">World space position</param>
    /// <returns>Gravitational acceleration vector</returns>
    public extern static Vector3d getGeeForceAtPosition(Vector3d pos);
    /// <summary>
    /// Returns the current dominant body?
    /// </summary>
    /// <returns></returns>
    public extern static CelestialBody getMainBody();
    /// <summary>
    /// Returns the body whose sphere of influence contains a given position?
    /// </summary>
    /// <param name="refPos">World space position?</param>
    /// <returns></returns>
    public extern static CelestialBody getMainBody(Vector3d refPos);
    /// <summary>
    /// Returns the current atmospheric pressure?
    /// </summary>
    /// <returns>Atmospheric pressure, in units of Kerbin's atmospheric pressure at sea level</returns>
    public extern static double getStaticPressure();
    /// <summary>
    /// Returns the atmospheric pressure at a given position. Feed the output of this
    /// function into getAtmDensity to get the atmopsheric density.
    /// </summary>
    /// <param name="position">World space position</param>
    /// <returns>Atmospheric pressure, in units of Kerbin's atmospheric pressure at sea level</returns>
    public extern static double getStaticPressure(Vector3d position);
    /// <summary>
    /// Returns the atmospheric pressure at a given altitude above a given body
    /// </summary>
    /// <param name="altitude">Altitude in meters?</param>
    /// <param name="body">The body in question</param>
    /// <returns>Atmospheric pressure, in units of Kerbin's atmospheric pressure at sea level</returns>
    public extern static double getStaticPressure(double altitude, CelestialBody body = null);
    /// <summary>
    /// Returns the atmospheric pressure of a given body's atmopshere at a given position
    /// </summary>
    /// <param name="position">World space position</param>
    /// <param name="body">The body in question</param>
    /// <returns>Atmospheric pressure, in units of Kerbin's atmospheric pressure at sea level</returns>
    public extern static double getStaticPressure(Vector3d position, CelestialBody body);
    public extern static Vector3d getUpAxis();
    public extern static Vector3d getUpAxis(Vector3d position);
    public extern static void removePhysicalObject(GameObject pObject);
    public extern static void SetActiveVessel(Vessel v);
    public extern void SetShipOrbit(int selBodyIndex, double ecc, double sma, double inc, double LAN, double mna, double argPe, double ObT);
    /// <summary>
    /// Sets the currently selected target vessel, celestial body, or docking node
    /// </summary>
    /// <param name="tgt">The Vessel, CelestialBody, or ModuleDockingNode to target</param>
    public extern void SetVesselTarget(ITargetable tgt);
    public extern void Start();

    public enum VesselTargetModes
    {
        None = 0,
        Direction = 1,
        DirectionAndVelocity = 2,
        DirectionVelocityAndOrientation = 3,
    }
}
