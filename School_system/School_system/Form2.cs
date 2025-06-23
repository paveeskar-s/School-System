using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace School_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {


            string firstName = FrtName.Text.Trim();
            string lastName = LtName.Text.Trim();
            int age = (int)numAge.Value;
            string homeTown = HTown.Text.Trim();
            string workingPlace = WorkPlace.Text.Trim();


            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (age < 1)
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(homeTown))
            {
                MessageBox.Show("Home town is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(workingPlace))
            {
                MessageBox.Show("Working place is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Form3 form3 = new Form3(firstName, lastName, age, homeTown, workingPlace);
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrtName.Text = "";
            LtName.Text = "";
            numAge.Value = numAge.Minimum;
            HTown.Text = "";
            WorkPlace.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

