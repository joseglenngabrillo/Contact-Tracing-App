using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Contact_Tracing_App : Form
    {
        public Contact_Tracing_App()
        {
            InitializeComponent();
        }

        private void Contact_Tracing_App_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_Click(object sender, EventArgs e)
        {

        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }
         
        private void displayInfo(String firstname, String middlename, String lastname, byte age, byte phonenumber, String email, String address)
        {
            StreamWriter outputfile = File.AppendText("output.txt");
        }
    }
}
