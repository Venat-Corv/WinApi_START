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
    public partial class Form1 : Form
    {
        Font font_default;
        Dictionary<string, int> timeToShutdown;

        public Dictionary<string, int> TimeToShutdown
        {
            get
            {
                return timeToShutdown;
            }
            set
            {
                timeToShutdown = value;
            }
        }
        public System.Windows.Forms.ToolStripMenuItem AlwaysOnTopToolStripMenuItem
        {
            get
            {
                return alwaysOnTopToolStripMenuItem;
            }
            set
            {
                alwaysOnTopToolStripMenuItem = value;
            }
        }

        public Label Lb_date
        {
            get
            {
                return lb_date;
            }
            set
            {
                lb_date = value;
            }
        }
        bool isVisible;
        public Form1()
        {
            InitializeComponent();
            font_default = cb_showdate.Font;
            isVisible = false;
            TimeToShutdown.Add("hours", 23);
            TimeToShutdown.Add("minutes", 59);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            this.lb_time.Text = DateTime.Now.ToLongTimeString();
            this.lb_date.Text = DateTime.Now.ToShortDateString();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
        }

        private void cb_showdate_Click_1(object sender, EventArgs e)
        {
            this.lb_date.Visible = isVisible ? false : true;
            isVisible = this.lb_date.Visible;
            this.close.Visible = isVisible;
            this.cb_showdate.Text = isVisible ? "-" : "+";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
        public void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sender.ToString() == "Always on top")
            {
                alwaysOnTopToolStripMenuItem.Checked = this.TopMost = TopMost ? false : true;
            }
            else
            {
                this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            }
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }


        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyClockSettings mcs = new MyClockSettings(this);
            mcs.Show();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutdownForm sf = new ShutdownForm(this);
            sf.Show();
        }
    }
}
