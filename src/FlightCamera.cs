#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// This class is related to control of the main camera used in the flight scene. Its transform is the
/// parent of the actual Camera objects.
/// </summary>
public class FlightCamera : MonoBehaviour
{
    public FlightCamera.Modes autoMode;
    public Camera[] cameras;
    public float cameraWobbleSensitivity;
    public float camHdg;
    public float camPitch;
    public Vector3 endDirection;
    /// <summary>
    /// Returns the singleton FlightCamera object.
    /// </summary>
    public static FlightCamera fetch;
    public FoRModes FoRMode;
    public float fovDefault;
    public float maxDistance;
    public float maxPitch;
    public float minDistance;
    public float minHeight;
    public float minHeightAtMaxDist;
    public float minHeightAtMinDist;
    public float minPitch;
    public FlightCamera.Modes mode;
    public GUIStyle modeReadoutStyle;
    public float orbitSensitivity;
    public float orientationSharpness;
    public float pivotTranslateSharpness;
    public float sharpness;
    public float startDistance;
    public Vector3 targetDirection;
    public bool updateActive;
    public float zoomScaleFactor;

    public extern FlightCamera();

    /// <summary>
    /// You can set this to change the look direction of the in-flight camera (value is in radians).
    /// </summary>
    public extern static float CamHdg { get; set; }
    public extern static int CamMode { get; }
    /// <summary>
    /// You can set this to change the look direction of the in-flight camera (value is in radians).
    /// </summary>
    public extern static float CamPitch { get; set; }
    public extern float Distance { get; }
    public extern static FoRModes FrameOfReferenceMode { get; }
    public extern Quaternion pivotRotation { get; }

    /// <summary>
    /// Enables mouse control of the camera.
    /// </summary>
    public extern void ActivateUpdate();
    /// <summary>
    /// Disables mouse control of the camera.
    /// </summary>
    public extern void DeactivateUpdate();
    public extern void DisableCamera();
    public extern void EnableCamera();
    public extern void ResetFoV();
    public extern void SetDistance(float dist);
    public extern void SetDistanceImmediate(float dist);
    public extern void SetFoV();
    public extern void SetFoV(float fov);
    public extern void setMode(FlightCamera.Modes m);
    public extern static void SetMode(FlightCamera.Modes m);
    public extern void setModeImmediate(FlightCamera.Modes m);
    public extern static void SetModeImmediate(FlightCamera.Modes m);
    public extern void SetNextMode();
    public extern void setTarget(Transform tgt);
    public extern static void SetTarget(Transform tgt);

    public enum Modes
    {
        AUTO = 0,
        FREE = 1,
        ORBITAL = 2,
        CHASE = 3,
    }
}
