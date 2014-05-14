#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class that lets you post temporary messages to the screen. If you use this class your messages will
/// automatically have the same style as regular in-game messages.
/// </summary>
public class ScreenMessages : MonoBehaviour
{
    /// <summary>
    /// The set of currently active screen messages. This is a non-static member, but you can get a
    /// reference to the ScreenMessages instance via
    /// <code>ScreenMessages sm = (ScreenMessages)GameObject.FindObjectOfType(typeof(ScreenMessages));</code>
    /// </summary>
    public List<ScreenMessage> activeMessages;
    public GUIStyle[] textStyles;
    public bool useRenderQueue;

    public extern ScreenMessages();

    /// <summary>
    /// Post a temporary message to the screen. Examples of screen messages are the "Warp = {number}x" message
    /// and the "Quicksaving..." message.
    /// </summary>
    /// <param name="msg">The message to post</param>
    public extern static void PostScreenMessage(ScreenMessage msg);
    /// <summary>
    /// Post a temporary message to the screen. Examples of screen messages are the "Warp = {number}x" message
    /// and the "Quicksaving..." message.
    /// </summary>
    /// <param name="message">The message to post.</param>
    /// <returns>A reference to the posted message</returns>
    public extern static ScreenMessage PostScreenMessage(string message);
    /// <summary>
    /// Post a temporary message to the screen. Examples of screen messages are the "Warp = {number}x" message
    /// and the "Quicksaving..." message.
    /// </summary>
    /// <param name="message">The message to post</param>
    /// <param name="duration">How long the message should remain on the screen, in seconds.</param>
    /// <returns>A reference to the posted message</returns>
    public extern static ScreenMessage PostScreenMessage(string message, float duration);
    /// <summary>
    /// Post a temporary message to the screen. Examples of screen messages are the "Warp = {number}x" message
    /// and the "Quicksaving..." message.
    /// </summary>
    /// <param name="message">The message to post</param>
    /// <param name="duration">How long the message should remain on the screen, in seconds.</param>
    /// <param name="style">Which style of screen message to post--for instance, should it by like the warp message, the quicksaving message, etc.</param>
    /// <returns>A reference to the posted message</returns>
    public extern static ScreenMessage PostScreenMessage(string message, float duration, ScreenMessageStyle style);
    /// <summary>
    /// Remove a currently active message from the screen.
    /// </summary>
    /// <param name="msg">The message to remove</param>
    public extern static void RemoveMessage(ScreenMessage msg);
}

/// <summary>
/// An enumeration of the different styles of message you can display.
/// </summary>
public enum ScreenMessageStyle
{
    /// <summary>
    /// This results in a message in the same font and position as the "Warp = {number}x" message.
    /// </summary>
    UPPER_CENTER = 0,
    /// <summary>
    /// What sort of message style does this produce?
    /// </summary>
    UPPER_LEFT = 1,
    /// <summary>
    /// This results in a message in the same font and position as the "Quicksaving..." message.
    /// </summary>
    UPPER_RIGHT = 2,
    /// <summary>
    /// What sort of message style does this produce?
    /// </summary>
    LOWER_CENTER = 3,
}
