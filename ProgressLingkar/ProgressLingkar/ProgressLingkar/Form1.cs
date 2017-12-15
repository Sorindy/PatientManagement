using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressLingkar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                circularProgressBar2.Value += 2;
                circularProgressBar2.Text = circularProgressBar2.Value.ToString();
            }
            catch(Exception)
            {
                return;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                circularProgressBar1.Value += 1;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString();

                circularProgressBar3.Value += 1;

                circularProgressBar4.Value += 1;
                circularProgressBar4.Text = circularProgressBar4.Value.ToString();

                circularProgressBar5.Value += 1;

            }
            catch(Exception)
            {
                return;
            }
            
        }
    }
}
