using System;
using UnityEngine;

/// <summary>
/// A class representing temporary messages posted to the screen. Don't use this class, use the static methods in ScreenMessages instead.
/// </summary>
public class ScreenMessage
{
    public float duration;
    public GUIStyle guiStyleOverride;
    public string message;
    public bool persistAcrossScenes;
    public float startTime;
    public ScreenMessageStyle style;

    public extern ScreenMessage(string msg, float dur, ScreenMessageStyle s);
    public extern ScreenMessage(string msg, float dur, bool persistAcrossScenes, ScreenMessageStyle s);
    public extern ScreenMessage(string msg, float dur, ScreenMessageStyle s, GUIStyle guiStyle);
    public extern ScreenMessage(string msg, float dur, bool persistAcrossScenes, ScreenMessageStyle s, GUIStyle guiStyle);
}
