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
            optionslable.Text = "\n1. Inches to Centimeters\n \n 2. Feet to Centamiters\n \n 3. Yards to Meters\n \n 4. Miles to Kilometers";
        }

  

        private void convertbutton_Click(object sender, EventArgs e)
        {

            //get values for question 1 and send them to the Add method
            int choise = Convert.ToInt32(optioninput.Text);
            int value = Convert.ToInt32(valueinput.Text);
        }
    }
}
