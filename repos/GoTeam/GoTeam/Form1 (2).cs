using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoTeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloLbl_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World!");
        }

        private void GoTeamBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Go Team Button was Pressed");

        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Exit Button was Pressed");
            Application.Exit();
        }
    }



    }

