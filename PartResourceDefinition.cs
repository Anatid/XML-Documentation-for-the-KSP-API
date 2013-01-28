#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// A PartResourceDefinition contains the basic information defining a type of resource.
/// </summary>
[Serializable]
public class PartResourceDefinition
{
    public extern PartResourceDefinition();

    /// <summary>
    /// The mass of this resource, per unit. This is not necessarily per unit volume, as resources
    /// don't have defined volumes. Instead resource "density" is the mass of one units of the resourc.e
    /// </summary>
    public extern float density { get; }
    /// <summary>
    /// The integer ID of this resource type.
    /// </summary>
    public extern int id { get; }
    /// <summary>
    /// The string ID of this resource type
    /// </summary>
    public extern string name { get; }
    /// <summary>
    /// How this resource does or does not flow between parts on a ship in response
    /// to resource requests by engines and the like.
    /// </summary>
    public extern ResourceFlowMode resourceFlowMode { get; }
    /// <summary>
    /// How this resource does or does not flow when using the resource transfer function?
    /// </summary>
    public extern ResourceTransferMode resourceTransferMode { get; }

    public extern void Load(ConfigNode node);
    public extern void Save(ConfigNode node);
}
