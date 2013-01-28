#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// A FlightCtrlState is a snapshot of the state of all control inputs to a vessel at a given instant in time.
/// See FlightInputHandler.state and Vessel.OnFlyByWire.
/// </summary>
public class FlightCtrlState
{
    /// <summary>
    /// Unused?
    /// </summary>
    public float fastThrottle;
    /// <summary>
    /// Unused? Landing gear are lowered by sending an Event.
    /// </summary>
    public bool gearDown;
    /// <summary>
    /// Unused? Landing gear are raised by sending an Event.
    /// </summary>
    public bool gearUp;
    /// <summary>
    /// Presumably, whether the EVA headlight is turned on.
    /// </summary>
    public bool headlight;
    /// <summary>
    /// Whether SAS is turned on.
    /// </summary>
    public bool killRot;
    /// <summary>
    /// The throttle setting; this must be between 0 and 1.
    /// </summary>
    public float mainThrottle;
    /// <summary>
    /// The pitch control input; this must be between -1 and 1.
    /// </summary>
    public float pitch;
    /// <summary>
    /// Presumably, the pitch trim setting, i.e., the pitch input that will
    /// be given if no other input is given.
    /// </summary>
    public float pitchTrim;
    /// <summary>
    /// The roll control input; this must be between -1 and 1.
    /// </summary>
    public float roll;
    /// <summary>
    /// Presumably, the roll trim setting, i.e., the roll input that will
    /// be given if no other input is given.
    /// </summary>
    public float rollTrim;
    /// <summary>
    /// The RCS x-axis control input.
    /// </summary>
    public float X;
    /// <summary>
    /// The RCS y-axis control input.
    /// </summary>
    public float Y;
    /// <summary>
    /// The yaw control input; this must be between -1 and 1.
    /// </summary>
    public float yaw;
    /// <summary>
    /// Presumably, the yaw trim input; i.e., the yaw input that will be
    /// given if no other input is given.
    /// </summary>
    public float yawTrim;
    /// <summary>
    /// The RCS z-axis control input.
    /// </summary>
    public float Z;

    public extern FlightCtrlState();

    /// <summary>
    /// Presumably, whether this flight control represents "neutral" controls, i.e., no input and zero throttle.
    /// </summary>
    public extern bool isNeutral { get; }

    /// <summary>
    /// Presumably, copies the state of the FlightCtrlState st into this FlightCtrlState object.
    /// </summary>
    /// <param name="st"></param>
    public extern void CopyFrom(FlightCtrlState st);
}
