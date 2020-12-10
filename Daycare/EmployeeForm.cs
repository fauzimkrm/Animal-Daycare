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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            display_data();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

        public void display_data()
        {
            var context = new db_daycareContextEntities();
            var data = from a in context.Employees
                       select new
                       {
                           ID = a.employee_id,
                           Nama = a.employee_name,
                           Alamat = a.employee_address,
                           NoTelp = a.employee_phone
                       };
            dataGridView1.DataSource = data.ToList();
        }


        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm f = new AddEmployeeForm();
            f.Show();
            this.Hide();
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            EditEmployeeForm f = new EditEmployeeForm();
            f.Show();
            this.Hide();
        }
    }
}
