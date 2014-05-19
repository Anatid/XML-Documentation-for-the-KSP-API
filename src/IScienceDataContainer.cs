using System;

/// <summary>
/// Interface used by ModuleScienceExperiment and ModuleScienceContainer. Used for storing, transfering and transmitting Science Data.
/// </summary>
public interface IScienceDataContainer
{
    /// <summary>
    /// Removes science data from the part, called after transmission or EVA data collection.
    /// </summary>
    /// <param name="data"></param>
    void DumpData(ScienceData data);
    /// <summary>
    /// Returns an array of all Science Data stored in the module.
    /// </summary>
    /// <returns></returns>
    ScienceData[] GetData();
    /// <summary>
    /// Returns a count of Science Data reports stored in the module.
    /// </summary>
    /// <returns></returns>
    int GetScienceCount();
    /// <summary>
    /// Can the experiment be run more than once?
    /// </summary>
    /// <returns></returns>
    bool IsRerunnable();
    /// <summary>
    /// Opens the experimental results dialog page, displays stored Science Data.
    /// </summary>
    void ReviewData();
    /// <summary>
    /// Opens the experimental results dialog page, displays stored Science Data.
    /// </summary>
    /// <param name="data"></param>
    void ReviewDataItem(ScienceData data);
}
