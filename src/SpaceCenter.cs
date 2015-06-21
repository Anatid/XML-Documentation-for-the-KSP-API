using System;
using UnityEngine;

public class SpaceCenter : MonoBehaviour
{
    public double AreaRadius;
    public CelestialBody cb;
    public static SpaceCenter Instance;
    public Collider spaceCenterAreaTrigger;

    public extern SpaceCenter();

    public extern double Latitude { get; }
    public extern double Longitude { get; }
    public extern Transform SpaceCenterTransform { get; set; }
    public extern Vector3d SrfNVector { get; }

    public extern double GreatCircleDistance(Vector3d fromSrfNrm);
}
