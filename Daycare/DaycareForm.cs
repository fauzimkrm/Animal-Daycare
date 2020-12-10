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
    public partial class DaycareForm : Form
    {
        public DaycareForm()
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

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm f = new RegistrationForm();
            f.Show();
            this.Hide();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            AddDaycareForm f = new AddDaycareForm();
            f.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }
    }
}
