using System;
using System.Collections.Generic;

/// <summary>
/// Class containing information from the experiment stored in the ScienceDefs file.
/// </summary>
[Serializable]
public class ScienceExperiment
{
    /// <summary>
    /// Base science value from ScienceDefs file.
    /// </summary>
    public float baseValue;
    /// <summary>
    /// Bitmask to determine when biomes are relevant.
    /// </summary>
    public uint biomeMask;
    /// <summary>
    /// Multiplier to increase data amount in mits.
    /// </summary>
    public float dataScale;
    /// <summary>
    /// Title to be displayed for experimental results dialog and science archives.
    /// </summary>
    public string experimentTitle;
    /// <summary>
    /// Matches ID from ModuleScienceExperiment field.
    /// </summary>
    public string id;
    /// <summary>
    /// Can the experiment only be performed on planets with an atmosphere?
    /// </summary>
    public bool requireAtmosphere;
    /// <summary>
    /// Maximum science value available for each experimental result.
    /// </summary>
    public float scienceCap;
    /// <summary>
    /// Bitmask to determine which Experiment Situations the experiment can be performed in.
    /// </summary>
    public uint situationMask;

    public ScienceExperiment();

    public Dictionary<string, string> Results { get; }

    /// <summary>
    /// Checks if the biome is relevent to the experiment given the biomeMask specified in the ScienceDefs file.
    /// </summary>
    /// <param name="situation">Current Experiment Situation</param>
    /// <returns></returns>
    public bool BiomeIsRelevantWhile(ExperimentSituations situation);
    /// <summary>
    /// Determines if the experiment is available given the situationMask and requireAtmosphere values specified in the ScienceDefs file.
    /// </summary>
    /// <param name="situation">Current Experiment Situation</param>
    /// <param name="body">Current Celestial Body</param>
    /// <returns></returns>
    public bool IsAvailableWhile(ExperimentSituations situation, CelestialBody body);
    public void Load(ConfigNode node);
    public void Save(ConfigNode node);
}
