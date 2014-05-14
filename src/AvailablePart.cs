#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// An AvailablePart object contains the summary information about a single type of part
/// which is shown in the editor.
/// </summary>
[Serializable]
public class AvailablePart
{
    public int amountAvailable;
    [Persistent]
    public string author;
    /// <summary>
    /// Which tab this part shows up in in the editor.
    /// </summary>
    public PartCategories category;
    /// <summary>
    /// The cost of this part, as displayed in the editor.
    /// </summary>
    public int cost;
    /// <summary>
    /// The description of this part, as displayed in the editor? 
    /// Does this include the GetInfo() of the part's PartModules?
    /// </summary>
    public string description;
    public Vector3 iconOffset;
    public GameObject iconPrefab;
    public Vector3 iconScale;
    public string iconUrl;
    public ConfigNode internalConfig;
    public string manufacturer;
    public string moduleInfo;
    public string name;
    /// <summary>
    /// The object that gets cloned when you create a new instance of this part in the editor?
    /// </summary>
    public Part partPrefab;
    public string partUrl;
    public string resourceInfo;
    public string title;
    public string typeDescription;

    public extern AvailablePart(string path);

    public extern string partPath { get; }
}
