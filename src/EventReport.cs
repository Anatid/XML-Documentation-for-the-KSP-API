
using System;

/// <summary>
///  A type frequently used as a parameter in GameEvents
/// </summary>
public class EventReport
{
	/// <summary>
	/// An enum used to specify the type of EventReport;
	/// see FlightEvents for the available types
	/// </summary>
	public FlightEvents eventType;
	/// <summary>
	/// A string message that can accompany the EventReport
	/// </summary>
	public string msg;
	/// <summary>
	/// The Part responsible for generating the EventReport
	/// </summary>
	public Part origin;
	/// <summary>
	/// Usually the originating part name
	/// </summary>
	public string other;
	/// <summary>
	/// The target of the event;
	/// another part's name, the surface, blank, etc...
	/// </summary>
	public string sender;
	/// <summary>
	/// The active stage number when the EventReport is generated;
	/// can be set to any integer; 0 by default
	/// </summary>
	public int stage;

	/// <summary>
	/// The EventReport constructor, generally used when firing an EventData event
	/// that calls for an EventReport parameter
	/// 
	/// someEvent.Fire(new EventReport(...));
	/// </summary>
	/// <param name="type"></param>
	/// <param name="eventCreator"></param>
	/// <param name="name"></param>
	/// <param name="otherName"></param>
	/// <param name="stageNumber"></param>
	/// <param name="customMsg"></param>
    public extern EventReport(FlightEvents type, Part eventCreator, string name = "an unidentified object", string otherName = "an unidentified object", int stageNumber = 0, string customMsg = "");
}
