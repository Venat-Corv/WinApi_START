using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class MyClockSettings : Form
    {
        Form1 parent;
        public MyClockSettings(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.cb_ClocktopMost.Checked = parent.AlwaysOnTopToolStripMenuItem.Checked;
            this.cbShowDate.Checked = parent.Lb_date.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_ClocktopMost_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_ClocktopMost_Click(object sender, EventArgs e)
        {
            parent.AlwaysOnTopToolStripMenuItem.Checked = this.cb_ClocktopMost.Checked;
            parent.alwaysOnTopToolStripMenuItem_Click(sender, e);
        }

        private void cbShowDate_Click(object sender, EventArgs e)
        {
            parent.Lb_date.Visible = this.cbShowDate.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.cb_ClocktopMost.Checked != parent.AlwaysOnTopToolStripMenuItem.Checked) cb_ClocktopMost_Click(sender, e);
            if (this.cbShowDate.Checked != parent.Lb_date.Visible) cbShowDate_Click(sender, e);
            this.Close();
        }
    }
}
