using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Draw.src.GUI
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
