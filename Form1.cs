using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked the Count Button");
        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked the Reset Button");
        }

    }
}
