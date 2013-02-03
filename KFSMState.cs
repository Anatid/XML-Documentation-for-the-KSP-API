#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;

/// <summary>
/// Represents a state in a KerbalFSM finite state machine.
/// </summary>
public class KFSMState
{
    public int FrameCountAtStateEnter;
    /// <summary>
    /// The name of this state.
    /// </summary>
    public string name;
    /// <summary>
    /// You can assign to this field a delegate that takes a KFSMState (which will be this state).
    /// The delegate will be called when the state machine enters this state.
    /// </summary>
    public KFSMStateChange OnEnter;
    /// <summary>
    /// You can assign a delegate to this field, and the delegate will be called during each FixedUpdate
    /// while the state machine is in this state.
    /// </summary>
    public KFSMCallback OnFixedUpdate;
    /// <summary>
    /// You can assign a delegate to this field, and the delegate will be called during each LateUpdate
    /// while the state machine is in this state.
    /// </summary>
    public KFSMCallback OnLateUpdate;
    /// <summary>
    /// You can assign to this field a delegate that takes a KFSMState. The delegate will be called
    /// when the state machine leaves this state, and the argument passed to the delegate will be
    /// the new state that the machine is transitioning to.
    /// </summary>
    public KFSMStateChange OnLeave;
    /// <summary>
    /// You can assign a delegate to this field, and the delegate will be call during each Update while
    /// the state machine is in this state.
    /// </summary>
    public KFSMCallback OnUpdate;
    protected List<KFSMEvent> stateEvents;
    public double TimeAtStateEnter;
    public KFSMUpdateMode updateMode;

    /// <summary>
    /// Create a new KFSMState with a given name.
    /// </summary>
    /// <param name="name">The name of the new state.</param>
    public extern KFSMState(string name);

    /// <summary>
    /// The set of events that are valid for this state (i.e., the possible transitions from this state).
    /// </summary>
    public extern List<KFSMEvent> StateEvents { get; }

    /// <summary>
    /// Add an event (possible transition) to this state.
    /// </summary>
    /// <param name="ev">The event to add.</param>
    public extern void AddEvent(KFSMEvent ev);
    /// <summary>
    /// Whether the given event can be triggered from this state. An event must be added to a state before
    /// it can be triggered from that state.
    /// </summary>
    /// <param name="ev">The event to check.</param>
    /// <returns>Whether the event can be triggered from this state.</returns>
    public extern bool IsValid(KFSMEvent ev);
    public extern override string ToString();
}
