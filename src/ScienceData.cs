using System;

/// <summary>
/// Class containing information on science reports, stored in the persistent file in modules using IScienceDataContainer.
/// </summary>
public class ScienceData : IConfigNode
{
    /// <summary>
    /// Amount of data, in mits, to be transmitted or recovered. Affects transmission time and energy usage.
    /// </summary>
    public float dataAmount;
    /// <summary>
    /// Level of science lab boost, less than 1 is un-boosted, 1.5 is the standard lab boosted value, higher levels don't appear to be used.
    /// </summary>
    public float labBoost;
    /// <summary>
    /// ID of science data in Experimentname@CelestialbodynameExperimentalsituationBiome format, matches Science Subject id.
    /// </summary>
    public string subjectID;
    /// <summary>
    /// Science data title, displayed on experimental results dialog page and recovery summary.
    /// </summary>
    public string title;
    /// <summary>
    /// Percentage of science value that can be transmitted. 1 is equal to the amount gained by returning to Kerbin.
    /// </summary>
    public float transmitValue;

    public ScienceData(ConfigNode node);
    /// <summary>
    /// Generate Science Data based on Science Subject values.
    /// </summary>
    /// <param name="amount">Amount of data, it mits.</param>
    /// <param name="xmitValue">Transmission value</param>
    /// <param name="labBoost">Current state of science lab boost</param>
    /// <param name="id">Matches Science Subject ID</param>
    /// <param name="dataName">Title of science data</param>
    public ScienceData(float amount, float xmitValue, float labBoost, string id, string dataName);

    public static ScienceData CopyOf(ScienceData src);
    public void Load(ConfigNode node);
    public void Save(ConfigNode node);
}
