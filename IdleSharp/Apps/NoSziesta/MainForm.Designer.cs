namespace IdleSharp.Apps.NoSziesta
{
    partial class MainForm
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
            if (disposing && (components != null))
            {
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regularIntervalSecondsLabel = new System.Windows.Forms.Label();
            this.systemAutoRestartCheckBox = new System.Windows.Forms.CheckBox();
            this.randomSecondsLabel = new System.Windows.Forms.Label();
            this.disableRadioButton = new System.Windows.Forms.RadioButton();
            this.regularIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.randomMaxLabel = new System.Windows.Forms.Label();
            this.randomMinNmericUpDown = new System.Windows.Forms.NumericUpDown();
            this.regularIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.randomMinLabel = new System.Windows.Forms.Label();
            this.randomMaxNmericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regularIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMinNmericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaxNmericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(425, 406);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(425, 455);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.regularIntervalSecondsLabel);
            this.panel1.Controls.Add(this.systemAutoRestartCheckBox);
            this.panel1.Controls.Add(this.randomSecondsLabel);
            this.panel1.Controls.Add(this.disableRadioButton);
            this.panel1.Controls.Add(this.regularIntervalNumericUpDown);
            this.panel1.Controls.Add(this.randomIntervalRadioButton);
            this.panel1.Controls.Add(this.randomMaxLabel);
            this.panel1.Controls.Add(this.randomMinNmericUpDown);
            this.panel1.Controls.Add(this.regularIntervalRadioButton);
            this.panel1.Controls.Add(this.randomMinLabel);
            this.panel1.Controls.Add(this.randomMaxNmericUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 105);
            this.panel1.TabIndex = 0;
            // 
            // regularIntervalSecondsLabel
            // 
            this.regularIntervalSecondsLabel.AutoSize = true;
            this.regularIntervalSecondsLabel.Location = new System.Drawing.Point(196, 77);
            this.regularIntervalSecondsLabel.Name = "regularIntervalSecondsLabel";
            this.regularIntervalSecondsLabel.Size = new System.Drawing.Size(47, 13);
            this.regularIntervalSecondsLabel.TabIndex = 5;
            this.regularIntervalSecondsLabel.Text = "seconds";
            // 
            // systemAutoRestartCheckBox
            // 
            this.systemAutoRestartCheckBox.AutoSize = true;
            this.systemAutoRestartCheckBox.Location = new System.Drawing.Point(12, 6);
            this.systemAutoRestartCheckBox.Name = "systemAutoRestartCheckBox";
            this.systemAutoRestartCheckBox.Size = new System.Drawing.Size(166, 17);
            this.systemAutoRestartCheckBox.TabIndex = 0;
            this.systemAutoRestartCheckBox.Text = "Auto start with windows logon";
            this.systemAutoRestartCheckBox.UseVisualStyleBackColor = true;
            // 
            // randomSecondsLabel
            // 
            this.randomSecondsLabel.AutoSize = true;
            this.randomSecondsLabel.Location = new System.Drawing.Point(276, 54);
            this.randomSecondsLabel.Name = "randomSecondsLabel";
            this.randomSecondsLabel.Size = new System.Drawing.Size(47, 13);
            this.randomSecondsLabel.TabIndex = 10;
            this.randomSecondsLabel.Text = "seconds";
            // 
            // disableRadioButton
            // 
            this.disableRadioButton.AutoSize = true;
            this.disableRadioButton.Checked = true;
            this.disableRadioButton.Location = new System.Drawing.Point(12, 29);
            this.disableRadioButton.Name = "disableRadioButton";
            this.disableRadioButton.Size = new System.Drawing.Size(85, 17);
            this.disableRadioButton.TabIndex = 0;
            this.disableRadioButton.TabStop = true;
            this.disableRadioButton.Text = "Disable timer";
            this.disableRadioButton.UseVisualStyleBackColor = true;
            this.disableRadioButton.CheckedChanged += new System.EventHandler(this.disableRadioButton_CheckedChanged);
            // 
            // regularIntervalNumericUpDown
            // 
            this.regularIntervalNumericUpDown.Location = new System.Drawing.Point(147, 75);
            this.regularIntervalNumericUpDown.Name = "regularIntervalNumericUpDown";
            this.regularIntervalNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.regularIntervalNumericUpDown.TabIndex = 1;
            // 
            // randomIntervalRadioButton
            // 
            this.randomIntervalRadioButton.AutoSize = true;
            this.randomIntervalRadioButton.Location = new System.Drawing.Point(12, 52);
            this.randomIntervalRadioButton.Name = "randomIntervalRadioButton";
            this.randomIntervalRadioButton.Size = new System.Drawing.Size(102, 17);
            this.randomIntervalRadioButton.TabIndex = 6;
            this.randomIntervalRadioButton.Text = "Random interval";
            this.randomIntervalRadioButton.UseVisualStyleBackColor = true;
            this.randomIntervalRadioButton.CheckedChanged += new System.EventHandler(this.randomIntervalRadioButton_CheckedChanged);
            // 
            // randomMaxLabel
            // 
            this.randomMaxLabel.AutoSize = true;
            this.randomMaxLabel.Location = new System.Drawing.Point(197, 54);
            this.randomMaxLabel.Name = "randomMaxLabel";
            this.randomMaxLabel.Size = new System.Drawing.Size(26, 13);
            this.randomMaxLabel.TabIndex = 11;
            this.randomMaxLabel.Text = "max";
            this.randomMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // randomMinNmericUpDown
            // 
            this.randomMinNmericUpDown.Location = new System.Drawing.Point(147, 52);
            this.randomMinNmericUpDown.Name = "randomMinNmericUpDown";
            this.randomMinNmericUpDown.Size = new System.Drawing.Size(43, 20);
            this.randomMinNmericUpDown.TabIndex = 7;
            // 
            // regularIntervalRadioButton
            // 
            this.regularIntervalRadioButton.AutoSize = true;
            this.regularIntervalRadioButton.Location = new System.Drawing.Point(12, 75);
            this.regularIntervalRadioButton.Name = "regularIntervalRadioButton";
            this.regularIntervalRadioButton.Size = new System.Drawing.Size(99, 17);
            this.regularIntervalRadioButton.TabIndex = 0;
            this.regularIntervalRadioButton.Text = "Regular interval";
            this.regularIntervalRadioButton.UseVisualStyleBackColor = true;
            this.regularIntervalRadioButton.CheckedChanged += new System.EventHandler(this.regularIntervalRadioButton_CheckedChanged);
            // 
            // randomMinLabel
            // 
            this.randomMinLabel.AutoSize = true;
            this.randomMinLabel.Location = new System.Drawing.Point(117, 54);
            this.randomMinLabel.Name = "randomMinLabel";
            this.randomMinLabel.Size = new System.Drawing.Size(23, 13);
            this.randomMinLabel.TabIndex = 8;
            this.randomMinLabel.Text = "min";
            this.randomMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // randomMaxNmericUpDown
            // 
            this.randomMaxNmericUpDown.Location = new System.Drawing.Point(227, 52);
            this.randomMaxNmericUpDown.Name = "randomMaxNmericUpDown";
            this.randomMaxNmericUpDown.Size = new System.Drawing.Size(43, 20);
            this.randomMaxNmericUpDown.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.driveToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // driveToolStripMenuItem
            // 
            this.driveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDriveToolStripMenuItem,
            this.removeSelectedToolStripMenuItem});
            this.driveToolStripMenuItem.Name = "driveToolStripMenuItem";
            this.driveToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.driveToolStripMenuItem.Text = "Drive";
            // 
            // addNewDriveToolStripMenuItem
            // 
            this.addNewDriveToolStripMenuItem.Name = "addNewDriveToolStripMenuItem";
            this.addNewDriveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addNewDriveToolStripMenuItem.Text = "Add new drive";
            this.addNewDriveToolStripMenuItem.Click += new System.EventHandler(this.addNewDriveToolStripMenuItem_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 301);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 455);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regularIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMinNmericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaxNmericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RadioButton disableRadioButton;
        private System.Windows.Forms.Label regularIntervalSecondsLabel;
        private System.Windows.Forms.NumericUpDown regularIntervalNumericUpDown;
        private System.Windows.Forms.RadioButton regularIntervalRadioButton;
        private System.Windows.Forms.CheckBox systemAutoRestartCheckBox;
        private System.Windows.Forms.Label randomSecondsLabel;
        private System.Windows.Forms.RadioButton randomIntervalRadioButton;
        private System.Windows.Forms.Label randomMaxLabel;
        private System.Windows.Forms.NumericUpDown randomMinNmericUpDown;
        private System.Windows.Forms.Label randomMinLabel;
        private System.Windows.Forms.NumericUpDown randomMaxNmericUpDown;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
    }
}