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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        public void Form2_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            label_name.Text = Form1.SetValueForText1;
            label_fname.Text = Form1.SetValueForText1;
            label_email.Text = Form1.SetValueForText2;
            label_from.Text = Form1.SetValueForText3;
            label_to.Text = Form1.SetValueForText4;
            label_date.Text = Form1.SetValueForText5;
            label_documentno.Text = Form1.SetValueForText6;
            label_expiry.Text = Form1.SetValueForText7;
            label_weight.Text = Form1.SetValueForText8;


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_date_Click(object sender, EventArgs e)
        {


        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void label_from_Click(object sender, EventArgs e)
        {

        }

        private void label_to_Click(object sender, EventArgs e)
        {

        }

        private void label_expiry_Click(object sender, EventArgs e)
        {

        }

        private void label_documentno_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
