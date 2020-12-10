using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daycare
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

        private void registOwnerButton_Click(object sender, EventArgs e)
        {
            CustomerForm f = new CustomerForm();
            f.Show();
            this.Hide();
        }

        private void registPetButton_Click(object sender, EventArgs e)
        {
            PetForm f = new PetForm();
            f.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DaycareForm f = new DaycareForm();
            f.Show();
            this.Hide();
        }
    }
}
