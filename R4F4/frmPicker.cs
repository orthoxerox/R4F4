using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using R4F4.Model;

namespace R4F4
{
    public partial class frmPicker : Form
    {
        public KeyboardKey Key;

        public frmPicker()
        {
            InitializeComponent();
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;
            if (msg.Msg == WM_KEYDOWN || msg.Msg == WM_SYSKEYDOWN) {
                var keyCode = (byte)msg.WParam;
                var scanCode = ((uint)msg.LParam) >> 16 & 0x1FF;

                if (keyCode == 0x10) {
                    if (scanCode == 0x2A) keyCode = 0xA0; //LSHIFT
                    if (scanCode == 0x36) keyCode = 0xA1; //RSHIFT
                }

                if (scanCode == 0x01D) keyCode = 0xA2; //LCONTROL
                if (scanCode == 0x11D) keyCode = 0xA3; //RCONTROL

                if (scanCode == 0x038) keyCode = 0xA4; //LALT
                if (scanCode == 0x138) keyCode = 0xA5; //RALT

                //Returning numeric keycodes no matter if NumLock is on or off
                if (scanCode == 0x047) keyCode = 0x67; //HOME   NUMPAD7
                if (scanCode == 0x048) keyCode = 0x68; //UP     NUMPAD8
                if (scanCode == 0x049) keyCode = 0x69; //PRIOR  NUMPAD9
                if (scanCode == 0x04B) keyCode = 0x64; //LEFT   NUMPAD4
                if (scanCode == 0x04C) keyCode = 0x65; //CLEAR  NUMPAD5
                if (scanCode == 0x04D) keyCode = 0x66; //RIGHT  NUMPAD6
                if (scanCode == 0x04F) keyCode = 0x61; //END    NUMPAD1
                if (scanCode == 0x050) keyCode = 0x62; //DOWN   NUMPAD2
                if (scanCode == 0x051) keyCode = 0x63; //NEXT   NUMPAD3
                if (scanCode == 0x052) keyCode = 0x60; //INSERT NUMPAD0
                if (scanCode == 0x053) keyCode = 0x6E; //DELETE DECIMAL

                Key = (KeyboardKey)keyCode;

                DialogResult = DialogResult.OK;
                return true;
            } else {
                return base.PreProcessMessage(ref msg);
            }
        }

        private void cmdUnbind_Click(object sender, EventArgs e)
        {
            Key = KeyboardKey.UNBOUND;
            DialogResult = DialogResult.OK;
        }
    }

}

