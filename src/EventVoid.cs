
using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A type used to generate GameEvents
/// 
/// Use this type when there is no need to accompany the event with any parameters,
/// ie relevant Part, Vessel, CelestialBody, etc...
/// 
/// See EventData for events that require such extra information
/// </summary>
public class EventVoid
{
	/// <summary>
	/// Generate debug logs if true
	/// </summary>
	public bool debugEvent;

	/// <summary>
	/// The constructor used to create a new EventVoid
	/// 
	/// EventVoid myNewEvent = new EventVoid("myNewEvent");
	/// </summary>
	/// <param name="eventName">Give the event a string name,
	/// generally the same as the declared name</param>
	public EventVoid(string eventName);

	/// <summary>
	/// Add a method to be run when the EventVoid is fired.
	/// 
	/// This is generally done in an object's Start or Awake method, or a class' constructor.
	/// 
	/// Can be setup like:
	/// 
	/// GameEvents.someEventVoidEvent.Add(yourMethod);
	/// 
	/// or
	/// 
	/// GameEvents.someEventVoidEvent.Add(new EventVoid.OnEvent(yourMethod));
	/// </summary>
	/// <param name="evt">The method you want to add, should contain no parameters</param>
	public void Add(EventVoid.OnEvent evt);
	public static bool AddEventScene(string eventName, EventVoid.OnEvent evt, bool addToAll);
	public static bool AddEventUpwards(Transform transform, string eventName, EventVoid.OnEvent evt, bool addToAll);
	public static EventVoid FindEventScene(string eventName);
	public static List<EventVoid> FindEventsScene(string eventName);
	public static List<EventVoid> FindEventsUpwards(Transform transform, string eventName);
	public static EventVoid FindEventUpwards(Transform transform, string eventName);
	/// <summary>
	/// Triggers the EventVoid
	/// 
	/// All of the methods added using Add are run after this.
	/// </summary>
	public void Fire();
	/// <summary>
	/// Remove a method from the list of methods to be run when the EventVoid is fired.
	/// 
	/// This is generally done in an object's OnDestroy method.
	/// </summary>
	/// <param name="evt">The method you want to remove, should contain no parameters</param>
	public void Remove(EventVoid.OnEvent evt);
	public static bool RemoveEventScene(string eventName, EventVoid.OnEvent evt, bool removeFromAll);
	public static bool RemoveEventUpwards(Transform transform, string eventName, EventVoid.OnEvent evt, bool removeFromAll);

	/// <summary>
	/// Any methods added to the event must match the delegate's parameters; none in this case
	/// </summary>
	public delegate void OnEvent();
}
