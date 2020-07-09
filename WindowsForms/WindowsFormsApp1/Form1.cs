using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if(a == 0)
            {
                a = Convert.ToDouble(tb_calc.Text);
                tb_calc.Text = "";
            }
            else
            {
                b = Convert.ToDouble(tb_calc.Text);
                tb_calc.Text = (a + b).ToString();
            }
        }
    }
}
