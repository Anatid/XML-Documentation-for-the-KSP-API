using System;

/// <summary>
/// Apply this attribute to a class that derives from MonoBehaviour to have KSP automatically start up
/// your addon at a specified time.
/// </summary>
/// <remarks>
/// At the time specified by the "startup" argument KSP will create
/// a new GameObject and attach your MonoBehaviour to it. You can then implement the Unity event functions
/// like Start(), Update(), etc. 
/// </remarks>
[AttributeUsage(AttributeTargets.Class)]
public class KSPAddon : Attribute
{
    /// <summary>
    /// Whether KSP should start up your addon just once per game session, or every time
    /// the startup time is reached. If you want your addon to persist forever, even through
    /// scene changes, after being started once, set once to true. call DontDestroyOnLoad(this) in your 
    /// Start() function.
    /// </summary>
    public bool once;
    /// <summary>
    /// When this addon should be started.
    /// </summary>
    public KSPAddon.Startup startup;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="startup">When this addon should be started</param>
    /// <param name="once">Whether KSP should start up your addon just once per game session, or every time
    /// the startup time is reached. If you want your addon to persist forever, even through
    /// scene changes, after being started once, set once to true. call DontDestroyOnLoad(this) in your 
    /// Start() function. </param>
    public extern KSPAddon(KSPAddon.Startup startup, bool once);

    /// <summary>
    /// Possible values for when your addon can be started up.
    /// </summary>
    public enum Startup
    {
        /// <summary>
        /// Presumably, start on entering either the VAB or the SPH.
        /// </summary>
        EditorAny = -3,
        /// <summary>
        /// Presumably, start soon as possible after loading your assembly?
        /// </summary>
        Instantly = -2,
        /// <summary>
        /// Start up on any scene transition?
        /// </summary>
        EveryScene = -1,
        /// <summary>
        /// Start on entering the main KSP menu.
        /// </summary>
        MainMenu = 2,
        /// <summary>
        /// Start on entering the KSP settings menu.
        /// </summary>
        Settings = 3,
        /// <summary>
        /// Start on entering the KSP credits scene.
        /// </summary>
        Credits = 4,
        /// <summary>
        /// Start on entering the space centre scene.
        /// </summary>
        SpaceCentre = 5,
        /// <summary>
        /// Start on entering the VAB scene.
        /// </summary>
        EditorVAB = 6,
        /// <summary>
        /// Start on entering the flight scene.
        /// </summary>
        Flight = 7,
        /// <summary>
        /// Start on entering the tracking station scene.
        /// </summary>
        TrackingStation = 8,
        /// <summary>
        /// Start on entering the SPH scene.
        /// </summary>
        EditorSPH = 9,
        /// <summary>
        /// Start just before KSP creates the solar system? This seems to be the right hook to
        /// use for addons that modify the solar system. See the PSystemManager class and related
        /// classes.
        /// </summary>
        PSystemSpawn = 10,
    }
}
