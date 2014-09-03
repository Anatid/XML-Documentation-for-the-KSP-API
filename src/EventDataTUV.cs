
using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A type used to generate GameEvents
/// 
/// Use this type with three accompanying parameters
/// </summary>
/// <typeparam name="T">The first type to be passed through on EventData.Fire()</typeparam>
/// <typeparam name="U">The second type to be passed through on EventData.Fire()</typeparam>
/// <typeparam name="V">The third type to be passed through on EventData.Fire()</typeparam>
public class EventData<T, U, V>
{
	/// <summary>
	/// Generate debug logs if true
	/// </summary>
	public bool debugEvent;

	/// <summary>
	/// The constructor used to create a new EventData
	/// 
	/// EventData&lt;Vessel, CelestialBody, String&gt; myNewEvent = new EventData&lt;Vessel, CelestialBody, String&gt;("myNewEvent");
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
	/// <param name="evt">The method you want to add; must contain three parameters
	/// matching the types of in the host EventData</param>
    public extern void Add(EventData<T, U, V>.OnEvent evt);
    public extern static bool AddEventScene(string eventName, EventData<T, U, V>.OnEvent evt, bool addToAll);
    public extern static bool AddEventUpwards(Transform transform, string eventName, EventData<T, U, V>.OnEvent evt, bool addToAll);
    public extern static EventData<T, U, V> FindEventScene(string eventName);
    public extern static List<EventData<T, U, V>> FindEventsScene(string eventName);
    public extern static List<EventData<T, U, V>> FindEventsUpwards(Transform transform, string eventName);
    public extern static EventData<T, U, V> FindEventUpwards(Transform transform, string eventName);
	/// <summary>
	/// Triggers the EventData
	/// 
	/// All of the methods added using Add are run after this.
	/// </summary>
	/// <param name="data0">A parameter matching the first type of the host EventData
	/// Use this to give information relevant to the event</param>
	/// <param name="data1">The second type of the host EventData</param>
	/// <param name="data2">The third type of the host EventData</param>
    public extern void Fire(T data0, U data1, V data2);
	/// <summary>
	/// Remove a method from the list of methods to be run when the EventData is fired.
	/// 
	/// This is generally done in an object's OnDestroy method.
	/// </summary>
	/// <param name="evt">The method you want to remove; must contain three parameters
	/// matching the types of in the host EventData</param>
    public extern void Remove(EventData<T, U, V>.OnEvent evt);
    public extern static bool RemoveEventScene(string eventName, EventData<T, U, V>.OnEvent evt, bool removeFromAll);
    public extern static bool RemoveEventUpwards(Transform transform, string eventName, EventData<T, U, V>.OnEvent evt, bool removeFromAll);

	/// <summary>
	/// Any methods added to the event must match the delegate's parameters;
	/// three parameters of the given types in this case.
	/// </summary>
	/// <param name="data0"></param>
	/// <param name="data1"></param>
	/// <param name="data2"></param>
	public delegate void OnEvent(T data0, U data1, V data2);
}
