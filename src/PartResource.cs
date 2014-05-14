#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// A PartResource object represents the store of a single type of resource within a Part.
/// </summary>
public class PartResource : MonoBehaviour
{
    /// <summary>
    /// How much of the resource is in this part, in whatever units the resource uses.
    /// </summary>
    public double amount;
    public PartResource.FlowMode flowMode;
    public bool flowState;
    /// <summary>
    /// The definition of this type of resource, which contains all information about this resource type.
    /// </summary>
    public PartResourceDefinition info;
    /// <summary>
    /// The maximum amount of this resource that this part can hold.
    /// </summary>
    public double maxAmount;
    /// <summary>
    /// The part whose stored resource this object represents
    /// </summary>
    public Part part;
    /// <summary>
    /// The name of this resource, as a string, e.g. "ElectricCharge"
    /// </summary>
    public string resourceName;

    public extern PartResource();

    public extern string GetInfo();
    public extern void Load(ConfigNode node);
    public extern void Save(ConfigNode node);
    public extern void SetInfo(PartResourceDefinition info);

    public enum FlowMode
    {
        Both = 0,
        Out = 1,
        In = 2,
        None = 3,
    }
}
