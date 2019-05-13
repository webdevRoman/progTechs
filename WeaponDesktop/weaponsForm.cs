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
        private Weapon weapon;

        public WeaponsForm()
        {
            InitializeComponent();
            //Создание исходного подразделения
            Creator creator = new Creator();
            division = creator.CreateFirstMilitaryUnit();
            //Заполнение формы
            foreach (Weapon weapon in division.GetEquipment())
                weaponsLB.Items.Add(weapon.GetName() + " - " + weapon.GetCost());
            SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(division);
            editForm.ShowDialog();
            //Обновление данной формы
            weaponsLB.Items.Clear();
            foreach (Weapon weapon in division.GetEquipment())
                weaponsLB.Items.Add(weapon.GetName() + " - " + weapon.GetCost());
            SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //Проверка, выбрано ли оружие
            if (weaponsLB.SelectedIndex == -1)
                MessageBox.Show("Weapon was not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int index = weaponsLB.SelectedIndex;
                weapon = division.GetEquipment()[index] as Weapon;
                EditForm editForm = new EditForm(division, weapon);
                editForm.ShowDialog();
                division.Unequip(weapon);
                //Обновление данной формы
                weaponsLB.Items.Clear();
                foreach (Weapon weapon in division.GetEquipment())
                    weaponsLB.Items.Add(weapon.GetName() + " - " + weapon.GetCost());
                SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Проверка, выбрано ли оружие
            if (weaponsLB.SelectedIndex == -1)
                MessageBox.Show("Weapon was not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int index = weaponsLB.SelectedIndex;
                weapon = division.GetEquipment()[index] as Weapon;
                division.Unequip(weapon);
                //Удаление оружия из списка
                weaponsLB.Items.RemoveAt(index);
                SumLbl.Text = "Total cost: " + division.CalculateEquipmentCost();
            }
        }
    }
}
