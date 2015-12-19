using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R4F4.Model
{
    public class ControlScheme
    {
        public IReadOnlyList<string> Errors { get { return errors; } }
        private readonly List<string> errors = new List<string>();

        public IReadOnlyList<Binding> Bindings { get { return bindings; } }
        private List<Binding> bindings = new List<Binding>();

        public ControlScheme(string input)
        {
            var lines = input.Split('\n');
            var i = 1;
            foreach (var line in lines) {
                if (string.IsNullOrWhiteSpace(line)) {
                    i++;
                    continue;
                }
                var elements = line.Split(new[] { ' ', '\t' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                var action = elements[0];

                var ks = elements.GetC(1) ?? "";
                var kBinding = ks.StartsWith("!")
                    ? FindBinding(ks.Substring(1)) : null;
                var keyboard = ks.Split(',')
                    .Select(key => ParseKeyboardKey(key));

                var ms = elements.GetC(2) ?? "";
                var mBinding = ms.StartsWith("!")
                    ? FindBinding(ms.Substring(1)) : null;
                var mouse = ms.Split(',')
                    .Select(key => ParseMouseKey(key));

                var gs = elements.GetC(3) ?? "";
                var gBinding = gs.StartsWith("!")
                    ? FindBinding(gs.Substring(1)) : null;
                var gamepad = gs.Split(',')
                    .Select(key => ParseGamepadKey(key));

                var kbon = elements.GetC(4).GetS(0) ?? '0';
                var mson = elements.GetC(5).GetS(0) ?? '0';
                var gpon = elements.GetC(6).GetS(0) ?? '0';
                var mode = elements.GetC(7) ?? "";

                bindings.Add(new Binding(
                    "Group " + i.ToString("D2"), 
                    action, 
                    keyboard, mouse, gamepad,
                    kbon, mson, gpon,
                    mode,
                    kBinding, mBinding, gBinding));
            }
        }

        public override string ToString()
        {
            var group = "Group 1";
            var sb = new StringBuilder();
            foreach (var b in bindings) {
                if (b.Group != group) {
                    group = b.Group;
                    sb.Append('\n');
                }
                sb.Append(b.ToControlSchemeString());
            }
            return sb.ToString();
        }

        private Binding FindBinding(string action)
        {
            return bindings
                .Where(b => b.Group == "Group 1" && b.Action == action)
                .FirstOrDefault();
        }

        private GamepadKey ParseGamepadKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                return GamepadKey.INVALID;

            ushort result;
            if (key.StartsWith("0x") &&
                ushort.TryParse(
                key.Substring(2),
                System.Globalization.NumberStyles.HexNumber,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out result)) {
                if (Enum.IsDefined(typeof(GamepadKey), result)) {
                    return (GamepadKey)result;
                }
            }

            return GamepadKey.INVALID;
        }

        private MouseKey ParseMouseKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                return MouseKey.INVALID;

            ushort result;
            if (key.StartsWith("0x") && 
                ushort.TryParse(
                key.Substring(2),
                System.Globalization.NumberStyles.HexNumber,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out result)) {
                if (Enum.IsDefined(typeof(MouseKey), result)) {
                    return (MouseKey)result;
                }
            }

            return MouseKey.INVALID;
        }

        private KeyboardKey ParseKeyboardKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                return KeyboardKey.INVALID;

            byte result;
            if (key.StartsWith("0x") &&
                byte.TryParse(
                key.Substring(2), 
                System.Globalization.NumberStyles.HexNumber, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out result)) {
                if (Enum.IsDefined(typeof(KeyboardKey), result)) {
                    return (KeyboardKey)result;
                }
            }

            return KeyboardKey.INVALID;
        }
    }
}
