using System;
using UnityEngine;

[AddComponentMenu("KSP/SolarSystem/PSystem")]
public class PSystem : MonoBehaviour
{
    [HideInInspector]
    public int mainToolbarSelected;
    public PSystemBody rootBody;
    public string systemName;
    public double systemScale;
    public double systemTimeScale;

    public extern PSystem();

    public extern PSystemBody AddBody(PSystemBody parent);
    [ContextMenu("Load Celestial Bodies Database")]
    public extern void LoadDatabase();
    public extern void Reset();
    [ContextMenu("Save Celestial Bodies Database")]
    public extern void SaveDatabase();
}
