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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to Exit?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure you want to Exit?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form16 Drug = new Form16();
            Drug.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 sell = new Form13();
            sell.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 work = new Form14();
            work.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 info = new Form6();
            info.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 prescribe = new Form9();
            prescribe.Show();
        }
    }
}
