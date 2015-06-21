using System;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The Sun, the planets, and the moons are all CelestialBodies.
/// </summary>
public class CelestialBody /*: MonoBehaviour, ITargetable, IDiscoverable*/
{   
    public float altitudeMultiplier;
    public float altitudeOffset;
    /// <summary>
    /// The magnitude of the angular velocity of the body's rotation, in radians per second.
    /// </summary>
    public double angularV;
    /// <summary>
    /// The body's angular velocity vector, in rotations per second. This points along the axis of
    /// rotation and its magnitude is the rotation rate in radians per second.
    /// </summary>
    public Vector3d angularVelocity;
    public float atmoshpereTemperatureMultiplier;
    /// <summary>
    /// Whether this body has an atmosphere
    /// </summary>
    public bool atmosphere;
    /// <summary>
    /// Presumably, whether jet engines will work in this body's atmosphere
    /// </summary>
    public bool atmosphereContainsOxygen;
    /// <summary>
    /// Seems to be the pressure of the body's atmosphere at sea level, in units of Kerbin atmospheres at sea level.
    /// Appears to only have an effect when useLegacyAtmosphere is toggled on
    /// </summary>
    public float atmosphereMultiplier;
    /// <summary>
    /// The atmosphere's scale height, in KILOMETERS (not meters). The atmospheric pressure at a given altitude
    /// above sea level is proportional to Math.Exp(-altitude / atmosphereScaleHeight).
    /// </summary>
    public double atmosphereScaleHeight;
    public Color atmosphericAmbientColor;
    public CBAttributeMap BiomeMap;
    public string bodyDescription;
    /// <summary>
    /// The name of the body, as a string.
    /// </summary>
    public string bodyName;
    public Transform bodyTransform;
    public CelestialBodyType bodyType;
    public double directRotAngle;
    /// <summary>
    /// The gravitational acceleration of the body at sea level, in units of gees (1 gee = 9.81 m/s^2)
    /// </summary>
    public double GeeASL;
    /// <summary>
    /// The gravitational acceleration (in m/s^2) at a radius r (in m) from the body's center is gMagnitudeAtCenter / r^2
    /// </summary>
    public double gMagnitudeAtCenter;
    /// <summary>
    /// The gravitational parameter GM is the universal gravitational constant G times the mass M of the body. 
    /// In KSP the gravitational constant G is exactly 6.673 m^3 / (kg s^2), and the body mass is measured in
    /// kilograms.
    /// </summary>
    public double gravParameter;
    /// <summary>
    /// Unused?
    /// </summary>
    public double hillSphere;
    public double initialRotation;
    public bool inverseRotation;
    public float inverseRotThresholdAltitude;
    /// <summary>
    /// The mass of the body in kilograms. Computed 
    /// </summary>
    public double Mass;
    /// <summary>
    /// The height of the upper edge of the body's atmosphere, in meters above sea level. Except,
    /// not really. The atmosphere really cuts off at an altitude (in meters) of 
    /// <code>body.atmosphereScaleHeight * 1000 * Math.Log(1e6)</code>
    /// </summary>
    public float maxAtmosphereAltitude;
    /// <summary>
    /// Whether this planet has an ocean at "sea level"
    /// </summary>
    public bool ocean;
    /// <summary>
    /// this is what gives the celestial body its orbit and makes it go along the orbit as well
    /// </summary>
    public OrbitDriver orbitDriver;
    /// <summary>
    /// A list of this body's moons (or, in the case of the Sun, a list of the planets).
    /// </summary>
    public List<CelestialBody> orbitingBodies;
    /// <summary>
    /// The pqsController computes the terrain of the planet. Note that for the Sun, pqsController = null.
    /// </summary>
    public PQS pqsController;
    public AnimationCurve pressureCurve;
    public float pressureMultiplier;
    /// <summary>
    /// The radius of the planet in meters. Note that this is only the radius of "sea level"; the actual terrain may be higher.
    /// </summary>
    public double Radius;
    public bool rotates;
    public QuaternionD rotation;
    public double rotationAngle;
    /// <summary>
    /// The time, in seconds, for the body to complete one rotation around its axis
    /// </summary>
    public double rotationPeriod;
    public CelestialBodyScienceParams scienceValues;
    /// <summary>
    /// The radius of this body's sphere of influence (measured from the center of the body), in meters.
    /// </summary>
    public double sphereOfInfluence;
    public double staticPressureASL;
    public AnimationCurve temperatureCurve;
    // commented out to fix build error: public PlanetQuadTreeController terrainController;
    /// <summary>
    /// Presumably, whether this body is tidally locked to the body around with it orbits.
    /// </summary>
    public bool tidallyLocked;
    /// <summary>
    /// Presumably, this gives the minimum altitude you must have in order to be allowed to use each
    /// warp rate when in this body's sphere of influence.
    /// </summary>
    public float[] timeWarpAltitudeLimits;
    public bool use_The_InName;
    /// <summary>
    /// It appears that this setting toggles between old and new atmosphere system
    /// </summary>
    public bool useLegacyAtmosphere;
    public Vector3d zUpAngularVelocity;

    public extern CelestialBody();

