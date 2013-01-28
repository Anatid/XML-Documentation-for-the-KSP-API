#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// This class stores some global information related to the map view.
/// </summary>
public class MapView : MonoBehaviour
{
    public float camDistance;
    public int camFocusTarget;
    public float camHdg;
    public float camPitch;
    public bool ConstantMode;
    public static int culledCaptions;
    public Material dottedLineMaterial;
    public bool draw3Dlines;
    public static MapView fetch;
    public FlightCamera mainCamera;
    public Camera[] mainCameras;
    public bool maneuverModeActive;
    public ScreenSafeUIButton maneuverModeToggle;
    public GameObject maneuverNodePrefab;
    public PlanetariumCamera mapCamera;
    public ScreenSafeUISlideTab MapCollapse_navBall;
    public static float MapIconTextOverlap;
    /// <summary>
    /// Whether the game is currently in map view or not.
    /// </summary>
    public static bool MapIsEnabled;
    public float masterOrbitOpacity;
    public float max3DlineDrawDist;
    public static Callback OnEnterMapView;
    public static Callback OnExitMapView;
    public ScreenSafeUIStateButton orbitDrawModeBtn;
    public Texture2D orbitIconsMap;
    public Material orbitIconsMaterial;
    public GUISkin orbitIconsTextSkin;
    public Material orbitLinesMaterial;
    public Color[] patchColors;
    public MonoBehaviour[] scriptsToDisable;
    public Transform spaceCameraHome;
    public static int totalCaptions;
    public float transitionDuration;
    public Camera[] uiCameras;
    public Camera vectorCam;

    public extern MapView();

    public extern static Material DottedLinesMaterial { get; }
    public extern static bool Draw3DLines { get; }
    public extern static bool ManeuverModeActive { get; }
    public extern static GameObject ManeuverNodePrefab { get; }
    public extern static PlanetariumCamera MapCamera { get; }
    public extern static int OrbitDrawMode { get; }
    public extern static Texture2D OrbitIconsMap { get; }
    public extern static Material OrbitIconsMaterial { get; }
    public extern static GUISkin OrbitIconsTextSkin { get; }
    public extern static Material OrbitLinesMaterial { get; }
    public extern static Color[] PatchColors { get; }

    /// <summary>
    /// Calling this function will cause the game to switch to map view from the flight view.
    /// </summary>
    public extern static void EnterMapView();
    /// <summary>
    /// Calling this function will cause the game to switch to flight view from the map view.
    /// </summary>
    public extern static void ExitMapView();
}
