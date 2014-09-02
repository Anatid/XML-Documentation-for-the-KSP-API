
using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A type used to generate GameEvents
/// 
/// Use this type with two accompanying parameters
/// </summary>
/// <typeparam name="T">The first type to passed through on EventData.Fire()</typeparam>
/// <typeparam name="U">The second type to passed through on EventData.Fire()</typeparam>
public class EventData<T, U>
{
	/// <summary>
	/// Generate debug logs if true
	/// </summary>
	public bool debugEvent;

	/// <summary>
	/// The constructor used to create a new EventData
	/// 
	/// EventData<Vessel, CelestialBody> myNewEvent = new EventData<Vessel, CelestialBody>("myNewEvent");
	/// </summary>
	/// <param name="eventName">Give the event a string name,
	/// generally the same as the declared name</param>
	public EventData(string eventName);

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
	/// <param name="evt">The method you want to add; must contain two parameters
	/// of types matching those in the host EventData</param>
	public void Add(EventData<T, U>.OnEvent evt);
	public static bool AddEventScene(string eventName, EventData<T, U>.OnEvent evt, bool addToAll);
	public static bool AddEventUpwards(Transform transform, string eventName, EventData<T, U>.OnEvent evt, bool addToAll);
	public static EventData<T, U> FindEventScene(string eventName);
	public static List<EventData<T, U>> FindEventsScene(string eventName);
	public static List<EventData<T, U>> FindEventsUpwards(Transform transform, string eventName);
	public static EventData<T, U> FindEventUpwards(Transform transform, string eventName);
	/// <summary>
	/// Triggers the EventData
	/// 
	/// All of the methods added using Add are run after this.
	/// </summary>
	/// <param name="data0">A parameter matching the first type of the host EventData
	/// Use this to give information relevant to the event</param>
	/// <param name="data1">The second type of the host EventData</param>
	public void Fire(T data0, U data1);
	/// <summary>
	/// Remove a method from the list of methods to be run when the EventData is fired.
	/// 
	/// This is generally done in an object's OnDestroy method.
	/// </summary>
	/// <param name="evt">The method you want to remove; must contain two parameters
	/// of types matching those in the host EventData</param>
	public void Remove(EventData<T, U>.OnEvent evt);
	public static bool RemoveEventScene(string eventName, EventData<T, U>.OnEvent evt, bool removeFromAll);
	public static bool RemoveEventUpwards(Transform transform, string eventName, EventData<T, U>.OnEvent evt, bool removeFromAll);

	/// <summary>
	/// Any methods added to the event must match the delegate's parameters;
	/// two parameters of the given types in this case.
	/// </summary>
	/// <param name="data0"></param>
	/// <param name="data1"></param>
	public delegate void OnEvent(T data0, U data1);
}
