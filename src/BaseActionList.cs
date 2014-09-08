using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// A BaseActionList is an object to manipulate actions.
/// </summary>
[Serializable]
public class BaseActionList : List<BaseAction>
{
    /// <summary>
    /// The partModule this list of actions belongs to
    /// </summary>
    public PartModule module;
    /// <summary>
    /// The Part this list of actions belongs to
    /// </summary>
    public Part part;

    public extern BaseActionList(Part part, PartModule module);

    public extern BaseAction this[string name] { get; }

    public extern bool Contains(KSPActionGroup group);
    public extern void OnLoad(ConfigNode node);
    public extern void OnSave(ConfigNode node);
}
