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
                        for (int i = 0; i < this.Controls.Count - 10; i++)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 2);
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }
                    }
                    break;
                case "BladedWeapon":
                    {
                        for (int i = 0; i < this.Controls.Count - 10; i++)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 2);
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }

                        BrandLbl.Text = "Brand Class:";
                        BrandBox.Width = NameBox.Width;
                        BrandLbl.Location = new Point(InitCostLbl.Location.X, InitCostLbl.Location.Y + 50);
                        BrandBox.Location = new Point(InitCostBox.Location.X, InitCostBox.Location.Y + 50);
                        //Добавляем событие нажатия на новую кнопку 
                        //(то же что и при нажатии на исходную)
                        //temp.Click += new EventHandler(button1_Click);
                        this.Controls.Add(BrandLbl);
                        this.Controls.Add(BrandBox);
                    }
                    break;
                case "Firearm":
                    {
                        for (int i = 0; i < this.Controls.Count - 10; i++)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 2);
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }

                        DestrRangeLbl.Text = "Destruction Range:";
                        DestrRangeBox.Width = NameBox.Width;
                        DestrRangeLbl.Location = new Point(InitCostLbl.Location.X, InitCostLbl.Location.Y + 50);
                        DestrRangeBox.Location = new Point(InitCostBox.Location.X, InitCostBox.Location.Y + 50);
                        this.Controls.Add(DestrRangeLbl);
                        this.Controls.Add(DestrRangeBox);

                        MagazineLbl.Text = "Magazine Capacity:";
                        MagazineBox.Width = NameBox.Width;
                        MagazineLbl.Location = new Point(DestrRangeLbl.Location.X, DestrRangeLbl.Location.Y + 50);
                        MagazineBox.Location = new Point(DestrRangeBox.Location.X, DestrRangeBox.Location.Y + 50);
                        this.Controls.Add(MagazineLbl);
                        this.Controls.Add(MagazineBox);
                    }
                    break;
                case "AutomaticWeapon":
                    {
                        for (int i = 0; i < this.Controls.Count - 10; i++)
                        {
                            this.Controls.RemoveAt(this.Controls.Count - 2);
                            this.Controls.RemoveAt(this.Controls.Count - 1);
                        }

                        DestrRangeLbl.Text = "Destruction Range:";
                        DestrRangeBox.Width = NameBox.Width;
                        DestrRangeLbl.Location = new Point(InitCostLbl.Location.X, InitCostLbl.Location.Y + 50);
                        DestrRangeBox.Location = new Point(InitCostBox.Location.X, InitCostBox.Location.Y + 50);
                        this.Controls.Add(DestrRangeLbl);
                        this.Controls.Add(DestrRangeBox);

                        MagazineLbl.Text = "Magazine Capacity:";
                        MagazineBox.Width = NameBox.Width;
                        MagazineLbl.Location = new Point(DestrRangeLbl.Location.X, DestrRangeLbl.Location.Y + 50);
                        MagazineBox.Location = new Point(DestrRangeBox.Location.X, DestrRangeBox.Location.Y + 50);
                        this.Controls.Add(MagazineLbl);
                        this.Controls.Add(MagazineBox);

                        RapidityLbl.Text = "Rapidity:";
                        RapidityBox.Width = NameBox.Width;
                        RapidityLbl.Location = new Point(MagazineLbl.Location.X, MagazineLbl.Location.Y + 50);
                        RapidityBox.Location = new Point(MagazineBox.Location.X, MagazineBox.Location.Y + 50);
                        this.Controls.Add(RapidityLbl);
                        this.Controls.Add(RapidityBox);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
