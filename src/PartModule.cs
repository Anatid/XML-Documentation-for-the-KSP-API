#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// Extending PartModule lets you add new functionality to parts. The main class of many plugins
/// will be a subclass of PartModule. See this forum thread for the official instructions on
/// using PartModule:
/// 
/// <para>http://forum.kerbalspaceprogram.com/showthread.php/10296-0-15-code-update-PartModule-KSPField-KSPEvent-ConfigNode-and-PartResource</para>
/// </summary>
public class PartModule : MonoBehaviour
{
    public bool isEnabled;
    public string moduleName;
    public ProtoPartModuleSnapshot snapshot;

    public extern PartModule();

    /// <summary>
    /// A list of KSPActions which can be added to action groups.
    /// </summary>
    public extern BaseActionList Actions { get; }
    /// <summary>
    /// A hash of <c>ClassName</c>?
    /// </summary>
    public extern int ClassID { get; }
    /// <summary>
    /// In any subclass of PartModule, <c>ClassName</c> will be the name of the subclass.
    /// It gets set by the PartModule loading process.
    /// </summary>
    public extern string ClassName { get; }
    /// <summary>
    /// A list of KSPEvents, which can be triggered by code or by the user through the part's right-click menu.
    /// </summary>
    public extern BaseEventList Events { get; }
    /// <summary>
    /// A list of the KSPFields which the module loads from the part.cfg file.
    /// </summary>
    public extern BaseFieldList Fields { get; }
    public extern string GUIName { get; }
    /// <summary>
    /// The Part to which this PartModule is attached. Use this to reference the part from your module code.
    /// </summary>
    public extern Part part { get; set; }
    /// <summary>
    /// The Vessel of the Part to which this PartModule is attached.
    /// </summary>
    public extern Vessel vessel { get; }

    /// <summary>
    /// The return value of this function appears in the part's description in the editor.
    /// </summary>
    /// <returns>Editor info for the part</returns>
    public extern virtual string GetInfo();
    public extern void Load(ConfigNode node);
    /// <summary>
    /// This function is called once when the part gets activated.
    /// </summary>
    public extern virtual void OnActive();
    /// <summary>
    /// This function gets called only once, during the KSP loading screen. See the Unity documentation on Awake for more information.
    /// </summary>
    public extern virtual void OnAwake();
    /// <summary>
    /// This function gets called once every Unity FixedUpdate cycle (once per physics frame) once the part has been activated. 
    /// If you want to be called even if the part has not been activated, define a function called <c>void FixedUpdate()</c> instead
    /// of overriding OnFixedUpdate
    /// </summary>
    /// <remarks>
    /// See the Unity documentation on FixedUpdate for more information. You can get the time between FixedUpdates from 
    /// TimeWarp.fixedDeltaTime. Do any physics stuff in OnFixedUpdate, not OnUpdate.
    /// </remarks>
    public extern virtual void OnFixedUpdate();
    /// <summary>
    /// When does this get called?
    /// </summary>
    public extern virtual void OnInactive();
    /// <summary>
    /// This function is called to initialize the part. The ConfigNode contains the parameters of the module
    /// as specified in the part.cfg file, or as you last saved them in OnSave. 
    /// </summary>
    /// <param name="node">A ConfigNode containing the module's parameters from part.cfg or persistent.sfs</param>
    public extern virtual void OnLoad(ConfigNode node);
    /// <summary>
    /// This function is called when the game is saved to let the part save persistent data. Add any data you want
    /// to persist to the ConfigNode. The ConfigNode will then be saved as part of persistent.sfs.
    /// When the game is resumed, you can then read this data back out in OnLoad.
    /// </summary>
    /// <param name="node"></param>
    public extern virtual void OnSave(ConfigNode node);
    /// <summary>
    /// Called when the flight starts, or when the part is created in the editor. OnStart will be called
    /// before OnUpdate or OnFixedUpdate are ever called.
    /// </summary>
    /// <param name="state">Some information about what situation the vessel is starting in.</param>
    public extern virtual void OnStart(PartModule.StartState state);
    /// <summary>
    /// Called once per Unity Update cycle once the part has been activated. 
    /// If you want to be called even if the part has not been activated, define a function called <c>void Update()</c> instead
    /// of overriding OnFixedUpdate.
    /// </summary>
    /// <remarks>
    /// See the
    /// Unity documentation on Update for more information. Poll for user input in OnUpdate, not OnFixedUpdate.
    /// </remarks>
    public extern virtual void OnUpdate();
    public extern void Save(ConfigNode node);

    /// <summary>
    /// A StartState is passed on OnStart in order to provide the PartModule with some information
    /// about where it is starting up.
    /// </summary>
    [Flags]
    public enum StartState
    {
        None = 0,
        Editor = 1,
        PreLaunch = 2,
        Landed = 4,
        Docked = 8,
        Flying = 16,
        Splashed = 32,
        SubOrbital = 64,
        Orbital = 128,
    }
}
