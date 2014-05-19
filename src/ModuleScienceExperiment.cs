using System;

/// <summary>
/// Part module for initiating and describing science experiments.
/// </summary>
public class ModuleScienceExperiment : PartModule, IScienceDataContainer
{
    /// <summary>
    /// Name for the right-click option to collect science data from the part while on EVA.
    /// </summary>
    [KSPField]
    public string collectActionName;
    /// <summary>
    /// Text for warning pop-up while collecting science data from a non-repeatable experiment while on EVA.
    /// </summary>
    [KSPField]
    public string collectWarningText;
    /// <summary>
    /// Is EVA science data collection available?
    /// </summary>
    [KSPField]
    public bool dataIsCollectable;
    [KSPField(isPersistant = true)]
    public bool Deployed;
    /// <summary>
    /// The relevant experiment based on experimentID and info from ScienceDefs file.
    /// </summary>
    public ScienceExperiment experiment;
    /// <summary>
    /// Right-click and action group name for initiating experiment.
    /// </summary>
    [KSPField]
    public string experimentActionName;
    /// <summary>
    /// Must match applicable ID field in the ScienceDefs.cfg file.
    /// </summary>
    [KSPField]
    public string experimentID;
    /// <summary>
    /// Set to 1 to trigger animation in ModuleAnimateGeneric on activation.
    /// </summary>
    public int[] fxModuleIndices;
    /// <summary>
    /// Hide right-click experiment button when experiment cannot be performed.
    /// </summary>
    [KSPField]
    public bool hideUIwhenUnavailable;
    /// <summary>
    /// Can the experiment be performed? Only relevant for non-rerunnable experiments.
    /// </summary>
    [KSPField(isPersistant = true)]
    public bool Inoperable;
    /// <summary>
    /// EVA interaction range for data collection or experiment reset.
    /// </summary>
    [KSPField]
    public float interactionRange;
    /// <summary>
    /// Can the experiment be run more than once before requiring Science Lab reset?
    /// </summary>
    [KSPField]
    public bool rerunnable;
    /// <summary>
    /// Right-click, action group, and EVA button name to reset the experiment, science data will be lost.
    /// </summary>
    [KSPField]
    public string resetActionName;
    [KSPField]
    public bool resettable;
    /// <summary>
    /// Can the experiment be reset on EVA? Science data will be lost.
    /// </summary>
    [KSPField]
    public bool resettableOnEVA;
    /// <summary>
    /// Cost for cleaning the experiment at the science lab. Units * dataScale * baseValue?
    /// </summary>
    [KSPField]
    public float resourceResetCost;
    /// <summary>
    /// Resource to be used for cleaning the experiment at the science lab.
    /// </summary>
    [KSPField]
    public string resourceToReset;
    /// <summary>
    /// Right-click and action group name for reviewing collected science data.
    /// </summary>
    [KSPField]
    public string reviewActionName;
    /// <summary>
    /// Warning displayed before transmitting data from a non-rerunnable experiment.
    /// </summary>
    [KSPField]
    public string transmitWarningText;
    /// <summary>
    /// Allow action groups to be set for the experiment, rather than right-click buttons only.
    /// </summary>
    [KSPField]
    public bool useActionGroups;
    [KSPField]
    public bool useStaging;
    /// <summary>
    /// Percentage of data allowed to be transmitted, 1 equals the amount gained from returning the sample to Kerbin.
    /// </summary>
    [KSPField]
    public float xmitDataScalar;

    public extern ModuleScienceExperiment();

    /// <summary>
    /// Transfers data from the part to an EVA Kerbal.
    /// </summary>
    [KSPEvent(active = true, guiActiveUnfocused = true, externalToEVAOnly = true, guiActive = false, unfocusedRange = 1.5f)]
    public extern void CollectDataExternalEvent();
    /// <summary>
    /// Initiates the experiment from an action group.
    /// </summary>
    /// <param name="actParams"></param>
    [KSPAction("Deploy")]
    public extern void DeployAction(KSPActionParam actParams);
    /// <summary>
    /// Initiates the experiment from a right-click button.
    /// </summary>
    [KSPEvent(guiName = "Deploy", active = true, guiActive = true)]
    public extern void DeployExperiment();
    /// <summary>
    /// Removes science data from the part, called after transmission. Implements IScienceDataContainer.
    /// </summary>
    /// <param name="data">The Science Data to be removed</param>
    public extern void DumpData(ScienceData data);
    /// <summary>
    /// Returns all Science Data stored in the module. Implements IScienceDataContainer.
    /// </summary>
    /// <returns></returns>
    public extern ScienceData[] GetData();
    /// <summary>
    /// A count of how many Science Data reports are stored in the module. Implements IScienceDataContainer.
    /// </summary>
    /// <returns></returns>
    public extern int GetScienceCount();
    /// <summary>
    /// Is the experiment rerunnable? Refers to rerunnable field. Implements IScienceDataContainer.
    /// </summary>
    /// <returns></returns>
    public extern bool IsRerunnable();
    public extern override void OnActive();
    public extern override void OnAwake();
    public extern void OnDestroy();
    /// <summary>
    /// Stores any Science Data in the persistent file.
    /// </summary>
    /// <param name="node"></param>
    public extern override void OnLoad(ConfigNode node);
    /// <summary>
    /// Loads any Science Data stored in the persistent file.
    /// </summary>
    /// <param name="node"></param>
    public extern override void OnSave(ConfigNode node);
    public extern override void OnStart(PartModule.StartState state);
    public extern void OnVesselSituationChange(GameEvents.HostedFromToAction<Vessel, Vessel.Situations> vcs);
    /// <summary>
    /// Resets the experiment from an action group. Science Data is lost. Experiment can be re-run.
    /// </summary>
    /// <param name="actParams"></param>
    [KSPAction("Reset")]
    public extern void ResetAction(KSPActionParam actParams);
    /// <summary>
    /// Resets the experiment from a right-click button. Science Data is lost. Experiment can be re-run.
    /// </summary>
    [KSPEvent(guiName = "Reset", active = true, guiActive = true)]
    public extern void ResetExperiment();
    /// <summary>
    /// Resets the experiment from an EVA right-click button. Science Data is lost. Experiment can be re-run.
    /// </summary>
    [KSPEvent(guiName = "Reset", active = true, guiActiveUnfocused = true, externalToEVAOnly = true, guiActive = false)]
    public extern void ResetExperimentExternal();
    /// <summary>
    /// Opens experimental results dialog. Implements IScienceDataContainer.
    /// </summary>
    public extern void ReviewData();
    /// <summary>
    /// Review stored Science Data from a right-click button.
    /// </summary>
    [KSPEvent(guiName = "Review Data", active = true, guiActive = true)]
    public extern void ReviewDataEvent();
    /// <summary>
    /// Review individual Science Data reports? Implements IScienceDataContainer.
    /// </summary>
    /// <param name="data"></param>
    public extern void ReviewDataItem(ScienceData data);
    /// <summary>
    /// Sets the Inoperable bool, determines whether experiment can be performed again.
    /// </summary>
    public extern void SetInoperable();
}