    /// <summary>Describes to what extent this body has been explored</summary>
    public extern DiscoveryInfo DiscoveryInfo { get; }
    public extern int flightGlobalsIndex { get; set; }
    public extern string name { get; }
    /// <summary>
    /// Describes the orbit of this body around its primary.
    /// </summary>
    public extern Orbit orbit { get; }
    /// <summary>
    /// The position of the center of the body, in world coordinates.
    /// </summary>
    public extern Vector3d position { get; set; }
    /// <summary>
    /// Presumably, the body this body orbits around
    /// </summary>
    public extern CelestialBody referenceBody { get; }
    public extern Texture2D ResourceMap { get; }
    public extern PResource Resources { get; }
    public extern string theName { get; }

    public extern void CBUpdate();
    [ContextMenu("Debug Time Warp Limits")]
    public extern void debugTimeWarpLimits();
    public extern void DisplaySurfaceResource(int resourceID);
    /// <summary>
    /// Gets the height of a given position above this body's sea level, in meters.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Altitude in meters</returns>
    public extern double GetAltitude(Vector3d worldPos);
    public extern Bounds getBounds();
    /// <summary>
    /// The velocity of the CelestialBody, {AliceWorld, Sun}. (See Orbit.cs for
    /// the reference frame definitions).
    /// </summary>
    public extern Vector3d GetFrameVel();
    public extern Vector3d GetFrameVelAtUT(double UT);
    public extern Vector3 GetFwdVector();
    /// <summary>
    /// Gets the latitude of a given position, in degrees.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Latitude in degrees</returns>
    public extern double GetLatitude(Vector3d worldPos);
    /// <summary>
    /// Gets the longitude of a given position, in degrees. Note that you CANNOT count on this value being in any particular range.
    /// This function may for example return 420, meaning 60 degrees east. You would be well advised to coerce it into a standard
    /// range like -180 to 180 before using it.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Longitude in degrees</returns>
    public extern double GetLongitude(Vector3d worldPos);
    public extern string GetName();
    public extern Vector3 GetObtVelocity();
    public extern Orbit GetOrbit();
    public extern OrbitDriver GetOrbitDriver();
    public extern Vector3d getPositionAtUT(double UT);
    public extern Vector3d GetRelSurfaceNVector(double lat, double lon);
    public extern Vector3d GetRelSurfacePosition(Vector3d worldPosition);
    /// <summary>
    /// Returns a vector pointing from the center of the body to the given latitude, longitude, and altitude.
    /// </summary>
    /// <param name="lat">Latitude in degrees</param>
    /// <param name="lon">Longitude in degrees</param>
    /// <param name="alt">Altitude above sea level in meters</param>
    /// <returns>A position vector relative to the center of the body</returns>
    public extern Vector3d GetRelSurfacePosition(double lat, double lon, double alt);
    /// <summary>
    /// Returns the velocity at a given position of the frame of reference that rotates with the planet.
    /// This velocity is the difference between the "orbit" and "surface" velocities.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Velocity of the rotating reference frame</returns>
    public extern Vector3d getRFrmVel(Vector3d worldPos);
    public extern Vector3 GetSrfVelocity();
    /// <summary>
    /// Returns a unit vector perpendicular to the surface of the body at the given latitude and
    /// longitude (pretending for the moment that the body is a perfect sphere).
    /// </summary>
    /// <param name="lat">Latitude in degrees</param>
    /// <param name="lon">Longitude in degrees</param>
    /// <returns>A unit normal vector to the surface</returns>
    public extern Vector3d GetSurfaceNVector(double lat, double lon);
    public extern VesselTargetModes GetTargetingMode();
    public extern Transform GetTransform();
    public extern Vector3d getTruePositionAtUT(double UT);
    public extern Vessel GetVessel();
    /// <summary>
    /// Returns the position, in world coordinates, of a given latitude, longitude, and altitude
    /// </summary>
    /// <param name="lat">Latitude in degrees</param>
    /// <param name="lon">Longitude in degrees</param>
    /// <param name="alt">Altitude above sea level in meters</param>
    /// <returns>Position in world coordinates</returns>
    public extern Vector3d GetWorldSurfacePosition(double lat, double lon, double alt);
    public extern bool HasChild(CelestialBody body);
    public extern bool HasParent(CelestialBody body);
    public extern void HideSurfaceResource();
    [ContextMenu("Reset Time Warp Limits")]
    public extern void resetTimeWarpLimits();

    /// <summary>Returns the body's altitude above the reference sphere of its primary</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern double RevealAltitude();

    /// <summary>Returns the body's mass, in kg</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern float RevealMass();

    /// <summary>Returns the body's tracking station name</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealName();

    /// <summary>Describes the state of the body</summary>
    ///
    /// <returns>A string containing the sphere of influence and trajectory of the object</returns>
    /// 
    /// <example>"Orbiting the Sun"</example>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealSituationString();

    /// <summary>Returns the body's speed</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern double RevealSpeed();

    /// <summary>Returns the type of the body</summary>
    ///
    /// <returns>One of "Sun", "Planet", or "Moon"</returns>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealType();
}
