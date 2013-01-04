#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

public class EditorLogic : MonoBehaviour
{
    public UIButton actionPanelBtn;
    public bool allowNodeAttachment;
    public bool allowSrfAttachment;
    public UIButton angleSnapButton;
    public PackedSprite angleSnapSprite;
    public AudioClip attachClip;
    public GameObject attachNodePrefab;
    public bool debugFlight;
    public AudioClip deletePartClip;
    public Vector3 dragPlaneCenter;
    public float dragSharpness;
    public Camera editorCamera;
    public static bool editorLocked;
    public EditorLogic.EditorScreen editorScreen;
    public EditorLogic.EditorMode editorType;
    public UIButton exitBtn;
    public static EditorLogic fetch;
    public Vector3 initialPodPosition;
    public Vector3 initialPodRotation;
    public UIButton launchBtn;
    public string launchSiteName;
    public UIButton loadBtn;
    public float maxHeight;
    public PackedSprite mirrorSprite;
    public GameObject[] modalAreas;
    public bool mouseGrab;
    public UIButton newBtn;
    public AudioClip partGrabClip;
    public UIButton partPanelBtn;
    public AudioClip partReleaseClip;
    public Quaternion partRotation;
    public UIButton saveBtn;
    public int sceneToLoad;
    public Vector3 selPartGrabOffset;
    public ShipConstruct ship;
    public GUISkin shipBrowserSkin;
    public Texture2D shipFileImage;
    public UITextField shipNameField;
    public static bool softLock;
    public float srfAttachAngleSnap;
    public static Part startPod;
    public string startPodId;
    public EditorLogic.EditorState state;
    public UIButton symmetryButton;
    public int symmetryMode;
    public PackedSprite symmetrySprite;

    public extern EditorLogic();

    public extern static int LayerMask { get; }
    public extern bool mouseOverGUI { get; }
    public extern static Quaternion PartRotation { get; }
    public extern Part PartSelected { get; set; }
    public extern static Part SelectedPart { get; }
    public extern static Texture2D ShipFileImage { get; }
    /// <summary>
    /// A list of all parts in the vessel that is being edited.
    /// </summary>
    public extern static List<Part> SortedShipList { get; }
    public extern EditorLogic.EditorState State { get; set; }
    public extern static Quaternion VesselRotation { get; }

    public extern bool AreAllPartsConnected();
    public extern int CountAllSceneParts(bool includeSelected);
    public extern static void DeletePart(Part part);
    public extern void DestroySelectedPart();
    public extern void editText();
    public extern static T GetComponentUpwards<T>(GameObject obj) where T : Component;
    public extern static Component GetComponentUpwards(string type, GameObject obj);
    public extern List<Part> getSortedShipList();
    public extern static void LoadShipFromFile(string path);
    public extern void Lock(bool lockLoad, bool lockExit, bool lockSave);
    public extern void OnPodSelect(AvailablePart pod);
    public extern void SelectPanelActions();
    public extern void SelectPanelParts();
    public extern void SetBackup();
    public extern void SetHighlightRecursive(bool recursive, List<Part> parts);
    public extern void SetHighlightRecursive(bool recursive, Part p);
    public extern void SetHighlightRecursive(bool recursive, ShipConstruct parts);
    public extern static void SetLayerRecursive(GameObject part, int layer, int ignoreLayersMask = 0);
    public extern static void SetSoftLock(bool lockState);
    public extern void snapButton();
    public extern void SpawnPart(AvailablePart part);
    public extern void symButton();
    public extern bool UndoRedo();
    public extern void Unlock();

    public enum EditorMode
    {
        VAB = 0,
        SPH = 1,
    }

    public enum EditorScreen
    {
        Parts = 0,
        Actions = 1,
        Staging = 2,
    }

    public enum EditorState
    {
        GUI_UNSELECTED = 0,
        GUI_SELECTED = 1,
        PAD_UNSELECTED = 2,
        PAD_SELECTED = 3,
    }
}
