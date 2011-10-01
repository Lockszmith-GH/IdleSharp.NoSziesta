using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IdleSharp.Apps.NoSziesta
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            RandomIntervalEnable(false);
            RegularIntervalEnable(false);
        }

        private void disableRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RandomIntervalEnable( bool enabledState )
        {
            randomMaxLabel.Enabled = enabledState;
            randomMinLabel.Enabled = enabledState;
            randomMaxNmericUpDown.Enabled = enabledState;
            randomMinNmericUpDown.Enabled = enabledState;
            randomSecondsLabel.Enabled = enabledState;
        }

        private void randomIntervalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RandomIntervalEnable(randomIntervalRadioButton.Checked);
        }

        private void RegularIntervalEnable( bool enabledState )
        {
            regularIntervalNumericUpDown.Enabled = enabledState;
            regularIntervalSecondsLabel.Enabled = enabledState;
        }

        private void regularIntervalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RegularIntervalEnable( regularIntervalRadioButton.Checked );
        }

        private void addNewDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoSziestaDriveInfoUC noSziestaDriveInfoUC1 = new IdleSharp.Apps.NoSziesta.NoSziestaDriveInfoUC();

            noSziestaDriveInfoUC1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            noSziestaDriveInfoUC1.Size = new Size(flowLayoutPanel1.Width, noSziestaDriveInfoUC1.Height);
            this.flowLayoutPanel1.Controls.Add(noSziestaDriveInfoUC1);

            Application.DoEvents();
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            emptyLabel.Visible = !(!emptyLabel.Visible && flowLayoutPanel1.Controls.Count > 1);

        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            emptyLabel.Visible = !(!emptyLabel.Visible && flowLayoutPanel1.Controls.Count > 1);
        }
    }
}
