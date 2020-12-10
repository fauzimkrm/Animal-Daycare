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
    public partial class AddDaycareForm : Form
    {
        public AddDaycareForm()
        {
            InitializeComponent();
        }

        private void DaycareForm_Load(object sender, EventArgs e)
        {
            db_daycareContextEntities context = new db_daycareContextEntities();

            List<Employees> employees = (from t in context.Employees
                                        select t).ToList();
            employees.Insert(0, new Employees
            {
                employee_id = 0,
                employee_name = "Please select"
            });
            comboBoxEmployee.DataSource = employees;
            comboBoxEmployee.ValueMember = "employee_id";
            comboBoxEmployee.DisplayMember = "employee_name";

            List<Pets> pets = (from c in context.Pets
                                        select c).ToList();
            pets.Insert(0, new Pets
            {
                pet_id = 0,
                pet_name = "Please select"
            });
            comboBoxPet.DataSource = pets;
            comboBoxPet.ValueMember = "pet_id";
            comboBoxPet.DisplayMember = "pet_name";
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
            DaycareForm f = new DaycareForm();
            f.Show();
            this.Hide();
        }

        private void countCost(object sender, EventArgs e)
        {
            db_daycareContextEntities context = new db_daycareContextEntities();
            int idPet = int.Parse(comboBoxPet.SelectedValue.ToString());
            var pet = context.Pets.Find(idPet);
            var petType = context.Pet_Types.Find(pet.pet_type_id);

            int totalDate = (dateTimePickerPickup.Value - dateTimePickerDaycare.Value).Days;
            int totalCost = totalDate * Convert.ToInt32(petType.pet_type_cost);
            labelCost.Text = totalCost.ToString();
        }

        private void proccessButton_Click(object sender, EventArgs e)
        {
            db_daycareContextEntities context = new db_daycareContextEntities();
            var daycare = new Daycares();

            daycare.employee_id = int.Parse(comboBoxEmployee.SelectedValue.ToString());
            daycare.pet_id = int.Parse(comboBoxPet.SelectedValue.ToString());
            daycare.daycare_date = dateTimePickerDaycare.Value;
            daycare.daycare_pickup_date = dateTimePickerPickup.Value;
            daycare.daycare_cost = Convert.ToInt32(labelCost.Text);
            daycare.dayare_status = 1;

            context.Daycares.Add(daycare);
            context.SaveChanges();

            SuccessForm f = new SuccessForm();
            f.Show();
            this.Hide();
        }
    }
}
