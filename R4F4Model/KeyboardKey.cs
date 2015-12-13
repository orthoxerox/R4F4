using System.ComponentModel;

namespace R4F4.Model
{
    public enum KeyboardKey : byte
    {
        [Description("INVALID")]
        INVALID = 0x00,
        [Description("LMB")]
        LBUTTON = 0x01,
        [Description("RMB")]
        RBUTTON = 0x02,
        [Description("Abort")]
        CANCEL = 0x03,
        [Description("MMB")]
        MBUTTON = 0x04,
        [Description("X1MB")]
        XBUTTON1 = 0x05,
        [Description("X2MB")]
        XBUTTON2 = 0x06,
        [Description("Backspace")]
        BACK = 0x08,
        [Description("Tab")]
        TAB = 0x09,
        [Description("Clear")]
        CLEAR = 0x0C,
        [Description("Enter")]
        RETURN = 0x0D,
        [Description("Shift")]
        SHIFT = 0x10,
        [Description("Ctrl")]
        CONTROL = 0x11,
        [Description("Alt")]
        MENU = 0x12,
        [Description("Pause")]
        PAUSE = 0x13,
        [Description("Caps Lock")]
        CAPITAL = 0x14,
        [Description("IME Kana")]
        KANA = 0x15,
        [Description("IME Hangul")]
        HANGUL = 0x15,
        [Description("IME Junja")]
        JUNJA = 0x17,
        [Description("IME final")]
        FINAL = 0x18,
        [Description("IME Hanja")]
        HANJA = 0x19,
        [Description("IME Kanji")]
        KANJI = 0x19,
        [Description("Escape")]
        ESCAPE = 0x1B,
        [Description("IME convert")]
        CONVERT = 0x1C,
        [Description("IME nonconvert")]
        NONCONVERT = 0x1D,
        [Description("IME accept")]
        ACCEPT = 0x1E,
        [Description("IME MCR")]
        MODECHANGE = 0x1F,
        [Description("Space")]
        SPACE = 0x20,
        [Description("Page Up")]
        PRIOR = 0x21,
        [Description("Page Down")]
        NEXT = 0x22,
        [Description("End")]
        END = 0x23,
        [Description("Home")]
        HOME = 0x24,
        [Description("Left")]
        LEFT = 0x25,
        [Description("Up")]
        UP = 0x26,
        [Description("Right")]
        RIGHT = 0x27,
        [Description("Down")]
        DOWN = 0x28,
        [Description("Select")]
        SELECT = 0x29,
        [Description("Print")]
        PRINT = 0x2A,
        [Description("Execute")]
        EXECUTE = 0x2B,
        [Description("Print Screen")]
        SNAPSHOT = 0x2C,
        [Description("Insert")]
        INSERT = 0x2D,
        [Description("Delete")]
        DELETE = 0x2E,
        [Description("Help")]
        HELP = 0x2F,
        [Description("0")]
        N0 = 0x30,
        [Description("1")]
        N1 = 0x31,
        [Description("2")]
        N2 = 0x32,
        [Description("3")]
        N3 = 0x33,
        [Description("4")]
        N4 = 0x34,
        [Description("5")]
        N5 = 0x35,
        [Description("6")]
        N6 = 0x36,
        [Description("7")]
        N7 = 0x37,
        [Description("8")]
        N8 = 0x38,
        [Description("9")]
        N9 = 0x39,
        [Description("A")]
        A = 0x41,
        [Description("B")]
        B = 0x42,
        [Description("C")]
        C = 0x43,
        [Description("D")]
        D = 0x44,
        [Description("E")]
        E = 0x45,
        [Description("F")]
        F = 0x46,
        [Description("G")]
        G = 0x47,
        [Description("H")]
        H = 0x48,
        [Description("I")]
        I = 0x49,
        [Description("J")]
        J = 0x4A,
        [Description("K")]
        K = 0x4B,
        [Description("L")]
        L = 0x4C,
        [Description("M")]
        M = 0x4D,
        [Description("N")]
        N = 0x4E,
        [Description("O")]
        O = 0x4F,
        [Description("P")]
        P = 0x50,
        [Description("Q")]
        Q = 0x51,
        [Description("R")]
        R = 0x52,
        [Description("S")]
        S = 0x53,
        [Description("T")]
        T = 0x54,
        [Description("U")]
        U = 0x55,
        [Description("V")]
        V = 0x56,
        [Description("W")]
        W = 0x57,
        [Description("X")]
        X = 0x58,
        [Description("Y")]
        Y = 0x59,
        [Description("Z")]
        Z = 0x5A,
        [Description("Left Windows")]
        LWIN = 0x5B,
        [Description("Right Windows")]
        RWIN = 0x5C,
        [Description("Applications")]
        APPS = 0x5D,
        [Description("Sleep")]
        SLEEP = 0x5F,
        [Description("Numpad 0")]
        NUMPAD0 = 0x60,
        [Description("Numpad 1")]
        NUMPAD1 = 0x61,
        [Description("Numpad 2")]
        NUMPAD2 = 0x62,
        [Description("Numpad 3")]
        NUMPAD3 = 0x63,
        [Description("Numpad 4")]
        NUMPAD4 = 0x64,
        [Description("Numpad 5")]
        NUMPAD5 = 0x65,
        [Description("Numpad 6")]
        NUMPAD6 = 0x66,
        [Description("Numpad 7")]
        NUMPAD7 = 0x67,
        [Description("Numpad 8")]
        NUMPAD8 = 0x68,
        [Description("Numpad 9")]
        NUMPAD9 = 0x69,
        [Description("Multiply")]
        MULTIPLY = 0x6A,
        [Description("Add")]
        ADD = 0x6B,
        [Description("Separator")]
        SEPARATOR = 0x6C,
        [Description("Subtract")]
        SUBTRACT = 0x6D,
        [Description("Decimal")]
        DECIMAL = 0x6E,
        [Description("Divide")]
        DIVIDE = 0x6F,
        [Description("F1")]
        F1 = 0x70,
        [Description("F2")]
        F2 = 0x71,
        [Description("F3")]
        F3 = 0x72,
        [Description("F4")]
        F4 = 0x73,
        [Description("F5")]
        F5 = 0x74,
        [Description("F6")]
        F6 = 0x75,
        [Description("F7")]
        F7 = 0x76,
        [Description("F8")]
        F8 = 0x77,
        [Description("F9")]
        F9 = 0x78,
        [Description("F10")]
        F10 = 0x79,
        [Description("F11")]
        F11 = 0x7A,
        [Description("F12")]
        F12 = 0x7B,
        [Description("F13")]
        F13 = 0x7C,
        [Description("F14")]
        F14 = 0x7D,
        [Description("F15")]
        F15 = 0x7E,
        [Description("F16")]
        F16 = 0x7F,
        [Description("F17")]
        F17 = 0x80,
        [Description("F18")]
        F18 = 0x81,
        [Description("F19")]
        F19 = 0x82,
        [Description("F20")]
        F20 = 0x83,
        [Description("F21")]
        F21 = 0x84,
        [Description("F22")]
        F22 = 0x85,
        [Description("F23")]
        F23 = 0x86,
        [Description("F24")]
        F24 = 0x87,
        [Description("Num Lock")]
        NUMLOCK = 0x90,
        [Description("Scroll Lock")]
        SCROLL = 0x91,
        [Description("LShift")]
        LSHIFT = 0xA0,
        [Description("RShift")]
        RSHIFT = 0xA1,
        [Description("LCtrl")]
        LCONTROL = 0xA2,
        [Description("RCtrl")]
        RCONTROL = 0xA3,
        [Description("LMenu")]
        LMENU = 0xA4,
        [Description("RMenu")]
        RMENU = 0xA5,
        [Description("Back")]
        BROWSER_BACK = 0xA6,
        [Description("Forward")]
        BROWSER_FORWARD = 0xA7,
        [Description("Refresh")]
        BROWSER_REFRESH = 0xA8,
        [Description("Stop")]
        BROWSER_STOP = 0xA9,
        [Description("Search key ")]
        BROWSER_SEARCH = 0xAA,
        [Description("Favorites")]
        BROWSER_FAVORITES = 0xAB,
        [Description("Start and Home")]
        BROWSER_HOME = 0xAC,
        [Description("Volume Mute")]
        VOLUME_MUTE = 0xAD,
        [Description("Volume Down")]
        VOLUME_DOWN = 0xAE,
        [Description("Volume Up")]
        VOLUME_UP = 0xAF,
        [Description("Next Track")]
        MEDIA_NEXT_TRACK = 0xB0,
        [Description("Previous Track")]
        MEDIA_PREV_TRACK = 0xB1,
        [Description("Stop Media")]
        MEDIA_STOP = 0xB2,
        [Description("Play/Pause Media")]
        MEDIA_PLAY_PAUSE = 0xB3,
        [Description("Mail")]
        LAUNCH_MAIL = 0xB4,
        [Description("Select Media")]
        LAUNCH_MEDIA_SELECT = 0xB5,
        [Description("Start Application 1")]
        LAUNCH_APP1 = 0xB6,
        [Description("Start Application 2")]
        LAUNCH_APP2 = 0xB7,
        [Description("Semicolon")]
        OEM_1 = 0xBA,
        [Description("OEM Plus")]
        OEM_PLUS = 0xBB,
        [Description("OEM Comma")]
        OEM_COMMA = 0xBC,
        [Description("OEM Minus")]
        OEM_MINUS = 0xBD,
        [Description("OEM Period")]
        OEM_PERIOD = 0xBE,
        [Description("/")]
        OEM_2 = 0xBF,
        [Description("`")]
        OEM_3 = 0xC0,
        [Description("[")]
        OEM_4 = 0xDB,
        [Description("\\")]
        OEM_5 = 0xDC,
        [Description("]")]
        OEM_6 = 0xDD,
        [Description("'")]
        OEM_7 = 0xDE,
        [Description("OEM 8")]
        OEM_8 = 0xDF,
        [Description("OEM 102")]
        OEM_102 = 0xE2,
        [Description("IME PROCESS")]
        PROCESSKEY = 0xE5,
        [Description("Attn")]
        ATTN = 0xF6,
        [Description("CrSel")]
        CRSEL = 0xF7,
        [Description("ExSel")]
        EXSEL = 0xF8,
        [Description("Erase EOF")]
        EREOF = 0xF9,
        [Description("Play")]
        PLAY = 0xFA,
        [Description("Zoom")]
        ZOOM = 0xFB,
        [Description("PA1")]
        PA1 = 0xFD,
        [Description("Clear")]
        OEM_CLEAR = 0xFE,
        [Description("Unbound")]
        UNBOUND = 0xFF,
    }
}
