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
    public partial class PetForm : Form
    {
        public PetForm()
        {
            InitializeComponent();
            display_data();
        }

        public void display_data()
        {
            var context = new db_daycareContextEntities();
            var data = from a in context.Pets
                       join customer in context.Customers on a.customer_id equals customer.customer_id into tmp 
                       from cust in tmp.DefaultIfEmpty()
                       join petType in context.Pet_Types on a.pet_type_id equals petType.pet_type_id into tmp1
                       from type in tmp1.DefaultIfEmpty()

                       select new
                       {
                           ID = a.pet_id,
                           Nama = a.pet_name,
                           Jenis = type.pet_type_name,
                           Owner = cust.customer_name
                           
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
            AddPetForm f = new AddPetForm();
            f.Show();
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditPetForm f = new EditPetForm();
            f.Show();
            this.Hide();
        }
    }
}
