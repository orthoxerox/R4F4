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
        frmPicker picker;

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

            picker = new frmPicker();

            colKeyboard.AspectGetter = (x) => x;
            colKeyboard.AspectToStringConverter = (x) =>
            {
                var binding = (Model.Binding)x;
                if (binding.KeyboardBinding == null) {
                    return GetDescriptions(binding.KeyboardKeys);
                } else {
                    return "!" + binding.KeyboardBinding.Action;
                }
            };

            colMouse.AspectGetter = (x) => x;
            colMouse.AspectToStringConverter = (x) =>
            {
                var binding = (Model.Binding)x;
                if (binding.MouseBinding == null) {
                    return GetDescriptions(binding.MouseKeys);
                } else {
                    return "!" + binding.MouseBinding.Action;
                }
            };

            olvBindings.ButtonClick += (sender, e) =>
            {
                var binding = (Model.Binding)e.Model;
                if (e.Column == colKeyboard) {
                    if (binding.KeyboardKeys.Count == 1) {
                        binding.KeyboardKeys[0] = ReadKey(binding.Action);
                    } else if (binding.KeyboardKeys.Count > 1) {
                        for (int i = 0; i < binding.KeyboardKeys.Count; i++) {
                            binding.KeyboardKeys[i] = 
                            ReadKey($"{binding.Action} ({i+1} of {binding.KeyboardKeys.Count})");
                        }
                    }
                }
                olvBindings.RefreshObject(e.Model);
            };
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
            olvBindings.SetObjects(scheme.Bindings);
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

        private string GetDescriptions(IEnumerable<KeyboardKey> enums)
        {
            return enums.Cast<Enum>().Select(Helpers.GetDescription).Concatenate();
        }

        private string GetDescriptions(IEnumerable<MouseKey> enums)
        {
            return enums.Cast<Enum>().Select(Helpers.GetDescription).Concatenate();
        }

        private KeyboardKey ReadKey(string prompt)
        {
            picker.SetPrompt(prompt);
            picker.ShowDialog();
            return picker.Key;
        }
    }
}
