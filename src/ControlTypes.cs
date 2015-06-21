using System;
//0.90 Update:
//The high end mask locks have changed, notable a ControlTypes.AppLauncher_Buttons has been added.
//The commented out list looks to be from 24.2, but the list at the bottom appears to be up to date for 0.90
//However, despite the name, ControlTypes.AppLauncher_Buttons does not lock the buttons on the toolbar.
//To lock out, or not lock out, the toolbar when you engage the control log, ControlTypes.GUI is the mask to reference.
//I assume this is a typo on Squads part and will probably be fixed in a future update.

/// <summary>
/// The different controls that it is possible to lock the player out of
/// using InputLockManager. You can OR them together to lock the player
/// out of multiple controls at once.
/// </summary>
/// <remarks>
/// TaranisElsu compiled this list of the binary values of the enum members as of KSP 0.24.2, which makes
/// it clearer which controls are locked in each case:
/// 
/// <code>None                                                                                          0
/// PITCH                                                                                         1
/// ROLL                                                                                        100
/// YAW                                                                                        1000
/// THROTTLE                                                                                  10000
/// SAS                                                                                      100000
/// PAUSE                                                                                   1000000
/// STAGING                                                                                10000000
/// CAMERAMODES                                                                          1 00000000
/// MISC                                                                                10 00000000
/// CAMERACONTROLS                                                                     100 00000000
/// TIMEWARP                                                                          1000 00000000
/// MAP                                                                              10000 00000000
/// LINEAR                                                                          100000 00000000
/// QUICKSAVE                                                                      1000000 00000000
/// QUICKLOAD                                                                     10000000 00000000
/// VESSEL_SWITCHING                                                            1 00000000 00000000
/// CUSTOM_ACTION_GROUPS                                                       10 00000000 00000000
/// GROUP_ABORT                                                               100 00000000 00000000
/// GROUP_GEARS                                                              1000 00000000 00000000
/// GROUP_LIGHTS                                                            10000 00000000 00000000
/// GROUP_BRAKES                                                           100000 00000000 00000000
/// GROUP_STAGE                                                           1000000 00000000 00000000
/// GROUPS_ALL                                                            1111110 00000000 00000000
/// ACTIONS_SHIP                                                         10000000 00000000 00000000
/// ACTIONS_EXTERNAL                                                   1 00000000 00000000 00000000
/// ACTIONS_ALL                                                        1 10000000 00000000 00000000
/// RCS                                                               10 00000000 00000000 00000000
/// WHEEL_STEER                                                      100 00000000 00000000 00000000
/// WHEEL_THROTTLE                                                  1000 00000000 00000000 00000000
/// EVA_INPUT                                                      10000 00000000 00000000 00000000
/// EDITOR_ICON_HOVER                                             100000 00000000 00000000 00000000
/// EDITOR_ICON_PICK                                             1000000 00000000 00000000 00000000
/// EDITOR_TAB_SWITCH                                           10000000 00000000 00000000 00000000
/// EDITOR_SAVE                                               1 00000000 00000000 00000000 00000000
/// EDITOR_LOAD                                              10 00000000 00000000 00000000 00000000
/// EDITOR_EXIT                                             100 00000000 00000000 00000000 00000000
/// EDITOR_NEW                                             1000 00000000 00000000 00000000 00000000
/// EDITOR_LAUNCH                                         10000 00000000 00000000 00000000 00000000
/// EDITOR_UI_TOPRIGHT                                    11111 00000000 00000000 00000000 00000000
/// EDITOR_PAD_PICK_PLACE                                100000 00000000 00000000 00000000 00000000
/// EDITOR_PAD_PICK_COPY                                1000000 00000000 00000000 00000000 00000000
/// EDITOR_EDIT_STAGES                                 10000000 00000000 00000000 00000000 00000000
/// EDITOR_EDIT_NAME_FIELDS                          1 00000000 00000000 00000000 00000000 00000000
/// EDITOR_ROTATE_PARTS                             10 00000000 00000000 00000000 00000000 00000000
/// EDITOR_UNDO_REDO                               100 00000000 00000000 00000000 00000000 00000000
/// EDITOR_SYM_SNAP                               1000 00000000 00000000 00000000 00000000 00000000
/// EDITOR_OVERLAYS                              10000 00000000 00000000 00000000 00000000 00000000
/// EDITOR_MODE_SWITCH                          100000 00000000 00000000 00000000 00000000 00000000
/// EDITOR_UI_TOPBAR                            100001 00011111 00000000 00000000 00000000 00000000
/// EDITOR_UI                                   101101 10011111 00000000 00000000 00000000 00000000
/// EDITOR_SOFT_LOCK                            111110 01100000 11100000 00000000 00000000 00000000
/// EDITOR_LOCK                                 111110 01100000 11100000 00000000 00000100 00000000
/// TRACKINGSTATION_UI                         1000000 00000000 00000000 00000000 00000000 00000000
/// TRACKINGSTATION_ALL                        1000000 00000000 00000000 00000000 00001100 00000000
/// KSC_FACILITIES                            10000000 00000000 00000000 00000000 00000000 00000000
/// KSC_UI                                  1 00000000 00000000 00000000 00000000 00000000 00000000
/// KSC_ALL                                 1 10000000 00000000 00000000 00000000 00001100 00000000
/// APPLAUNCHER_BUTTONS                    10 00000000 00000000 00000000 00000000 00000000 00000000
/// ALL_SHIP_CONTROLS       11111111 11111111 11111111 11111111 11111111 11111110 00100010 10111111
/// All                     11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111111</code>
/// 
/// </remarks>
[Flags]
public enum ControlTypes : ulong
{
    None = 0,
    PITCH = 1,
    ROLL = 4,
    YAW = 8,
    THROTTLE = 16,
    SAS = 32,
    PAUSE = 64,
    STAGING = 128,
    CAMERAMODES = 256,
    MISC = 512,
    CAMERACONTROLS = 1024,
    TIMEWARP = 2048,
    MAP = 4096,
    LINEAR = 8192,
    QUICKSAVE = 16384,
    QUICKLOAD = 32768,
    VESSEL_SWITCHING = 65536,
    CUSTOM_ACTION_GROUPS = 131072,
    GROUP_ABORT = 262144,
    GROUP_GEARS = 524288,
    GROUP_LIGHTS = 1048576,
    GROUP_BRAKES = 2097152,
    GROUP_STAGE = 4194304,
    GROUPS_ALL = 8257536,
    ACTIONS_SHIP = 8388608,
    ACTIONS_EXTERNAL = 16777216,
    ACTIONS_ALL = 25165824,
    RCS = 33554432,
    WHEEL_STEER = 67108864,
    WHEEL_THROTTLE = 134217728,
    EVA_INPUT = 268435456,
    EDITOR_ICON_HOVER = 536870912,
    EDITOR_ICON_PICK = 1073741824,
    EDITOR_TAB_SWITCH = 2147483648,
    EDITOR_SAVE = 4294967296,
    EDITOR_LOAD = 8589934592,
    EDITOR_EXIT = 17179869184,
    EDITOR_NEW = 34359738368,
    EDITOR_LAUNCH = 68719476736,
    EDITOR_UI_TOPRIGHT = 133143986176,
    EDITOR_PAD_PICK_PLACE = 137438953472,
    EDITOR_PAD_PICK_COPY = 274877906944,
    EDITOR_EDIT_STAGES = 549755813888,
    EDITOR_EDIT_NAME_FIELDS = 1099511627776,
    EDITOR_ROTATE_PARTS = 2199023255552,
    EDITOR_UNDO_REDO = 4398046511104,
    EDITOR_SYM_SNAP = 8796093022208,
    EDITOR_OVERLAYS = 17592186044416,
    EDITOR_MODE_SWITCH = 35184372088832,
    EDITOR_UI_TOPBAR = 36417027702784,
    EDITOR_UI = 50160923049984,
    EDITOR_SOFT_LOCK = 68585795878912,
    EDITOR_LOCK = 68585795879936,
    TRACKINGSTATION_UI = 70368744177664,
    TRACKINGSTATION_ALL = 70368744180736,
    KSC_FACILITIES = 140737488355328,
    KSC_UI = 281474976710656,
    KSC_ALL = 422212465069056,
    APPLAUNCHER_BUTTONS = 562949953421312,
    ALL_SHIP_CONTROLS = 18446744073709429439,
    All = 18446744073709551615,
}
