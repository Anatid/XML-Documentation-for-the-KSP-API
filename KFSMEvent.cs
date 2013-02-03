#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// A KFSMEvent represents a possible transition between two KFSMStates in a KerbalFSM
/// finite state machine.
/// </summary>
public class KFSMEvent
{
    /// <summary>
    /// Which state to transition to when this event is triggered.
    /// </summary>
    public KFSMState GoToStateOnEvent;
    /// <summary>
    /// The name of the event.
    /// </summary>
    public string name;
    /// <summary>
    /// You can assign to this field a delegate that takes a KFSMState (the current state)
    /// and returns a bool. The function will be called each frame and if it returns true,
    /// the event is triggered.
    /// </summary>
    public KFSMEventCondition OnCheckCondition;
    /// <summary>
    /// You can assign a delegate to this field, and the delegate will be run when the event is triggered.
    /// </summary>
    public KFSMCallback OnEvent;
    /// <summary>
    /// Specifies when OnCheckCondition should be checked?
    /// </summary>
    public KFSMUpdateMode updateMode;

    /// <summary>
    /// Creates a new KFSMEvent
    /// </summary>
    /// <param name="name">The name of the event.</param>
    public extern KFSMEvent(string name);

    /// <summary>
    /// Whether this event can be triggered when the state machine is in the given state.
    /// Events must be added to states through KerbalFSM.AddEvent before they can be triggered,
    /// and they can only be triggered when the machine is in one of the states to which they
    /// have been added.
    /// </summary>
    /// <param name="state">The state to check.</param>
    /// <returns>Whether the event can be triggered from the given state.</returns>
    public extern bool IsValid(KFSMState state);
}
