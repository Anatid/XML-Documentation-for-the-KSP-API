using System;

/// <summary>
/// An enumeration of the different behaviors resources can have with respect to fuel flow.
/// </summary>
public enum ResourceFlowMode
{
    /// <summary>
    /// This resource cannot flow between parts (like SolidFuel).
    /// </summary>
    NO_FLOW = 0,
    /// <summary>
    /// The flow scheme used by the stock ElectricCharge and IntakeAir resources.
    /// </summary>
    ALL_VESSEL = 1,
    /// <summary>
    /// Unused?
    /// </summary>
    EVEN_FLOW = 2,
    /// <summary>
    /// The flow scheme used by the stock MonoPropellant and XenonGas resources.
    /// Resource can be draw from any container by any consumer, but it tries to
    /// prioritize drawing from continers in earlier stages.
    /// </summary>
    STAGE_PRIORITY_FLOW = 2,
    /// <summary>
    /// This resource behaves like LiquidFuel or Oxidizer, and can only flow
    /// through crossfeed-enabled parts and fuel lines.
    /// </summary>
    STACK_PRIORITY_SEARCH = 3,
}
