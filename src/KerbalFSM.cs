#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;

/// <summary>
/// A finite state machine. States are represented by KFSMState objects, and 
/// "events" (transitions between states) are represented by KFSMEvent objects.
/// </summary>
[Serializable]
public class KerbalFSM
{
    protected KFSMState currentState;
    /// <summary>
    /// The name of the state the machine is currently in.
    /// </summary>
    public string currentStateName;
    public bool DebugBreakOnStateChange;
    protected bool fsmStarted;
    protected KFSMEvent lastEvent;
    /// <summary>
    /// The name of the last event that occurred.
    /// </summary>
    public string lastEventName;
    protected KFSMState lastState;
    protected List<KFSMState> States;

    public extern KerbalFSM();

    /// <summary>
    /// The state the machine is currently in.
    /// </summary>
    public extern KFSMState CurrentState { get; }
    /// <summary>
    /// How many frames the machine has been in this state.
    /// </summary>
    public extern int FramesInCurrentState { get; }
    /// <summary>
    /// The last event that occurred.
    /// </summary>
    public extern KFSMEvent LastEvent { get; }
    /// <summary>
    /// The state the machine was in before this state.
    /// </summary>
    public extern KFSMState LastState { get; }
    /// <summary>
    /// Whether the state machine has been started.
    /// </summary>
    public extern bool Started { get; }
    /// <summary>
    /// How long the machine has been in the current state, in seconds.
    /// </summary>
    public extern double TimeAtCurrentState { get; }

    /// <summary>
    /// Add a new event (possible transition) to the finite state machine.
    /// </summary>
    /// <param name="ev">The event to add.</param>
    /// <param name="toStates">The states to add the event to. The event can only be triggered when
    /// the machine is in one of these states.</param>
    public extern void AddEvent(KFSMEvent ev, params KFSMState[] toStates);
    /// <summary>
    /// Add a new event (possible transition) to the finite state machine.
    /// </summary>
    /// <param name="ev">The event to add.</param>
    /// <param name="excStates">A list of states *not* to add the event to. The event can only be triggered
    /// when the machine is *not* in one of these states.</param>
    public extern void AddEventExcluding(KFSMEvent ev, params KFSMState[] excStates);
    /// <summary>
    /// Add a new possible state to the machine.
    /// </summary>
    /// <param name="st">The state to add.</param>
    public extern void AddState(KFSMState st);
    public extern void FixedUpdateFSM();
    public extern void LateUpdateFSM();
    /// <summary>
    /// Cause the machine to execute the transition specified by evt.
    /// </summary>
    /// <param name="evt">The event to execute.</param>
    public extern void RunEvent(KFSMEvent evt);
    /// <summary>
    /// Start the state machine in a given initial state.
    /// </summary>
    /// <param name="initialState">The state to start in.</param>
    public extern void StartFSM(KFSMState initialState);
    /// <summary>
    /// Start the state machine in a given initial state.
    /// </summary>
    /// <param name="initialStateName">The name of the state to start in</param>
    public extern void StartFSM(string initialStateName);
    public extern void UpdateFSM();
    protected extern void updateFSM(KFSMUpdateMode mode);
}
