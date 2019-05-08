using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponDesktop
{
    public partial class WeaponsForm : Form
    {
        public WeaponsForm()
        {
            InitializeComponent();

            Creator creator = new Creator();
            MilitaryUnit division = creator.CreateFirstMilitaryUnit();

            int price = division.CalculateEquipmentCost();

            int i = 0;
            foreach (Weapon weapon in division.GetEquipment())
            {
                weaponsLB.Items.Add(weapon.GetName() + " - " + weapon.GetCost());
                i++;
            }

            SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
        }
    }
}
