using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace Shutdown
{
    public partial class Form1 : Form
    {
        DateTime time;
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
        [DllImport("user32.dll")]
        public static extern bool ExitWindowEx(uint uFlags, uint dwReason);
        public Form1()
        {
            InitializeComponent();
            cb_Action.SelectedIndex = 0;
        }

        private void lb_Minutes_Click(object sender, EventArgs e)
        {

        }

        private void systemTray_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            systemTray.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemTray.Visible = true;

            time = DateTime.Parse(lb_Time.Text);
            if(time < DateTime.Now)
            {
                MessageBox.Show("Set another time");
            }
            MessageBox.Show(time.ToString(), "Shutdown time");
        }

        private void tb_Hourse_ValueChanged(object sender, EventArgs e)
        {
            string hours = lb_Time.Text.Split(':').First();
            string minutes = lb_Time.Text.Split(':').Last();
            hours = (tb_Hourse.Value < 10) ? "0" + tb_Hourse.Value.ToString() : tb_Hourse.Value.ToString();
            lb_Time.Text = $"{hours}:{minutes}";
        }

        private void tb_Minutes_ValueChanged(object sender, EventArgs e)
        {
            string hours = lb_Time.Text.Split(':').First();
            string minutes = lb_Time.Text.Split(':').Last();
            minutes = (tb_Minutes.Value < 10)? "0"+tb_Minutes.Value.ToString(): tb_Minutes.Value.ToString();
            lb_Time.Text = $"{hours}:{minutes}";
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {

            if(time.Hour == DateTime.Now.Hour && time.Minute == DateTime.Now.Minute && DateTime.Now.Second == 0)
            {
                switch(cb_Action.SelectedIndex)
                {
                    case 0:
                        LockWorkStation();
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                         break;
                }
                MessageBox.Show($"Time to {cb_Action.SelectedItem}");
            }
        }

        private void cb_Action_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
