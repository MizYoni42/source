using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Exit Button was pressed.");
            Application.Exit();
           
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
         
        {
            Console.WriteLine("Convert Button was pressed.");
            if (FahrtoC.Checked == true)
             
            {    
               Console.WriteLine("FahrtoC is selected");
                Form1.ActiveForm.Text = "FahrtoC";
                
            
              string fString = fahrTxtbox.Text;  //all data entered in a Textbox is entered as a String

              int  f = Int32.Parse(fString);   //convert the fString to an interger and store it in variable f

                // now you can use f in a calculation

                double c = (f - 32.0) * (5.0 / 9.0);
               string r = c.ToString();

                celsTxtbox.Text = r;

            }



            if (CtoFahr.Checked == true)
            {
                Console.WriteLine("CtoFahr is selected");
                Form1.ActiveForm.Text = "CtoFahr";


                string fString = celsTxtbox.Text;  //all data entered in a Textbox is entered as a String

                int f = Int32.Parse(fString);   //convert the fString to an interger and store it in variable f

                // now you can use f in a calculation

                double c = (f * 9) / 5 + 32; 
                string r = c.ToString();

               
                fahrTxtbox.Text = r;
            }

            
            
                }


        private void clearBtn_Click(object sender, EventArgs e)
        {
           fahrTxtbox.Clear();
            celsTxtbox.Clear();
        }

      
        
    }
    }
    

