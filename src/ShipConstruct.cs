using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

[Serializable]
public class ShipConstruct /*: IEnumerable, IShipconstruct, IEnumerable<Part>*/
{
    public static int lastCompatibleMajor;
    public static int lastCompatibleMinor;
    public static int lastCompatibleRev;
    /// <summary>
    /// A list of all the parts in the ShipConstruct.
    /// The parts are listed in the same order in which they were added to the ship in the editor.
    /// </summary>
    public List<Part> parts;
    public string shipDescription;
    public string shipName;
    public bool shipPartsUnlocked;
    public int shipType;

    public extern ShipConstruct();
    public extern ShipConstruct(int shipType);
    public extern ShipConstruct(string shipName, int shipType, List<Part> parts);
    public extern ShipConstruct(string shipName, string shipDescription, Part rootPart);

    public extern int Count { get; }
    public extern List<Part> Parts { get; }

    public extern Part this[int index] { get; set; }

    public extern void Add(Part p);
    public extern bool AreAllPartsConnected();
    public extern void Clear();
    public extern bool Contains(Part p);
    public extern IEnumerator<Part> GetEnumerator();
    public extern float GetShipCosts(out float dryCost, out float fuelCost);
    public extern bool isControllable();
    public extern bool LoadShip(ConfigNode root);
    public extern void Remove(Part p);
    public extern ConfigNode SaveShip();
}
