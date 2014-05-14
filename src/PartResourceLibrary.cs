#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// The PartResourceLibrary lets you retrieve information about a resource type, given its name or integer id.
/// </summary>
public class PartResourceLibrary : MonoBehaviour
{
    [SerializeField]
    public PartResourceDefinitionList resourceDefinitions;
    public string resourceExtension;
    public string resourcePath;

    public extern PartResourceLibrary();

    /// <summary>
    /// Use this instance to access the methods of this class
    /// </summary>
    public extern static PartResourceLibrary Instance { get; }

    /// <summary>
    /// Gets information about a resource, specified by its integer ID.
    /// </summary>
    /// <param name="id">The integer ID of the resource</param>
    /// <returns>A PartResourceDefinition, which contains all the information about the resource</returns>
    public extern PartResourceDefinition GetDefinition(int id);
    /// <summary>
    /// Gets information about a resource, specified by its name as a string.
    /// </summary>
    /// <param name="name">The name of the resource, e.g. "ElectricCharge"</param>
    /// <returns>A PartResourceDefinition, which contains all the information about the resource</returns>
    public extern PartResourceDefinition GetDefinition(string name);
}
