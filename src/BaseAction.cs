using System;
using System.Collections.Generic;

/// <summary>
/// A BaseAction object is the basic action object.
/// There is one of these automatically created for each 'KSPAction' field in a partModule
/// </summary>
[Serializable]
public class BaseAction
{
    /// <summary>
    /// Unconfirmed: The action groups this action is currently assigned to.
    /// </summary>
    public KSPActionGroup actionGroup;
    /// <summary>
    /// Is this action available? Setting this false disables the action so it will not show in the available actions list.
    /// </summary>
    public bool active;
    /// <summary>
    ///Unconfirmed: Assign this action to action groups upon creation ('Gear' group for landing legs)
    /// </summary>
    public KSPActionGroup defaultActionGroup;
    /// <summary>
    /// Name shown in editor action groups panel
    /// </summary>
    public string guiName;
    /// <summary>
    /// Information about what the action is attached to.
    /// listParent.module = partModule this action is a memeber of
    /// listParent.part = part this action is a member of
    /// </summary>
    public BaseActionList listParent;
    /// <summary>
    /// Name of the action group as seen in code where the KSPAction field exists
    /// </summary>
    public string name;

    public extern BaseAction(BaseActionList listParent, string name, BaseActionDelegate onEvent, KSPAction actionAttr);

    public static extern int ActionGroupsLength { get; }
    protected extern BaseActionDelegate onEvent { get; }

    public static extern bool ContainsNonDefaultActions(Part p);
    public static extern List<BaseAction> CreateActionList(List<Part> parts, KSPActionGroup group, bool include);
    public static extern List<BaseAction> CreateActionList(Part p, KSPActionGroup group, bool include);
    public static extern List<bool> CreateGroupList(List<Part> parts);
    public static extern List<bool> CreateGroupList(Part p);
    public static extern void FireAction(List<Part> parts, KSPActionGroup group, KSPActionType type);
    public static extern int GetGroupIndex(KSPActionGroup group);
    /// <summary>
    /// Activate this action. Note that there is no toggle activation, you must check state yourself in code
    /// and activate or deactivate as appropriate
    /// 
    /// **Example code start to activate an action: KSP version 0.24.2**
    /// 
    /// <code>
    /// KSPActionParam actParam = new KSPActionParam(KSPActionGroup.None, KSPActionType.Activate); //okay to create this new just before invoking
    /// exampleAction.Invoke(actParam); //action defined as a KSPAction in a partModule
    /// </code>
    /// 
    /// **Example code start to deactivate an action: KSP version 0.24.2**
    /// 
    /// <code>
    /// KSPActionParam actParam = new KSPActionParam(KSPActionGroup.None, KSPActionType.Deactivate); //okay to create this new just before invoking
    /// exampleAction.Invoke(actParam); //action defined as a KSPAction in a partModule
    /// </code>
    /// </summary>
    public extern void Invoke(KSPActionParam param);
    public extern void OnLoad(ConfigNode node);
    public extern void OnSave(ConfigNode node);
}
