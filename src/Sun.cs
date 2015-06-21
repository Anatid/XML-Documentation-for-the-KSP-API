using System;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public double AU;
    public AnimationCurve brightnessCurve;
    public float fadeEnd;
    public float fadeStart;
    public static Sun Instance;
    public float localTime;
    public CelestialBody sun;
    public Vector3d sunDirection;
    public LensFlare sunFlare;
    public Transform target;
    public bool useLocalSpaceSunLight;

    public extern Sun();

    public extern float GetLocalTimeAtPosition(Vector3d wPos, CelestialBody cb);
    public extern void SunlightEnabled(bool state);
}
