#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// Apply this attribute to a function in a PartModule to make it callable by the player via
/// the right click menu of the part, or from other plugin code via Part.SendEvent.
/// </summary>
///
/// It seems like this attribute is NOT refreshed on parts already in flight when you rebuild 
/// your module DLL! You need to launch a new ship with your part.
///
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class KSPEvent : Attribute
{
    /// <summary>
    /// Whether this event can be triggered through Part.SendEvent.
    /// </summary>
    public bool active;
    public string category;
    /// <summary>
    /// Whether the event is only available when out on EVA.
    /// </summary>
    public bool externalToEVAOnly;
    /// <summary>
    /// Whether the event is shown as available in the right click menu (active must also be true).
    /// </summary>
    public bool guiActive;
    /// <summary>
    /// Whether the event is shown as available in the right click menu even when
    /// the part is on a ship not currently being controlled by the player (but
    /// close enough to right click).
    /// </summary>
    public bool guiActiveUnfocused;
    public string guiIcon;
    /// <summary>
    /// The name shown for the event in the right click menu.
    /// </summary>
    public string guiName;
    public bool isDefault;
    /// <summary>
    /// The name of the event, which can be used to trigger the event using from plugin code using Part.SendEvent.
    /// </summary>
    public string name;
    /// <summary>
    /// When the part is on a ship not being controlled by the player,
    /// how close the player needs to be (in meters) in order for the event to appear in the right click menu.
    /// </summary>
    public float unfocusedRange;

    public extern KSPEvent();
}
