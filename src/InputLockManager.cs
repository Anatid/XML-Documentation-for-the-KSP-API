using System;
using System.Collections.Generic;

/// <summary>
/// This class lets you lock the player out of certain controls. It's
/// probably what KSP uses internally to lock controls during time warp,
/// or when out of electric charge. 
/// </summary>
/// <remarks>
/// You can view the current set of locks in-game with the Alt-F12 debug menu.
/// </remarks>
public static class InputLockManager
{
    public static ulong lockMask;
    /// <summary>
    /// The set of locks currently in place?
    /// </summary>
    public static Dictionary<string, ulong> lockStack;

    /// <summary>
    /// If <code>ControlTypes.X &amp; LockMask != 0</code> then ControlTypes.X is locked?
    /// </summary>
    public static extern ulong LockMask { get; }

    public static extern void ClearControlLocks();
    public static extern ControlTypes GetControlLock(string lockID);
    public static extern bool IsLocked(ControlTypes controlType);
    public static extern bool IsLocked(ControlTypes controlType, ControlTypes refMask);
    public static extern bool IsUnlocked(ControlTypes controlType);
    public static extern bool IsUnlocked(ControlTypes controlType, ControlTypes refMask);
    public static extern string PrintLockStack();
    /// <summary>
    /// Unlock a set of controls that were earlier locked with SetControlLock.
    /// </summary>
    /// <param name="lockID">The string ID passed to SetControlLock.</param>
    public static extern void RemoveControlLock(string lockID);
    public static extern ControlTypes SetControlLock(string lockID);
    /// <summary>
    /// Locks a set of controls.
    /// </summary>
    /// <param name="locks">Which controls to lock. You can OR several ControlTypes together to lock several types of controls at once.</param>
    /// <param name="lockID">A unique string ID that you will pass to RemoveControlLock to unlock these controls.</param>
    /// <returns>?</returns>
    public static extern ControlTypes SetControlLock(ControlTypes locks, string lockID);
}
