using System.ComponentModel;

namespace R4F4.Model
{
    public enum GamepadKey : ushort
    {
        [Description("_INVALID")]
        INVALID = 0x00,
        [Description("Up")]
        UP = 0x0001,
        [Description("Down")]
        DOWN = 0x0002,
        [Description("Left")]
        LEFT = 0x0004,
        [Description("Right")]
        RIGHT = 0x0008,
        [Description("LT")]
        LT = 0x0009,
        [Description("RT")]
        RT = 0x000A,
        [Description("Left Stick")]
        LSTICK = 0x000B,
        [Description("Right Stick")]
        RSTICK = 0x000C,
        [Description("Menu")]
        MENU = 0x0010,
        [Description("Select")]
        SELECT = 0x0020,
        [Description("Left Stick Click")]
        LS_CLICK = 0x0040,
        [Description("Right Stick Click")]
        RS_CLICK = 0x0080,
        [Description("LB")]
        LB = 0x0100,
        [Description("RB")]
        RB = 0x0200,
        [Description("A")]
        A = 0x1000,
        [Description("B")]
        B = 0x2000,
        [Description("X")]
        X = 0x4000,
        [Description("Y")]
        Y = 0x8000,
        [Description("_Unbound")]
        UNBOUND = 0XFF,
        [Description("_Unbound")]
        UNBOUND2 = 0xFFFF,
    }
}
