#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class related to the map view camera.
/// </summary>
public class PlanetariumCamera : MonoBehaviour
{
    public float cameraWobbleSensitivity;
    public float camHdg;
    public float camPitch;
    public float endHeading;
    /// <summary>
    /// Use this instance to access non-static members of this class.
    /// </summary>
    public static PlanetariumCamera fetch;
    public float maxDistance;
    public float maxPitch;
    public float minDistance;
    public float minHeight;
    public float minHeightAtMaxDist;
    public float minHeightAtMinDist;
    public float minPitch;
    public PlanetariumCamera.Modes mode;
    public float orbitSensitivity;
    public float pivotTranslateSharpness;
    public float sharpness;
    public float startDistance;
    public GUIStyle style;
    public bool TabSwitchTargets;
    public Transform target;
    public float targetHeading;
    public List<Transform> targets;
    public float zoomScaleFactor;

    public extern PlanetariumCamera();

    /// <summary>
    /// This is the Camera that looks at the planetarium scene. See the Unity documentation on Camera
    /// to see what you can do with this object.
    /// </summary>
    public extern static Camera Camera { get; }
    public extern float Distance { get; }
    public extern Quaternion pivotRotation { get; }

    public extern void AddTarget(Transform tgt);
    public extern Transform findNearestTarget();
    public extern void RemoveTarget(Transform tgt);
    public extern void SetDistance(float dist);
    public extern void setTarget(int tgtIdx);
    public extern void setTarget(Transform tgt);

    public enum Modes
    {
        FREE = 0,
        CHASE = 1,
    }
}
