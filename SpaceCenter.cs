using System;
using UnityEngine;

public class SpaceCenter : MonoBehaviour
{
    public double AreaRadius;
    public CelestialBody cb;
    public static SpaceCenter Instance;
    public Collider spaceCenterAreaTrigger;

    public SpaceCenter();

    public double Latitude { get; }
    public double Longitude { get; }
    public Transform SpaceCenterTransform { get; set; }
    public Vector3d SrfNVector { get; }

    public double GreatCircleDistance(Vector3d fromSrfNrm);
}
