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
        WeaponTransfer weaponTransfer;
        public EditForm(WeaponTransfer _weaponTransfer)
        {
            InitializeComponent();
            
            ClassBox.Items.Add("Weapon");
            ClassBox.Items.Add("BladedWeapon");
            ClassBox.Items.Add("Firearm");
            ClassBox.Items.Add("AutomaticWeapon");

            weaponTransfer = _weaponTransfer;
        }

        public EditForm(Weapon _weapon)
        {
            InitializeComponent();

            ClassBox.Items.Add("Weapon");
            ClassBox.Items.Add("BladedWeapon");
            ClassBox.Items.Add("Firearm");
            ClassBox.Items.Add("AutomaticWeapon");

            DamageNum.Minimum = 0;
            DamageNum.Maximum = 1000000;
            InitCostNum.Minimum = 0;
            InitCostNum.Maximum = 1000000;
            BrandNum.Minimum = 0;
            BrandNum.Maximum = 1000000;
            BladeNum.Minimum = 0;
            BladeNum.Maximum = 1000000;
            DestrRangeNum.Minimum = 0;
            DestrRangeNum.Maximum = 1000000;
            MagazineNum.Minimum = 0;
            MagazineNum.Maximum = 1000000;
            RapidityNum.Minimum = 0;
            RapidityNum.Maximum = 1000000;

            if (_weapon != null)
            {
                ClassBox.Text = _weapon.GetType().ToString();
                //this.ClassBox_SelectedIndexChanged(this, e);
                NameBox.Text = _weapon.GetName();
                DamageNum.Value = _weapon.GetDamageProof();
                InitCostNum.Value = _weapon.GetInitialCost();
                switch (_weapon.GetType().ToString())
                {
                    case "BladedWeapon":
                        {
                            BladedWeapon _bladedWeapon = (_weapon as BladedWeapon);
                            BrandNum.Value = _bladedWeapon.GetBrandClass();
                            BladeNum.Value = _bladedWeapon.GetBladeLength();
                        }
                        break;
                    case "Firearm":
                        {
                            Firearm _firearm = (_weapon as Firearm);
                            DestrRangeNum.Value = _firearm.GetDestructionRange();
                            MagazineNum.Value = _firearm.GetMagazineCapacity();
                        }
                        break;
                    case "AutomaticWeapon":
                        {
                            AutomaticWeapon _automaticWeapon = (_weapon as AutomaticWeapon);
                            DestrRangeNum.Value = _automaticWeapon.GetDestructionRange();
                            MagazineNum.Value = _automaticWeapon.GetMagazineCapacity();
                            RapidityNum.Value = _automaticWeapon.GetRapidity();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
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
                        BladeLbl.Text = "Blade Length:";
                        BladeNum.Width = NameBox.Width;
                        BladeLbl.Location = new Point(BrandLbl.Location.X, BrandLbl.Location.Y + 50);
                        BladeNum.Location = new Point(BrandNum.Location.X, BrandNum.Location.Y + 50);
                        this.Controls.Add(BladeLbl);
                        this.Controls.Add(BladeNum);
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
                        Weapon newWeapon = new Weapon(NameBox.Text, (int)DamageNum.Value, (int)InitCostNum.Value);
                        weaponTransfer.weapon = newWeapon;
                        Dispose();
                    }
                    break;
                case "BladedWeapon":
                    {
                        BladedWeapon newWeapon = new BladedWeapon(NameBox.Text, (int)DamageNum.Value, (int)InitCostNum.Value, (int)BrandNum.Value, (int)BladeNum.Value);
                        weaponTransfer.weapon = newWeapon;
                        Dispose();
                    }
                    break;
                case "Firearm":
                    {
                        Firearm newWeapon = new Firearm(NameBox.Text, (int)DamageNum.Value, (int)InitCostNum.Value, (int)DestrRangeNum.Value, (int)MagazineNum.Value);
                        weaponTransfer.weapon = newWeapon;
                        Dispose();
                    }
                    break;
                case "AutomaticWeapon":
                    {
                        AutomaticWeapon newWeapon = new AutomaticWeapon(NameBox.Text, (int)DamageNum.Value, (int)InitCostNum.Value, (int)DestrRangeNum.Value, (int)MagazineNum.Value, (int)RapidityNum.Value);
                        weaponTransfer.weapon = newWeapon;
                        Dispose();
                    }
                    break;
                default:
                    {
                        weaponTransfer.weapon = null;
                        MessageBox.Show("Class name was entered incorrectly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            weaponTransfer.weapon = null;
            Dispose();
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            weaponTransfer.weapon = null;
        }
    }
}
