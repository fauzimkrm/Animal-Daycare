﻿using System;
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
    public partial class AddPetForm : Form
    {
        public AddPetForm()
        {
            InitializeComponent();
        }

        private void AddPetForm_Load(object sender, EventArgs e)
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

        private void addPetButton_Click(object sender, EventArgs e)
        {
            db_daycareContextEntities context = new db_daycareContextEntities();
            
            var pet = new Pets();
            pet.pet_name = nameTextBox.Text;
            //pet.customer_id = (int)ownerComboBox.SelectedIndex;
            //pet.pet_type_id = (int)typeComboBox.SelectedIndex;
            pet.customer_id = int.Parse(ownerComboBox.SelectedValue.ToString());
            pet.pet_type_id = int.Parse(typeComboBox.SelectedValue.ToString());
            context.Pets.Add(pet);
            context.SaveChanges();

            MessageBox.Show("Peliharaan berhasil ditambah!");

            PetForm f = new PetForm();
            f.Show();
            this.Hide();
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
    }
}
