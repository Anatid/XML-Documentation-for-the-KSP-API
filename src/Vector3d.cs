#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Reflection;
using UnityEngine;

/// <summary>
/// A Vector3d in 3D space.
/// Vector3d is just like Unity's Vector3 class, except it uses doubles instead of floats,
/// so refer to the Unity documentation on Vector3.
/// Vector3d also adds a few functions.
/// </summary>
public struct Vector3d
{
    public const float kEpsilon = 1e-005f;

    public double x;
    public double y;
    public double z;

    public extern Vector3d(double x, double y);
    public extern Vector3d(double x, double y, double z);

    public extern static Vector3d operator -(Vector3d a);
    public extern static Vector3d operator -(Vector3 a, Vector3d b);
    public extern static Vector3d operator -(Vector3d a, Vector3 b);
    public extern static Vector3d operator -(Vector3d a, Vector3d b);
    public extern static bool operator !=(Vector3d lhs, Vector3d rhs);
    public extern static Vector3d operator *(double d, Vector3d a);
    public extern static Vector3d operator *(Vector3d a, double d);
    public extern static Vector3d operator /(Vector3d a, double d);
    public extern static Vector3d operator +(Vector3 a, Vector3d b);
    public extern static Vector3d operator +(Vector3d a, Vector3 b);
    public extern static Vector3d operator +(Vector3d a, Vector3d b);
    public extern static bool operator ==(Vector3d lhs, Vector3d rhs);
    public extern static implicit operator Vector3d(Vector3 v);
    public extern static implicit operator Vector3(Vector3d v);

    /// <summary>
    /// Minus forward
    /// </summary>
    public static Vector3d back { get { return Vector3d.zero; } }
    /// <summary>
    /// Minus up
    /// </summary>
    public static Vector3d down { get { return Vector3d.zero; } }
    public static Vector3d forward { get { return Vector3d.zero; } }
    [Obsolete("Use Vector3.forward instead.")]
    public static Vector3d fwd { get { return Vector3d.zero; } }
    /// <summary>
    /// Minus right.
    /// </summary>
    public static Vector3d left { get { return Vector3d.zero; } }
    public double magnitude { get { return 0;  } }
    public Vector3d normalized { get { return Vector3d.zero; } }
    public static Vector3d one { get { return Vector3d.zero; } }
    public static Vector3d right { get { return Vector3d.zero; } }
    public double sqrMagnitude { get { return 0; } }
    public static Vector3d up { get { return Vector3d.zero; } }
    /// <summary>
    /// Returs a new Vector3d with the y and z coordinates swapped?
    /// </summary>
    public Vector3d xzy { get { return Vector3d.zero; } }
    public static Vector3d zero { get { return Vector3d.zero; } }

    public double this[int index] { get { return 0; } set { } }

    public extern static double Angle(Vector3d from, Vector3d to);
    [Obsolete("Use Vector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
    public extern static double AngleBetween(Vector3d from, Vector3d to);
    public extern static Vector3d Cross(Vector3d lhs, Vector3d rhs);
    public extern static double Distance(Vector3d a, Vector3d b);
    public extern static double Dot(Vector3d lhs, Vector3d rhs);
    public extern override bool Equals(object other);
    /// <summary>
    /// Returns <code>fromThat - Vector3d.Project(fromThat, excludeThis)</code>. That is, it removes
    /// the component of fromThat that is parallel to excludeThis and returns the remainder, which will
    /// be perpendicular to excludeThis.
    /// </summary>
    /// <param name="excludeThis">The direction to exclude from the result.</param>
    /// <param name="fromThat">The starting vector</param>
    /// <returns>A vector perpendicular to excludeThis and pointing in the same general direction as fromThat.</returns>
    public extern static Vector3d Exclude(Vector3d excludeThis, Vector3d fromThat);
    public extern override int GetHashCode();
    public extern static Vector3d Lerp(Vector3d from, Vector3d to, float t);
    public extern static double Magnitude(Vector3d a);
    public extern static Vector3d Max(Vector3d lhs, Vector3d rhs);
    public extern static Vector3d Min(Vector3d lhs, Vector3d rhs);
    public extern void Normalize();
    public extern static Vector3d Normalize(Vector3d value);
    public extern static void OrthoNormalize(ref Vector3d normal, ref Vector3d tangent);
    public extern static void OrthoNormalize(ref Vector3d normal, ref Vector3d tangent, ref Vector3d binormal);
    public extern static Vector3d Project(Vector3d vector, Vector3d onNormal);
    public extern static Vector3d Reflect(Vector3d inDirection, Vector3d inNormal);
    public extern static Vector3d RotateTowards(Vector3d from, Vector3d to, float maxRadiansDelta, float maxMagnitudeDelta);
    public extern void Scale(Vector3d scale);
    public extern static Vector3d Scale(Vector3d a, Vector3d b);
    public extern static Vector3d Slerp(Vector3d from, Vector3d to, float t);
    public extern static double SqrMagnitude(Vector3d a);
    public extern override string ToString();
}
