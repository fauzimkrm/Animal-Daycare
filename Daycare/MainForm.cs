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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pickUpButton_Click(object sender, EventArgs e)
        {
            PickupForm f = new PickupForm();
            f.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void daycareButton_Click(object sender, EventArgs e)
        {
            DaycareForm f = new DaycareForm();
            f.Show();
            this.Hide();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            f.Show();
            this.Hide();
        }

        private void buttonDataDaycare_Click(object sender, EventArgs e)
        {
            DataDaycareForm f = new DataDaycareForm();
            f.Show();
            this.Hide();
        }
    }
}
