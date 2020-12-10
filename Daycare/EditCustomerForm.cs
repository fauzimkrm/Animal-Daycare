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
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
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
            CustomerForm f = new CustomerForm();
            f.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var context = new db_daycareContextEntities();
            var query = (from a in context.Customers
                         where a.customer_name == textBoxSearch.Text
                         select a);
            var cust = query.FirstOrDefault<Customers>();

            if (cust != null)
            {
                nameTextBox.Text = cust.customer_name;
                addressTextBox.Text = cust.customer_address;
                phoneTextBox.Text = cust.customer_phone;
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
            var cust = (from a in context.Customers
                       where a.customer_name == textBoxSearch.Text
                       select a).Single();

            cust.customer_name = nameTextBox.Text;
            cust.customer_address = addressTextBox.Text;
            cust.customer_phone = phoneTextBox.Text;

            context.SaveChanges();
            MessageBox.Show("Data telah berhasil diupdate.");

            CustomerForm f = new CustomerForm();
            f.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string nama = textBoxSearch.Text;
            var contex = new db_daycareContextEntities();
            var cust = (from a in contex.Customers where a.customer_name == nama select a).Single();
            contex.Customers.Remove(cust);
            contex.SaveChanges();

            MessageBox.Show("Data telah berhasil dihapus.");

            CustomerForm f = new CustomerForm();
            f.Show();
            this.Hide();
        }
    }
}
