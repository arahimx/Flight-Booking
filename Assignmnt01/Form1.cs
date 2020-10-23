using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmnt01
{

    public partial class Form1 : Form
    {

        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";
        public static string SetValueForText8 = "";
        public static string SetValueForText9 = "";
        public static string SetValueForText10 = "";
        public Form1()
        {
            InitializeComponent();

        }


        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label7.Text = "Passport No.";
                label8.Text = "Passport Issue Date.";
                label13.Text = "Passport Expiry Date.";

            }
 

        }

        private void numeric_weight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetValueForText1 = label_firstname.Text + " " + label_lastname.Text;
            SetValueForText2 = label_email.Text;
            SetValueForText3 = label_from.Text;
            SetValueForText4 = label_to.Text;
            SetValueForText5 = label_calender.SelectionStart.ToString("dd MMM yyyy"); ;
            SetValueForText6 = label_documentNo.Text;
            SetValueForText7 = datetimepicker_expirydate.Text;
            SetValueForText8 = numericweight.Text;
            SetValueForText9 = label7.Text;
            SetValueForText10 = label13.Text;

            if (datetimepicker_expirydate.Value.Date > dateTimePicker_issedate.Value.Date)
            {
                Form2 frm2 = new Form2();
                frm2.Show();

            }
            else
            {
                label12.Text = "*Document expiry date must be greater then Issue date";
            }
        }
    }
}
