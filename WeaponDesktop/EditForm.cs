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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            
            ClassBox.Items.Add("Weapon");
            ClassBox.Items.Add("BladedWeapon");
            ClassBox.Items.Add("Firearm");
            ClassBox.Items.Add("AutomaticWeapon");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ClassBox.Text)
            {
                case "Weapon":
                    {
                        while (this.Controls.Count > 10)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }

                    }
                    break;
                case "BladedWeapon":
                    {
                        while (this.Controls.Count > 10)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }
                        BrandLbl.Text = "Brand Class:";
                        BrandNum.Width = NameBox.Width;
                        BrandLbl.Location = new Point(InitCostLbl.Location.X, InitCostLbl.Location.Y + 50);
                        BrandNum.Location = new Point(InitCostNum.Location.X, InitCostNum.Location.Y + 50);
                        this.Controls.Add(BrandLbl);
                        this.Controls.Add(BrandNum);
                    }
                    break;
                case "Firearm":
                    {
                        while (this.Controls.Count > 10)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }
                        DestrRangeLbl.Text = "Destruction Range:";
                        DestrRangeNum.Width = NameBox.Width;
                        DestrRangeLbl.Location = new Point(InitCostLbl.Location.X, InitCostLbl.Location.Y + 50);
                        DestrRangeNum.Location = new Point(InitCostNum.Location.X, InitCostNum.Location.Y + 50);
                        this.Controls.Add(DestrRangeLbl);
                        this.Controls.Add(DestrRangeNum);
                        MagazineLbl.Text = "Magazine Capacity:";
                        MagazineNum.Width = NameBox.Width;
                        MagazineLbl.Location = new Point(DestrRangeLbl.Location.X, DestrRangeLbl.Location.Y + 50);
                        MagazineNum.Location = new Point(DestrRangeNum.Location.X, DestrRangeNum.Location.Y + 50);
                        this.Controls.Add(MagazineLbl);
                        this.Controls.Add(MagazineNum);
                    }
                    break;
                case "AutomaticWeapon":
                    {
                        while (this.Controls.Count > 10)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }
                        DestrRangeLbl.Text = "Destruction Range:";
                        DestrRangeNum.Width = NameBox.Width;
                        DestrRangeLbl.Location = new Point(InitCostLbl.Location.X, InitCostLbl.Location.Y + 50);
                        DestrRangeNum.Location = new Point(InitCostNum.Location.X, InitCostNum.Location.Y + 50);
                        this.Controls.Add(DestrRangeLbl);
                        this.Controls.Add(DestrRangeNum);
                        MagazineLbl.Text = "Magazine Capacity:";
                        MagazineNum.Width = NameBox.Width;
                        MagazineLbl.Location = new Point(DestrRangeLbl.Location.X, DestrRangeLbl.Location.Y + 50);
                        MagazineNum.Location = new Point(DestrRangeNum.Location.X, DestrRangeNum.Location.Y + 50);
                        this.Controls.Add(MagazineLbl);
                        this.Controls.Add(MagazineNum);
                        RapidityLbl.Text = "Rapidity:";
                        RapidityNum.Width = NameBox.Width;
                        RapidityLbl.Location = new Point(MagazineLbl.Location.X, MagazineLbl.Location.Y + 50);
                        RapidityNum.Location = new Point(MagazineNum.Location.X, MagazineNum.Location.Y + 50);
                        this.Controls.Add(RapidityLbl);
                        this.Controls.Add(RapidityNum);
                    }
                    break;
                default:
                    break;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            switch (ClassBox.Text)
            {
                case "Weapon":
                    {
                        Weapon newWeapon = new Weapon(ClassBox.Text, (int)DamageNum.Value, (int)InitCostNum.Value);
                        
                    }
                    break;
                case "BladedWeapon":
                    {
                        
                    }
                    break;
                case "Firearm":
                    {
                        
                    }
                    break;
                case "AutomaticWeapon":
                    {
                        
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
