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



        //CIRCLE RADIO BUTTON
        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtn1.Checked == true)

            {
                Console.WriteLine("Circle is selected");
                Area.ActiveForm.Text = "Radius";
                areaTxtbox.Visible = false;
                widthTxtbox.Visible = false;
                lengthTxtbox.Visible = false;

            }

        }



        //SQUARE RADIO BUTTON
        private void radioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn2.Checked == true)

            {
                Console.WriteLine("Square is selected");
                Area.ActiveForm.Text = "Side";
                areaTxtbox.Visible = false;
                radiusTxtbox.Visible = false;
                lengthTxtbox.Visible = false;

            }


        }

        //RECTANGLE RADIO BUTTON
        private void radioBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn3.Checked == true)

            {
                Console.WriteLine("Rectangle is selected");
                Area.ActiveForm.Text = "Height";
       //you would need another line like 65 to make a bottom border say width but there is no bottom border
                areaTxtbox.Visible = false;
                radiusTxtbox.Visible = false;

            }

        }

        //CALC AREA BUTTON
        private void calcAreabtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Calc Area Button was Pressed");

            if (radioBtn1.Checked == true)

            {
                string fString = radiusTxtbox.Text;  //all data entered in a Textbox is entered as a String

                int f = Int32.Parse(fString);   //convert the fString to an interger and store it in variable f

                // now you can use f in a calculation

                double A = (3.14) *  f * f;
                string r = A.ToString();
                areaTxtbox.Text = r;
            }


            if (radioBtn2.Checked == true)

            {
                string fString = widthTxtbox.Text;  //all data entered in a Textbox is entered as a String

                int f = Int32.Parse(fString);   //convert the fString to an interger and store it in variable f

                // now you can use f in a calculation

                double A = f * f;
                string r = A.ToString();
                areaTxtbox.Text = r;
            }



            if (radioBtn3.Checked == true)

            {
                string fString = widthTxtbox.Text;  //all data entered in a Textbox is entered as a String

                int f = Int32.Parse(fString);   //convert the fString to an interger and store it in variable f

                string lString = lengthTxtbox.Text;  //all data entered in a Textbox is entered as a String

                int l = Int32.Parse(lString);   //convert the fString to an interger and store it in variable f
                // now you can use f in a calculation

                double A = f * l;
                string r = A.ToString();
                areaTxtbox.Text = r;
            }



            if (areaTxtbox.Visible == false)
                areaTxtbox.Visible = true;
            else
                areaTxtbox.Visible = true;


        }












            //CLEAR BUTTON
        private void clearBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clear Button was Pressed");
           widthTxtbox.Clear();
           radiusTxtbox.Clear();
           areaTxtbox.Clear();
           lengthTxtbox.Clear();

        }









            //EXIT BUTTON
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Exit Button was pressed.");


            if (MessageBox.Show("Are you sure you want to Exit?",
                               "Area Program Exit",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
