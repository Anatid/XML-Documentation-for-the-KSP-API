#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Probably the most useful function here is Planetarium.GetUniversalTime().
/// </summary>
public class Planetarium : MonoBehaviour
{
    /// <summary>
    /// Presumably, the main body of the active vessel?
    /// </summary>
    public CelestialBody CurrentMainBody;
    /// <summary>
    /// Use this instance to access non-static fields.
    /// </summary>
    public static Planetarium fetch;
    public double fixedDeltaTime;
    public double inverseRotAngle;
    public List<OrbitDriver> orbits;
    public bool pause;
    public QuaternionD rotation;
    /// <summary>
    /// The CelestialBody representing the Sun.
    /// </summary>
    public CelestialBody Sun;
    public double time;
    public double timeScale;
    public static Planetarium.ZupVectors Zup;
    public QuaternionD zUpRotation;

    public extern Planetarium();

    public extern static Vector3d forward { get; }
    public extern static double InverseRotAngle { get; set; }
    public extern static List<OrbitDriver> Orbits { get; }
    public extern static bool Pause { get; }
    public extern static Vector3d right { get; }
    public extern static QuaternionD Rotation { get; set; }
    public extern static double TimeScale { get; set; }
    public extern static Vector3d up { get; }
    public extern static QuaternionD ZupRotation { get; set; }

    /// <summary>
    /// Presumably, whether the game is currently using a rotating
    /// frame for physics (as opposed to an unrotating inertial frame). 
    /// Below a certain altitude (CelestialBody.inverseRot
    /// </summary>
    /// <returns></returns>
    public extern static bool FrameIsRotating();
    /// <summary>
    /// The simulation time, in seconds, since this save was started.
    /// </summary>
    /// <returns>Universal time, in seconds</returns>
    public extern static double GetUniversalTime();
    public extern static void SetUniversalTime(double t);

    /*
     * Can't get this to compile --The_Duck
    public struct ZupVectors
    {

        public Vector3d X { get; }
        public Vector3d Y { get; }
        public Vector3d Z { get; }
    }*/
    public struct ZupVectors { }
}

