using System;
using UnityEngine;

/// <summary>
/// The application launcher is the set of buttons that appear in the upper right, including
/// for example the resource tab. You can add your own buttons to this toolbar. 
/// 
/// See http://forum.kerbalspaceprogram.com/threads/86682-Appilcation-Launcher-and-Mods?p=1303921#post1303921
/// </summary>
public class ApplicationLauncher : MonoBehaviour
{
    public GameObject anchor;
    public GameObject listItemPrefab;
    public ScrollListResizer listResizer;
    public UIButton modListBtnLeft;
    public UIButton modListBtnRight;
    public UIButton modListDivider;
    public ScrollListResizer modListResizer;
    /// <summary>
    /// Don't try to add buttons before ApplicationLauncher.Ready is true. If it's currently false, you
    /// can register for the GameEvents.onGUIApplicationLauncherReady event which will fire when the
    /// application launcher becomes ready to have buttons added to it.
    /// </summary>
    public static bool Ready;

    public extern ApplicationLauncher();

    /// <summary>
    /// The single instance of ApplicationLauncher; call all the methods of this class using this instance.
    /// </summary>
    public extern static ApplicationLauncher Instance { get; }
    /// <summary>
    /// Whether the application launcher toolbar is positioned in the top right or in the bottom right
    /// (it's in the bottom right in the editor).
    /// </summary>
    public extern bool IsPositionedAtTop { get; }

