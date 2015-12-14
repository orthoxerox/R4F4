using System.ComponentModel;

namespace R4F4.Model
{
    public enum MouseKey : ushort
    {
        [Description("LMB")]
        LMB = 0x0,
        [Description("RMB")]
        RMB = 0x1,
        [Description("MMB")]
        MMB = 0x2,
        [Description("?")]
        WTF = 0xA,
        [Description("Wheel Up")]
        WHEEL_UP = 0x800,
        [Description("Wheel Down")]
        WHEEL_DOWN = 0x900,
        [Description("Mouse Look")]
        MLOOK = 0xA00,
        [Description("_Unbound")]
        UNBOUND = 0XFF,
        [Description("_INVALID")]
        INVALID = 0xFFFF,
    }
}
