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
        private MilitaryUnit division;
        public WeaponsForm()
        {
            InitializeComponent();

            Creator creator = new Creator();
            division = creator.CreateFirstMilitaryUnit();

            int price = division.CalculateEquipmentCost();
            
            foreach (Weapon weapon in division.GetEquipment())
            {
                weaponsLB.Items.Add(weapon.GetName() + " - " + weapon.GetCost());
            }

            SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditBtn.Enabled = true;
            DeleteBtn.Enabled = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            WeaponTransfer weaponTransfer = new WeaponTransfer();
            weaponTransfer.weapon = new Weapon();
            EditForm editForm = new EditForm(weaponTransfer);
            editForm.ShowDialog();
            if (weaponTransfer.weapon != null)
            {
                division.Equip(weaponTransfer.weapon);
                weaponsLB.Items.Add(weaponTransfer.weapon.GetName() + " - " + weaponTransfer.weapon.GetCost());
                SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();
            }
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Weapon weapon = division.GetEquipment()[weaponsLB.SelectedIndex] as Weapon;
            //division.Unequip(weapon);
            EditForm editForm = new EditForm(weapon);
            editForm.ShowDialog();
            if (weapon != null)
            {
                //division.Equip(weapon);
                weaponsLB.Items.Add(weapon.GetName() + " - " + weapon.GetCost());
                SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();
            }
        }
    }
}