    public extern ApplicationLauncherButton AddApplication(RUIToggleButton.OnTrue onTrue, RUIToggleButton.OnFalse onFalse, RUIToggleButton.OnHover onHover, RUIToggleButton.OnHoverOut onHoverOut, RUIToggleButton.OnEnable onEnable, RUIToggleButton.OnDisable onDisable, PackedSprite sprite);
    public extern ApplicationLauncherButton AddApplication(RUIToggleButton.OnTrue onTrue, RUIToggleButton.OnFalse onFalse, RUIToggleButton.OnHover onHover, RUIToggleButton.OnHoverOut onHoverOut, RUIToggleButton.OnEnable onEnable, RUIToggleButton.OnDisable onDisable, Texture texture);
    /// <summary>
    /// Add a MOD(3rd party) application to the Application Launcher. Use ApplicationLauncherButton.VisibleInScenes to set where the button should be displayed.
    /// </summary>
    /// <remarks>
    /// Note that the application launcher is destroyed when the player exits to the main menu. If the player then 
    /// loads up a new save the application launcher will be recreated and you will have to re-add your button. 
    /// Register for GameEvents.onGUIApplicationLauncherDestroyed and GameEvents.onGUIApplicationLauncherReady
    /// to detect when the application launcher has been destroyed and when it has been re-created.
    /// </remarks>
    /// <param name="onTrue">Callback for when the button is toggeled on</param>
    /// <param name="onFalse">Callback for when the button is toggeled off</param>
    /// <param name="onHover">Callback for when the mouse is hovering over the button</param>
    /// <param name="onHoverOut">Callback for when the mouse hoveris off the button</param>
    /// <param name="onEnable">Callback for when the button is shown or enabled by the application launcher</param>
    /// <param name="onDisable">Callback for when the button is hidden or disabled by the application launcher</param>
    /// <param name="visibleInScenes">The "scenes" this button will be visible in. For example VisibleInScenes = ApplicationLauncher.AppScenes.FLIGHT | ApplicationLauncher.AppScenes.MAPVIEW;</param>
    /// <param name="sprite">The 38x38 PackedSprite animation to use for the button icon. Use ApplicationLauncherButton.PlayAnim() to play the animation.</param>
    /// <returns></returns>
    public extern ApplicationLauncherButton AddModApplication(RUIToggleButton.OnTrue onTrue, RUIToggleButton.OnFalse onFalse, RUIToggleButton.OnHover onHover, RUIToggleButton.OnHoverOut onHoverOut, RUIToggleButton.OnEnable onEnable, RUIToggleButton.OnDisable onDisable, ApplicationLauncher.AppScenes visibleInScenes, PackedSprite sprite);
    /// <summary>
    /// Add a MOD(3rd party) application to the Application Launcher. Use ApplicationLauncherButton.VisibleInScenes to set where the button should be displayed.
    /// </summary>
    /// <remarks>
    /// Note that the application launcher is destroyed when the player exits to the main menu. If the player then 
    /// loads up a new save the application launcher will be recreated and you will have to re-add your button. 
    /// Register for GameEvents.onGUIApplicationLauncherDestroyed and GameEvents.onGUIApplicationLauncherReady
    /// to detect when the application launcher has been destroyed and when it has been re-created.
    /// </remarks>
    /// <param name="onTrue">Callback for when the button is toggeled on</param>
    /// <param name="onFalse">Callback for when the button is toggeled off</param>
    /// <param name="onHover">Callback for when the mouse is hovering over the button</param>
    /// <param name="onHoverOut">Callback for when the mouse hoveris off the button</param>
    /// <param name="onEnable">Callback for when the button is shown or enabled by the application launcher</param>
    /// <param name="onDisable">Callback for when the button is hidden or disabled by the application launcher</param>
    /// <param name="visibleInScenes">The "scenes" this button will be visible in. For example VisibleInScenes = ApplicationLauncher.AppScenes.FLIGHT | ApplicationLauncher.AppScenes.MAPVIEW;</param>
    /// <param name="texture">The 38x38 Texture to use for the button icon.</param>
    /// <returns></returns>
    public extern ApplicationLauncherButton AddModApplication(RUIToggleButton.OnTrue onTrue, RUIToggleButton.OnFalse onFalse, RUIToggleButton.OnHover onHover, RUIToggleButton.OnHoverOut onHoverOut, RUIToggleButton.OnEnable onEnable, RUIToggleButton.OnDisable onDisable, ApplicationLauncher.AppScenes visibleInScenes, Texture texture);
    /// <summary>
    /// Register a method that will be called when the ApplicationLauncher GUI hides itself.
    /// </summary>
    /// <param name="del"></param>
    public extern void AddOnHideCallback(ApplicationLauncher.OnHide del);
    /// <summary>
    /// Register a method that will be called when the ApplicationLauncher moves from the top
    /// right to the bottom right, or vice versa.
    /// </summary>
    /// <param name="del"></param>
    public extern void AddOnRepositionCallback(ApplicationLauncher.OnReposition del);
    /// <summary>
    /// Register a method that will be called when the ApplicationLauncher GUI shows itself.
    /// </summary>
    /// <param name="del"></param>
    public extern void AddOnShowCallback(ApplicationLauncher.OnShow del);
    public extern bool Contains(ApplicationLauncherButton button, out bool hidden);
    public extern bool DetermineVisibility(ApplicationLauncherButton button);
    /// <summary>
    /// Reverses the effect of EnableMutuallyExclusive()
    /// </summary>
    /// <param name="launcherButton"></param>
    public extern void DisableMutuallyExclusive(ApplicationLauncherButton launcherButton);
    /// <summary>
    /// Makes your application hide the stock applications when opened, and  makes stock applications hide
    /// your appliction when opened.
    /// </summary>
    /// <param name="launcherButton"></param>
    public extern void EnableMutuallyExclusive(ApplicationLauncherButton launcherButton);
    public extern void Hide();
    public extern void RemoveApplication(ApplicationLauncherButton button);
    /// <summary>
    /// Removes your button from the application launcher toolbar.
    /// </summary>
    /// <param name="button"></param>
    public extern void RemoveModApplication(ApplicationLauncherButton button);
    /// <summary>
    /// Un-register a method that will be called when the ApplicationLauncher GUI hides itself.
    /// </summary>
    /// <param name="del"></param>
    public extern void RemoveOnHideCallback(ApplicationLauncher.OnHide del);
    /// <summary>
    /// Un-register a method that will be called when the ApplicationLauncher moves from the top
    /// right to the bottom right, or vice versa.
    /// </summary>
    /// <param name="del"></param>
    public extern void RemoveOnRepositionCallback(ApplicationLauncher.OnReposition del);
    /// <summary>
    /// Un-register a method that will be called when the ApplicationLauncher GUI shows itself.
    /// </summary>
    /// <param name="del"></param>
    public extern void RemoveOnShowCallback(ApplicationLauncher.OnShow del);
    public extern bool ShouldBeVisible(ApplicationLauncherButton button);
    public extern void Show();

    /// <summary>
    /// Or together these flags and pass them to AddModApplication to specify when your button
    /// should appear on the application launcher toolbar.
    /// </summary>
    [Flags]
    public enum AppScenes
    {
        NEVER = 0,
        SPACECENTER = 1,
        FLIGHT = 2,
        MAPVIEW = 4,
        VAB = 8,
        SPH = 16,
        ALWAYS = 31,
    }

    public delegate void OnHide();

    public delegate void OnReposition();

    public delegate void OnShow();
}
