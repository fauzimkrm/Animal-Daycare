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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            display_data();
        }

        public void display_data()
        {
            var context = new db_daycareContextEntities();
            var data = from a in context.Customers
                       select new
                       {
                           ID = a.customer_id,
                           Nama = a.customer_name,
                           Alamat = a.customer_address,
                           NoTelp = a.customer_phone
                       };
            dataGridView1.DataSource = data.ToList();
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
            RegistrationForm f = new RegistrationForm();
            f.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm f = new AddCustomerForm();
            f.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditCustomerForm f = new EditCustomerForm();
            f.Show();
            this.Hide();
        }
    }
}
