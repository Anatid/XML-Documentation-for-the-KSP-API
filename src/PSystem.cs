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

    public PSystem();

    public PSystemBody AddBody(PSystemBody parent);
    [ContextMenu("Load Celestial Bodies Database")]
    public void LoadDatabase();
    public void Reset();
    [ContextMenu("Save Celestial Bodies Database")]
    public void SaveDatabase();
}
