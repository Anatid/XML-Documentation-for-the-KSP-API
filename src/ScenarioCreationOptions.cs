using System;

/// <summary>
/// A list of options for use with the KSPScenario attribute.
/// </summary>
public enum ScenarioCreationOptions
{
    None = 0,
    AddToNewSandboxGames = 2,
    AddToExistingSandboxGames = 4,
    AddToNewScienceSandboxGames = 8,
    AddToExistingScienceSandboxGames = 16,
    AddToNewCareerGames = 32,
    AddToNewGames = 42,
    AddToExistingCareerGames = 64,
    AddToExistingGames = 84,
    AddToAllGames = 126,
    RemoveFromSandboxGames = 128,
    RemoveFromScienceSandboxGames = 256,
    RemoveFromCareerGames = 512,
    RemoveFromAllGames = 896,
}
