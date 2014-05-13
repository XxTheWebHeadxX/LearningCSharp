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
        int count = 0;
        String counter = "Count: ";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            count += 1;
            CountDisp.Text = counter + count;
        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            count = 0;
            CountDisp.Text = counter + count;
        }

    }
}
