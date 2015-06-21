using System;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// A class for managing planetary systems. Ask the Kopernicus guys/look at their code for details.
/// </summary>
[AddComponentMenu("KSP/SolarSystem/PSystemManager")]
public class PSystemManager : MonoBehaviour
{
    public string localSpaceName;
    public PlanetariumCamera scaledSpaceCamera;
    public float scaledSpaceFactor;
    public string scaledSpaceName;
    public Sun sun;
    public PSystem systemPrefab;

    public PSystemManager();

    public static PSystemManager Instance { get; }
    public List<CelestialBody> localBodies { get; }
    public EventVoid OnPSystemReady { get; }
    public List<GameObject> scaledBodies { get; }
}
