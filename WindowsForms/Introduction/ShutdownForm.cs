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
    public partial class ShutdownForm : Form
    {
        Form1 parent;
        public ShutdownForm(Form1 parent)
        {
            InitializeComponent();
            lb_Time.Text = $"{parent.TimeToShutdown["hours"]}:{parent.TimeToShutdown["minutes"]}";
        }
    }
}
