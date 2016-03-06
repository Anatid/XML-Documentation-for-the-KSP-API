using System;
using UnityEngine;

/// <summary>
/// Controls the date/time display at the bottom center of the space center.
/// Can be retrieved with <code>UTClock utClock = GameObject.FindObjectOfType<UTClock>();</code>.
///
/// The actual text field containting the text is a private member of this behavior but
/// can be retrieved with <code>ScreenSafeTextField textField =
/// utClock.gameObject.GetComponent<ScreenSafeTextField>();</code>.
/// </summary>
[RequireComponent(typeof(ScreenSafeTextField))]
public class UTClock : MonoBehaviour
{
	/// <summary>
	/// Whether to include seconds in the text field (false).
	/// </summary>
	public bool includeSeconds;
	
	/// <summary>
	/// Whether to include hours and minutes in the text field (true).
	/// </summary>
	public bool includeTimeOfDay;
	
	public double Tdawn;

	/// <summary>
	/// The button 'Warp to next Morning' to the right of the text field.
	/// </summary>
	public ScreenSafeUIButton warpToDaylight;

	public UTClock();
}