namespace R4F4
{
    partial class frmPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHelp = new System.Windows.Forms.Label();
            this.cmdUnbind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(0, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(178, 102);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Press a key...";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdUnbind
            // 
            this.cmdUnbind.Location = new System.Drawing.Point(50, 67);
            this.cmdUnbind.Name = "cmdUnbind";
            this.cmdUnbind.Size = new System.Drawing.Size(75, 23);
            this.cmdUnbind.TabIndex = 1;
            this.cmdUnbind.Text = "Unbind";
            this.cmdUnbind.UseVisualStyleBackColor = true;
            this.cmdUnbind.Click += new System.EventHandler(this.cmdUnbind_Click);
            // 
            // frmPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 102);
            this.Controls.Add(this.cmdUnbind);
            this.Controls.Add(this.lblHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button cmdUnbind;
    }
}