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
    public partial class PickupForm : Form
    {
        public PickupForm()
        {
            InitializeComponent();
            panelForm.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var context = new db_daycareContextEntities();
            int idDaycare = Convert.ToInt32(textBoxSearch.Text);
            var query = (from a in context.Daycares
                         where a.daycare_id == idDaycare
                         select a);
            var daycare = query.FirstOrDefault<Daycares>();
            

            if (daycare != null)
            {
                var pet = context.Pets.Find(daycare.pet_id);
                var petType = context.Pet_Types.Find(pet.pet_type_id);
                var owner = context.Customers.Find(pet.customer_id);

                var dateDaycare = Convert.ToDateTime(daycare.daycare_date);
                var datePickup = Convert.ToDateTime(daycare.daycare_pickup_date);

                labelPetName.Text = pet.pet_name;
                labelPetType.Text = petType.pet_type_name;
                labelOwner.Text = owner.customer_name;
                labelStart.Text = dateDaycare.ToString("yyyy-MM-dd");
                labelEnd.Text = datePickup.ToString("yyyy-MM-dd");
                panelForm.Show();
            }
            else
            {
                MessageBox.Show("Maaf data yang anda cari tidak ada!");
            }
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

        private void countCharger(object sender, EventArgs e)
        {
            var context = new db_daycareContextEntities();
            int idDaycare = int.Parse(textBoxSearch.Text);
            var daycare = context.Daycares.Find(idDaycare);
            var pickUpDate = Convert.ToDateTime(daycare.daycare_pickup_date);
            int dateTotal = (dateTimePickerPickupCharge.Value - pickUpDate).Days;
            int chargeCost = dateTotal * 50000;
            labelCost.Text = chargeCost.ToString();
        }

        private void buttonPickup_Click(object sender, EventArgs e)
        {
            var context = new db_daycareContextEntities();

            var pickup = new Pickups();
            pickup.daycare_id = int.Parse(textBoxSearch.Text);
            pickup.pickup_date = dateTimePickerPickupCharge.Value;
            pickup.pickup_charge = int.Parse(labelCost.Text);
            context.Pickups.Add(pickup);

            int daycareId = int.Parse(textBoxSearch.Text);
            var daycare = (from a in context.Daycares
                       where a.daycare_id == daycareId
                       select a).Single();

            daycare.dayare_status = 0;
            context.SaveChanges();

            SuccessForm f = new SuccessForm();
            f.Show();
            this.Hide();
        }
    }
}
