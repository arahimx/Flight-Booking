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
        public Form1()
        {
            InitializeComponent();
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = label_firstname.Text + " " + label_lastname.Text;
            SetValueForText2 = label_email.Text;
            SetValueForText3 = label_from.Text;
            SetValueForText4 = label_to.Text;
            SetValueForText5 = label_calender.SelectionRange.Start.ToShortDateString();
            SetValueForText6 = label_documentNo.Text;
            SetValueForText7 = datetimepicker_documentExpiry.Text;
            SetValueForText8 = numeric_weight.Text;
            Form2 frm2 = new Form2();
            frm2.Show();
             if (radioButton1.Checked == true)
            {
                MessageBox.Show("You are selected Red !! ");
                return;
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You are selected Blue !! ");
                return;
            }
            else
            {
                MessageBox.Show("You are selected Green !! ");
                return;
            }
        }

        private void label_calender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
