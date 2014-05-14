#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class that handles the transformations between the scaled-down coordinate system used by the map view and the 
/// regular coordinate system used by the main flight view and the physics.
/// </summary>
public class ScaledSpace : MonoBehaviour
{
    public Transform originTarget;
    public List<Transform> scaledSpaceTransforms;
    public float scaleFactor;

    public extern ScaledSpace();

    public extern static float InverseScaleFactor { get; }
    /// <summary>
    /// "Scaled space" is the coordinate system used by the planetarium view. It's the same coordinate system as
    /// the world coordinates used by the physics, except scaled down by this scale factor.
    /// </summary>
    public extern static float ScaleFactor { get; }
    public extern static Transform SceneTransform { get; }

    public extern static void AddScaledSpaceTransform(Transform t);
    /// <summary>
    /// Convert a position in world coordinates into a position in planetarium coordinates.
    /// </summary>
    /// <param name="localSpacePoint">A position in world coordinates</param>
    /// <returns>The corresponding position in planetarium coordinates</returns>
    public extern static Vector3d LocalToScaledSpace(Vector3d localSpacePoint);
    public extern static void RemoveScaledSpaceTransform(Transform t);
    /// <summary>
    /// Convert a position in planetarium coordinates into a position in world coordinates.
    /// </summary>
    /// <param name="scaledSpacePoint">A position in planetarium coordinates.</param>
    /// <returns>The corresponding position in world coordinates.</returns>
    public extern static Vector3d ScaledToLocalSpace(Vector3d scaledSpacePoint);
}
