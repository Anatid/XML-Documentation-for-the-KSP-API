#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// The class that handles time warp.
/// </summary>
public class TimeWarp : MonoBehaviour
{
    /// <summary>
    /// Unused? CelestialBodies have their own sets of altitude limits.
    /// </summary>
    public float[] altitudeLimits;
    public int current_rate_index;
    /// <summary>
    /// Use this TimeWarp instance to access non-static members. 
    /// </summary>
    public static TimeWarp fetch;
    public int maxModeSwitchRate_index;
    public int maxPhysicsRate_index;
    public TimeWarp.Modes Mode;
    /// <summary>
    /// The available physics warp rates. In 0.18.2 these are {1, 2, 3, 4} by default. You can modify the
    /// available rates by modifying this array.
    /// </summary>
    public float[] physicsWarpRates;
    public GUIStyle screenTextStyle;
    public float textDuration;
    public ScreenSafeUISlideTab timeQuadrantTab;
    public ScreenSafeUISliderButton warpHighButton;
    public ScreenSafeUISliderButton warpLowButton;
    /// <summary>
    /// The available regular warp rates. In 0.18.2 these are {1, 5, 10, 50, 100, 1000, 10000, 100000} by default.
    /// You can modify the available rates by modifying this array.
    /// </summary>
    public float[] warpRates;

    public extern TimeWarp();

    /// <summary>
    /// The current warp rate, e.g. 50 if the current warp rate is 50x. This number
    /// may not be equal to one of the entries in warpRates, because KSP will smoothly
    /// interpolate between two warp rates over a period of time when you increase
    /// or decrease the warp.
    /// </summary>
    public extern static float CurrentRate { get; }
    /// <summary>
    /// The index of the current current warp rate in either warpRates or physicsWarpRates, depending
    /// on whether WarpMode is HIGH or LOW. Note that CurrentRate may not equal the warp rate indexed
    /// by CurrentRateIndex if KSP has not finished interpolating the last warp change.
    /// </summary>
    public extern static int CurrentRateIndex { get; }
    public extern static float deltaTime { get; }
    /// <summary>
    /// The time between FixedUpdate cycles (i.e., the time between physics steps). See the Unity FixedUpdate
    /// documentation for more details.
    /// </summary>
    public extern static float fixedDeltaTime { get; }
    public extern static float MaxPhysicsRate { get; }
    /// <summary>
    /// Whether we are in regular warp mode or physics warp mode
    /// </summary>
    public extern static TimeWarp.Modes WarpMode { get; }

    /// <summary>
    /// Presumably, gets the minimum altitude in meters above the sea level of the given body at which the
    /// given warp rate index is allowed.
    /// </summary>
    /// <param name="i">A warp rate index</param>
    /// <param name="body">The body in question</param>
    /// <returns>The minimum altitude in meters at which that warp rate index is allowed</returns>
    public extern double GetAltitudeLimit(int i, CelestialBody body);
    /// <summary>
    /// Changes the warp rate to either warpRates[rateIndex] or physicsWarpRates[rate_index], depending
    /// on whether WarpMode is HIGH or LOW.
    /// </summary>
    /// <param name="rate_index">The index of the desired new warp rate</param>
    /// <param name="instant">If false, KSP will gradually smoothly adjust the warp rate up or down until it reaches the target.
    /// If true, the warp rate will change instantly.</param>
    public extern static void SetRate(int rate_index, bool instant);

    public enum Modes
    {
        /// <summary>
        /// Reguar time warp mode
        /// </summary>
        HIGH = 0,
        /// <summary>
        /// Physics warp mode
        /// </summary>
        LOW = 1,
    }
}
