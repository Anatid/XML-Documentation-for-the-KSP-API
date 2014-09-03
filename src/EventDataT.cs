
using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A type used to generate GameEvents
/// 
/// Use this type with one accompanying type;
/// GameEvents.FromToAction,
/// GameEvents.HostedFromToAction,
/// GameEvents.HostTargetAction
/// are commonly used
/// 
/// See EventVoid for events that require no parameters
/// or EventReport for a different style
/// </summary>
/// <typeparam name="T">The type to be passed through on EventData.Fire()</typeparam>
public class EventData<T>
{
	/// <summary>
	/// Generate debug logs if true
	/// </summary>
	public bool debugEvent;

	/// <summary>
	/// The constructor used to create a new EventData
	/// 
	/// EventData&lt;Vessel&gt; myNewEvent = new EventData&lt;Vessel&gt;("myNewEvent");
	/// </summary>
	/// <param name="eventName">Give the event a string name,
	/// generally the same as the declared name</param>
    public extern EventData(string eventName);

	/// <summary>
	/// Add a method to be run when the EventData is fired.
	/// 
	/// This is generally done in an object's Start or Awake method, or a class' constructor.
	/// 
	/// Can be setup like:
	/// 
	/// GameEvents.someEventDataEvent.Add(yourMethod);
	/// 
	/// or
	/// 
	/// GameEvents.someEventDataEvent.Add(new EventVoid.OnEvent(yourMethod));
	/// </summary>
	/// <param name="evt">The method you want to add; must contain a single parameter
	/// of the type matching that in the host EventData</param>
    public extern void Add(EventData<T>.OnEvent evt);
    public extern static bool AddEventScene(string eventName, EventData<T>.OnEvent evt, bool addToAll);
    public extern static bool AddEventUpwards(Transform transform, string eventName, EventData<T>.OnEvent evt, bool addToAll);
    public extern static EventData<T> FindEventScene(string eventName);
    public extern static List<EventData<T>> FindEventsScene(string eventName);
    public extern static List<EventData<T>> FindEventsUpwards(Transform transform, string eventName);
    public extern static EventData<T> FindEventUpwards(Transform transform, string eventName);
	/// <summary>
	/// Triggers the EventData
	/// 
	/// All of the methods added using Add are run after this.
	/// </summary>
	/// <param name="data">Single parameter matching the type of the host EventData
	/// Use this to give information relevant to the event</param>
    public extern void Fire(T data);
	/// <summary>
	/// Remove a method from the list of methods to be run when the EventData is fired.
	/// 
	/// This is generally done in an object's OnDestroy method.
	/// </summary>
	/// <param name="evt">The method you want to remove; must contain a single parameter
	/// of a type matching that in the host EventData</param>
    public extern void Remove(EventData<T>.OnEvent evt);
    public extern static bool RemoveEventScene(string eventName, EventData<T>.OnEvent evt, bool removeFromAll);
    public extern static bool RemoveEventUpwards(Transform transform, string eventName, EventData<T>.OnEvent evt, bool removeFromAll);

	/// <summary>
	/// Any methods added to the event must match the delegate's parameters;
	/// one parameter of the given type in this case.
	/// </summary>
	/// <param name="data"></param>
	public delegate void OnEvent(T data);
}
