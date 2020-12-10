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
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
            panelForm.Hide();
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var context = new db_daycareContextEntities();
            var query = (from a in context.Employees
                         where a.employee_name == textBoxSearch.Text
                         select a);
            var emp = query.FirstOrDefault<Employees>();

            if(emp != null)
            {
                nameTextBox.Text = emp.employee_name;
                addressTextBox.Text = emp.employee_address;
                phoneTextBox.Text = emp.employee_phone;
                panelForm.Show();
            }
            else
            {
                MessageBox.Show("Maaf data yang anda cari tidak ada!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var context = new db_daycareContextEntities();
            var emp = (from a in context.Employees
                          where a.employee_name == textBoxSearch.Text
                          select a).Single();

            emp.employee_name = nameTextBox.Text;
            emp.employee_address = addressTextBox.Text;
            emp.employee_phone = phoneTextBox.Text;

            context.SaveChanges();
            MessageBox.Show("Data telah berhasil diupdate.");

            EmployeeForm f = new EmployeeForm();
            f.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string nama = textBoxSearch.Text;
            var contex = new db_daycareContextEntities();
            var emp = (from a in contex.Employees where a.employee_name == nama select a).Single();
            contex.Employees.Remove(emp);
            contex.SaveChanges();

            MessageBox.Show("Data telah berhasil dihapus.");

            EmployeeForm f = new EmployeeForm();
            f.Show();
            this.Hide();
        }
    }
}
