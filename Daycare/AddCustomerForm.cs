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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            var contex = new db_daycareContextEntities();
            var cust = new Customers();
            cust.customer_name = nameTextBox.Text;
            cust.customer_address = addressTextBox.Text;
            cust.customer_phone = phoneTextBox.Text;
            contex.Customers.Add(cust);
            contex.SaveChanges();

            MessageBox.Show("Tambah data owner pet berhasil!!");

            CustomerForm f = new CustomerForm();
            f.Show();
            this.Hide();
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
            CustomerForm f = new CustomerForm();
            f.Show();
            this.Hide();
        }
    }
}
