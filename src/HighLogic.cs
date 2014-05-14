#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;


/// <summary>
/// This class stores some very high-level information about the current game state.
/// </summary>
public class HighLogic : MonoBehaviour
{
    public Game currentGame;
    public static bool FastEditorLoading;
    /// <summary>
    /// Use this instance to access non-static members of this class.
    /// </summary>
    public static HighLogic fetch;
    public string GameSaveFolder;
    public static GameScenes LoadedScene;
    public static bool LoadedSceneHasPlanetarium;
    /// <summary>
    /// Whether the game is currently in the VAB or SPH scenes.
    /// </summary>
    public static bool LoadedSceneIsEditor;
    /// <summary>
    /// Whether the game is currently in the flight scene.
    /// </summary>
    public static bool LoadedSceneIsFlight;
    public int maxLines;
    public bool showConsole;
    public bool showConsoleOnError;
    public GUISkin skin;

    public extern HighLogic();

    public extern static Game CurrentGame { get; set; }
    public extern static string SaveFolder { get; set; }
    /// <summary>
    /// The GUISkin used by the game. Set GUI.skin = HighLogic.Skin at the start of your GUI function to use it yourself.
    /// </summary>
    public extern static GUISkin Skin { get; }

    public extern static void LoadScene(GameScenes scene);
    [ContextMenu("Debug Current Game")]
    public extern void printCurrentGame();

    public enum VK
    {
        BACK = 8,
        TAB = 9,
        RETURN = 13,
        SHIFT = 16,
        CONTROL = 17,
        MENU = 18,
        ESCAPE = 27,
        PRIOR = 33,
        NEXT = 34,
        END = 35,
        HOME = 36,
        LEFT = 37,
        UP = 38,
        RIGHT = 39,
        DOWN = 40,
        SELECT = 41,
        PRINT = 42,
        EXECUTE = 43,
        SNAPSHOT = 44,
        INSERT = 45,
        DELETE = 46,
        HELP = 47,
        LWIN = 91,
        RWIN = 92,
        NUMPAD0 = 96,
        NUMPAD1 = 97,
        NUMPAD2 = 98,
        NUMPAD3 = 99,
        NUMPAD4 = 100,
        NUMPAD5 = 101,
        NUMPAD6 = 102,
        NUMPAD7 = 103,
        NUMPAD8 = 104,
        NUMPAD9 = 105,
        MULTIPLY = 106,
        ADD = 107,
        SEPARATOR = 108,
        SUBTRACT = 109,
        DECIMAL = 110,
        DIVIDE = 111,
        F1 = 112,
        F2 = 113,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        F10 = 121,
        F11 = 122,
        F12 = 123,
        MEDIA_NEXT_TRACK = 176,
        MEDIA_PREV_TRACK = 177,
        MEDIA_STOP = 178,
        MEDIA_PLAY_PAUSE = 179,
        OEM_1 = 186,
        OEM_PLUS = 187,
        OEM_COMMA = 188,
        OEM_MINUS = 189,
        OEM_PERIOD = 190,
        OEM_2 = 191,
        OEM_3 = 192,
    }

    public class LogEntry
    {
        public string condition;
        public bool expanded;
        public LogType logType;
        public string stackTrace;

        public extern LogEntry(string condition, string stackTrace, LogType type);
    }
}
