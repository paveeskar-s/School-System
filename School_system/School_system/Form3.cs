using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_system
{
    public partial class Form3 : Form
    {
        public Form3(string firstName, string lastName, int age, string homeTown, string workingPlace)
        {
            {
                InitializeComponent();

                txtFirstName.Text = firstName;
                lbllastname.Text = lastName;
                numAge.Text = age.ToString();
                lblhome.Text = homeTown;
                iblWorkPlace.Text = workingPlace;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
