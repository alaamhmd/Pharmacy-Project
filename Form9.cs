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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void prescribeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prescribeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_DBDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacy_DBDataSet.prescribe' table. You can move, or remove it, as needed.
            this.prescribeTableAdapter.Fill(this.pharmacy_DBDataSet.prescribe);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.prescribeBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.prescribeBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prescribeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacy_DBDataSet);
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
    }
}
