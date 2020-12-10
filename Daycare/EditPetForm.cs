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
    public partial class EditPetForm : Form
    {
        public EditPetForm()
        {
            InitializeComponent();
            panelForm.Hide();
        }

        private void EditPetForm_Load(object sender, EventArgs e)
        {
            db_daycareContextEntities context = new db_daycareContextEntities();

            List<Pet_Types> petTypes = (from t in context.Pet_Types
                                        select t).ToList();
            petTypes.Insert(0, new Pet_Types
             {
                 pet_type_id = 0,
                 pet_type_name = "Please select"
             });
            typeComboBox.DataSource = petTypes;
            typeComboBox.ValueMember = "pet_type_id";
            typeComboBox.DisplayMember = "pet_type_name";

            List<Customers> customer = (from c in context.Customers
                                        select c).ToList();
            customer.Insert(0, new Customers
            {
                customer_id = 0,
                customer_name = "Please select"
            });
            ownerComboBox.DataSource = customer;
            ownerComboBox.ValueMember = "customer_id";
            ownerComboBox.DisplayMember = "customer_name";
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
            PetForm f = new PetForm();
            f.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var context = new db_daycareContextEntities();
            var query = (from a in context.Pets
                         where a.pet_name == textBoxSearch.Text
                         select a);
            var pet = query.FirstOrDefault<Pets>();

            if (pet != null)
            {
                nameTextBox.Text = pet.pet_name;
                ownerComboBox.SelectedValue = pet.customer_id;
                typeComboBox.SelectedValue = pet.pet_type_id;
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
            var pet = (from a in context.Pets
                        where a.pet_name == textBoxSearch.Text
                        select a).Single();

            pet.pet_name = nameTextBox.Text;
            pet.customer_id = int.Parse(ownerComboBox.SelectedValue.ToString());
            pet.pet_type_id = int.Parse(typeComboBox.SelectedValue.ToString());

            context.SaveChanges();
            MessageBox.Show("Data telah berhasil diupdate.");

            PetForm f = new PetForm();
            f.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string nama = textBoxSearch.Text;
            var contex = new db_daycareContextEntities();
            var pet = (from a in contex.Pets where a.pet_name == nama select a).Single();
            contex.Pets.Remove(pet);
            contex.SaveChanges();

            MessageBox.Show("Data telah berhasil dihapus.");

            PetForm f = new PetForm();
            f.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ownerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
