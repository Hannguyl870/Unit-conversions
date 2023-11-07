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
        public Form1()
        {
            InitializeComponent();
            
            optionslable.Text = "\n1. Inches to Centimeters\n \n 2. Feet to Centimeters\n \n 3. Yards to Meters\n \n 4. Miles to Kilometers";
        }

  

        private void convertbutton_Click(object sender, EventArgs e)
        {

            //get values for question 1 and send them to the Add method
            int choise = Convert.ToInt32(optioninput.Text);
            int value = Convert.ToInt32(valueinput.Text);

            double total = 0.00;
            if (choise == 1) 
            {
                total = InchesToCm(value);
                conversionoutput.Text = $"{total}";
            }
            else if (choise == 2)
            {
                total = FeetToCM(value);
                conversionoutput.Text = $"{total}";
            }
            else if (choise == 3)
            {
                total = YardsToMeters(value);
                conversionoutput.Text = $"{total}";
            }
            else if (choise == 4)
            {
                total = MilesToKm(value);
                conversionoutput.Text = $"{total}";

            }
            else
            {
                conversionoutput.Text = "error please chose a number between 1 and 4";
            }


            

        }

        public double InchesToCm(double inches)
        {
            return inches * 2.54;

        }
        public double FeetToCM(double feet)
        {
            return feet * 30.48;
        }

        public double YardsToMeters(double yards)
        {
            return yards * 0.91;
        }
        public double MilesToKm(double miles)
        {
            return miles * 1.6;
        }
    }


}
