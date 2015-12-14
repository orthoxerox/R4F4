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
using System.Configuration;

namespace R4F4
{
    public partial class frmMain : Form
    {
        string fileName;
        string falloutPath;
        bool edited = false;
        ControlScheme scheme;

        public bool Edited
        {
            get
            {
                return edited;
            }

            set
            {
                this.edited = value;
                miSave.Enabled = value;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            falloutPath = ConfigurationManager.AppSettings["falloutPath"];
            if (falloutPath == "?") UpdateFalloutPath();
            dlgOpen.InitialDirectory = falloutPath;
        }

        private void UpdateFalloutPath()
        {
            MessageBox.Show(@"Please select the F4SE folder inside your Fallout 4\Data directory:");
            dlgFolder.ShowDialog();
            falloutPath = dlgFolder.SelectedPath;
            ConfigurationManager.AppSettings["falloutPath"] = falloutPath;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"R4F4 © 2015 orthoxerox.
Licensed under GNU AGPL v3.

Fallout, Prepare for the Future 
and related logos are trademarks 
or registered trademarks of 
Bethesda Softworks LLC 
in the U.S. and/or other countries.
All Rights Reserved.",
"R4F4");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            if (Edited) {
                switch (MessageBox.Show(
                    "Are you sure you want to discard unsaved changes?", 
                    "R4F4", 
                    MessageBoxButtons.YesNo)) {
                    case DialogResult.No:
                        return;
                    default:
                        break;
                }
            }

            switch (dlgOpen.ShowDialog()) {
                case DialogResult.OK:
                    fileName = dlgOpen.FileName;
                    var oldScheme = scheme;
                    try {
                        scheme = new ControlScheme(File.ReadAllText(fileName));
                    }
                    catch (Exception) {
                        MessageBox.Show("Error opening file");
                    }
                    if (scheme.Errors.Count > 0) {
                        MessageBox.Show("Invalid format!");
                        scheme = oldScheme;
                        return;
                    }
                    Edited = false;
                    miSaveAs.Enabled = true;
                    PopulateGrid();
                    return;
                default:
                    return;
            }
        }

        private void PopulateGrid()
        {
            throw new NotImplementedException();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            if (Edited) {
                switch (MessageBox.Show(
                    "Are you sure you want to discard unsaved changes?",
                    "R4F4",
                    MessageBoxButtons.YesNo)) {
                    case DialogResult.No:
                        return;
                    default:
                        break;
                }
            }

            Application.Exit();
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, scheme.ToString());
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            dlgSave.InitialDirectory = Path.GetFullPath(fileName);
            dlgSave.FileName = fileName;
            switch (dlgSave.ShowDialog()) {
                case DialogResult.OK:
                    fileName = dlgSave.FileName;
                    Edited = false;
                    File.WriteAllText(fileName, scheme.ToString());
                    return;
                default:
                    return;
            }

        }
    }
}
