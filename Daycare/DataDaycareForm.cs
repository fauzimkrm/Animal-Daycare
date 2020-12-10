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
    public partial class DataDaycareForm : Form
    {
        public DataDaycareForm()
        {
            InitializeComponent();
            display_data();
        }

        public void display_data()
        {
            var context = new db_daycareContextEntities();
            var data = from a in context.Daycares where a.dayare_status == 1

                       join e in context.Employees on a.employee_id equals e.employee_id into tmp3
                       from emp in tmp3.DefaultIfEmpty()

                       join p in context.Pets on a.pet_id equals p.pet_id into tmp
                       from pet in tmp.DefaultIfEmpty()

                       join pt in context.Pet_Types on pet.pet_type_id equals pt.pet_type_id into tmp1
                       from type in tmp1.DefaultIfEmpty()

                       join o in context.Customers on pet.customer_id equals o.customer_id into tmp2
                       from own in tmp2.DefaultIfEmpty()

                       select new
                       {
                           ID = a.daycare_id,
                           Pet = pet.pet_name,
                           Jenis = type.pet_type_name,
                           Owner = own.customer_name,
                           Start = a.daycare_date,
                           Pickup = a.daycare_pickup_date,
                           Pegawai = emp.employee_name

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
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }
    }
}
