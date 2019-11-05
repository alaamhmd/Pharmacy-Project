using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 Doctors= new Form8();
            Doctors.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 Patient = new Form15();
            Patient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 Pharmacy = new Form10();
            Pharmacy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 Pharmacist = new Form12();
            Pharmacist.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "q1" && textBox2.Text == "q2")
                {
                
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
           
            button7.Enabled = true;
                textBox1.Clear();
                textBox2.Clear();


            }
            else {
               MessageBox.Show ("Please Enter The correct Username and Password", "Pharmacy Management System");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;

            
          
          
     
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 Drugs = new Form16();
            Drugs.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to Exit?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
