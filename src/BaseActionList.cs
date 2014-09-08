#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\0.24.2 dev\KSP_x64_Data\Managed\Assembly-CSharp.dll
#endregion

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

    public BaseActionList(Part part, PartModule module);

    public BaseAction this[string name] { get; }

    public bool Contains(KSPActionGroup group);
    public void OnLoad(ConfigNode node);
    public void OnSave(ConfigNode node);
}
