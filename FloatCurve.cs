#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// Represents a function of one variable. The function is interpolated from a given set of points,
/// and optionally the tangents at those points can be specified.
/// </summary>
[Serializable]
public class FloatCurve /* : IConfigNode */
{
    public extern FloatCurve();

    public extern float maxTime { get; }
    public extern float minTime { get; }

    public extern void Add(float time, float value);
    public extern void Add(float time, float value, float inTangent, float outTangent);
    /// <summary>
    /// Evaluate the function at a given value of the input parameter.
    /// </summary>
    /// <param name="time">The input parameter (not necessarily a time).</param>
    /// <returns>The value of the function.</returns>
    public extern float Evaluate(float time);
    public void Load(ConfigNode node) { }
    public void Save(ConfigNode node) { }
}
