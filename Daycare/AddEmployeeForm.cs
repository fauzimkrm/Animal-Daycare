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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
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

        private void backButton_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            f.Show();
            this.Hide();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var contex = new db_daycareContextEntities();
            var emp = new Employees();
            emp.employee_name = nameTextBox.Text;
            emp.employee_address = addressTextBox.Text;
            emp.employee_phone = phoneTextBox.Text;
            contex.Employees.Add(emp);
            contex.SaveChanges();

            MessageBox.Show("Tambah data pegawai berhasil!!");

            EmployeeForm f = new EmployeeForm();
            f.Show();
            this.Hide();
        }
    }
}
