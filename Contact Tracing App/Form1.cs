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
            displayInfo(firstname: FirstNameBox1.Text, middlename: MiddleNameBox2.Text, lastname: LastNameBox3.Text, age: byte.Parse(AgeBox4.Text), phonenumber: byte.Parse(PhoneNumber.Text), email: EmailBox7.Text, address: AddressBox5.Text);
        }
         
        private void displayInfo(String firstname, String middlename, String lastname, byte age, byte phonenumber, String email, String address)
        {
            StreamWriter outputfile = File.AppendText("output.txt");
            outputfile.WriteLine(firstname);
            outputfile.WriteLine(middlename);
            outputfile.WriteLine(lastname);
            outputfile.WriteLine(age.ToString());
            outputfile.WriteLine(phonenumber.ToString());
            outputfile.WriteLine(email);
            outputfile.WriteLine(address);
            outputfile.Close();
        }
    }
}
