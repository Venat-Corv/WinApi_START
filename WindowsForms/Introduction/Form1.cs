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
        public Form1()
        {
            InitializeComponent();
            font_default = cb_showdate.Font;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            this.lb_time.Text = DateTime.Now.ToLongTimeString();
            this.lb_date.Text = DateTime.Now.ToLongDateString();
        }

        private void cb_showdate_CheckedChanged(object sender, EventArgs e)
        {
            this.lb_date.Visible = this.cb_showdate.Checked;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
        }

        private void cb_showdate_MouseHover(object sender, EventArgs e)
        {
            this.cb_showdate.ForeColor = Color.Red;
            this.cb_showdate.Font = new Font(font_default, FontStyle.Bold);
        }

        private void cb_showdate_MouseLeave(object sender, EventArgs e)
        {
            this.cb_showdate.ForeColor = Color.Black;
            this.cb_showdate.Font = new Font(font_default, FontStyle.Regular);
        }
    }
}
