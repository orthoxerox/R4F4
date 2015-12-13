using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R4F4.Model
{
    public class Binding
    {
        public string Group { get; }
        public string Action { get; }
        public List<KeyboardKey> KeyboardKeys { get; }
        public List<MouseKey> MouseKeys { get; }
        public List<GamepadKey> GamepadKeys { get; }
        public bool KeyboardOn { get; }
        public bool MouseOn { get; }
        public bool GamepadOn { get; }
        public string Mode { get; }
        public Binding KeyboardBinding { get; }
        public Binding MouseBinding { get; }
        public Binding GamepadBinding { get; }

        public Binding(
            string group,
            string action,
            IEnumerable<KeyboardKey> keyboard,
            IEnumerable<MouseKey> mouse,
            IEnumerable<GamepadKey> gamepad,
            char kbon,
            char mson,
            char gpon,
            string mode,
            Binding kBinding,
            Binding mBinding,
            Binding gBinding)
        {
            Group = group;
            Action = action;
            KeyboardKeys = keyboard.ToList();
            MouseKeys = mouse.ToList();
            GamepadKeys = gamepad.ToList();
            KeyboardOn = kbon == '1';
            MouseOn = mson == '1';
            GamepadOn = gpon == '1';
            Mode = mode;
            KeyboardBinding = kBinding;
            MouseBinding = mBinding;
            GamepadBinding = gBinding;
        }

        public string ToControlSchemeString()
        {
            var sb = new StringBuilder();
            sb.Append(Action);
            sb.Append('\t');

            if (KeyboardBinding == null) {
                sb.Append(
                    KeyboardKeys
                    .Select(key => "0x" + ((byte)key).ToString("X"))
                    .Concatenate());
            } else {
                sb.Append("!" + KeyboardBinding.Action);
            }

            sb.Append('\t');

            if (MouseBinding == null) {
                sb.Append(
                    MouseKeys
                    .Select(key => "0x" + ((ushort)key).ToString("X"))
                    .Concatenate());
            } else {
                sb.Append("!" + MouseBinding.Action);
            }

            sb.Append('\t');

            if (GamepadBinding == null) {
                sb.Append(
                    GamepadKeys
                    .Select(key => "0x" + ((ushort)key).ToString("X"))
                    .Concatenate());
            } else {
                sb.Append("!" + GamepadBinding.Action);
            }

            sb.Append('\t');
            sb.Append(KeyboardOn ? '1' : '0');
            sb.Append('\t');
            sb.Append(MouseOn ? '1' : '0');
            sb.Append('\t');
            sb.Append(GamepadOn ? '1' : '0');
            if (!string.IsNullOrWhiteSpace(Mode)) {
                sb.Append('\t');
                sb.Append(Mode);
            }
            sb.Append('\n');

            return sb.ToString();
        }

        public override string ToString()
        {
            var keyboard = KeyboardBinding == null
                ?
                KeyboardKeys
                .Select(key => key.GetDescription())
                .Concatenate()
                :
                "!" + KeyboardBinding.Action;
            var mouse = MouseBinding == null
                ?
                MouseKeys
                .Select(key => key.GetDescription())
                .Concatenate()
                :
                "!" + MouseBinding.Action;
            var gamepad = GamepadBinding == null
                ?
                GamepadKeys
                .Select(key => key.GetDescription())
                .Concatenate()
                :
                "!" + GamepadBinding.Action;
            return $"{Group}\t{Action}\t{keyboard}\t{mouse}\t{gamepad}";
        }

    }
}
