using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using R4F4.Model;

namespace R4F4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var bs = new ControlScheme(
                File.ReadAllText(
                    @"CustomControlMap.txt"));
            foreach (var b in bs.Bindings) {
                txtOutput.AppendText(b.ToString());
                txtOutput.AppendText("\r\n");
            }

            txtOutput.AppendText("============\r\n");
            txtOutput.AppendText(bs.ToString());
        }
    }
}
