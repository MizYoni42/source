using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Exit Button was Pressed");
            Application.Exit();
        }

        private void calcAreabtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Calc Area Button was Pressed");
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clear Button was Pressed");
           widthTxtbox.Clear();
           radiusTxtbox.Clear();
           areaTxtbox.Clear();
        }

        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
