using System;

/// <summary>
/// Like KSPAddon, but for ScenarioModules. Apply this attribute to your subclass
/// of ScenarioModule and KSP will add it to the game at the right time.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class KSPScenario : Attribute
{
    public ScenarioCreationOptions createOptions;
    public GameScenes[] tgtScenes;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="createOptions">Directions about which games the scenario should be added to. Different options
    /// can be combined with the | operator.</param>
    /// <param name="tgtScenes">A list of the game scenes to which the scenario should be added</param>
    public extern KSPScenario(ScenarioCreationOptions createOptions, params GameScenes[] tgtScenes);

    public extern GameScenes[] TargetScenes { get; }

    public extern bool HasCreateOption(ScenarioCreationOptions option);
}
