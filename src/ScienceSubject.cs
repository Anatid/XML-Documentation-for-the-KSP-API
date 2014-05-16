using System;

/// <summary>
/// Class containing information on a specific science result, data stored in the persistent file under the R&D node.
/// </summary>
[Serializable]
public class ScienceSubject : IConfigNode
{
    /// <summary>
    /// Multiply science value by this dataScale value to determine data amount in mits.
    /// </summary>
    public float dataScale;
    /// <summary>
    /// Subject ID in Experimentname@CelestialbodyExperimentalsituationBiome format
    /// </summary>
    public string id;
    /// <summary>
    /// Amount of science already earned from this subject, not updated until after transmission/recovery.
    /// </summary>
    public float science;
    /// <summary>
    /// Total science allowable for this subject, based on subjectValue.
    /// </summary>
    public float scienceCap;
    /// <summary>
    /// Diminishing value multiplier for decreasing the science value returned from repeated experiments.
    /// </summary>
    public float scientificValue;
    /// <summary>
    /// Multiplier for specific Celestial Body/Experiment Situation combination.
    /// </summary>
    public float subjectValue;
    /// <summary>
    /// Title of science subject, displayed in science archives.
    /// </summary>
    public string title;

    /// <summary>
    /// Return a Science Subject from Research and Development node in the persistent file.
    /// </summary>
    /// <param name="node"></param>
    public ScienceSubject(ConfigNode node);
    /// <summary>
    /// Generate new Science Subject.
    /// </summary>
    /// <param name="exp">Science Experiment from ScienceDefs file and ModuleScienceExperiment</param>
    /// <param name="sit">Current experimantal situation, based on VesselSituation</param>
    /// <param name="body">Current Celestial Body</param>
    /// <param name="biome">Current biome if applicable, empty string if not</param>
    public ScienceSubject(ScienceExperiment exp, ExperimentSituations sit, CelestialBody body, string biome = "");
    public ScienceSubject(string id, string title, float dataScale, float subjectValue, float scienceCap);
    public ScienceSubject(ScienceExperiment exp, ExperimentSituations sit, string sourceUid, string sourceTitle, CelestialBody body, string biome = "");

    public void Load(ConfigNode node);
    public void Save(ConfigNode node);
}
