#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

public enum ResourceFlowMode
{
    /// <summary>
    /// This resource cannot flow between parts (like SolidFuel).
    /// </summary>
    NO_FLOW = 0,
    /// <summary>
    /// This resource can flow between any two parts on the ship
    /// without restrictions or intermediate fuel lines (like MonoPropellant).
    /// </summary>
    ALL_VESSEL = 1,
    /// <summary>
    /// Unused?
    /// </summary>
    EVEN_FLOW = 2,
    /// <summary>
    /// This resource behaves like LiquidFuel or Oxidizer, and can only flow
    /// through crossfeed-enabled parts and fuel lines.
    /// </summary>
    STACK_PRIORITY_SEARCH = 3,
}
