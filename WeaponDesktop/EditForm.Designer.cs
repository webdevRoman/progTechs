using System.Windows.Forms;

namespace WeaponDesktop
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DamageBox = new System.Windows.Forms.TextBox();
            this.ClassLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.DamageLbl = new System.Windows.Forms.Label();
            this.InitCostBox = new System.Windows.Forms.TextBox();
            this.InitCostLbl = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(249, 12);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(121, 24);
            this.ClassBox.TabIndex = 0;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(249, 65);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 22);
            this.NameBox.TabIndex = 1;
            // 
            // DamageBox
            // 
            this.DamageBox.Location = new System.Drawing.Point(249, 119);
            this.DamageBox.Name = "DamageBox";
            this.DamageBox.Size = new System.Drawing.Size(121, 22);
            this.DamageBox.TabIndex = 2;
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.Location = new System.Drawing.Point(21, 18);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(46, 17);
            this.ClassLbl.TabIndex = 3;
            this.ClassLbl.Text = "Class:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(21, 70);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name:";
            this.NameLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // DamageLbl
            // 
            this.DamageLbl.AutoSize = true;
            this.DamageLbl.Location = new System.Drawing.Point(21, 124);
            this.DamageLbl.Name = "DamageLbl";
            this.DamageLbl.Size = new System.Drawing.Size(103, 17);
            this.DamageLbl.TabIndex = 5;
            this.DamageLbl.Text = "Damage Proof:";
            // 
            // InitCostBox
            // 
            this.InitCostBox.Location = new System.Drawing.Point(249, 174);
            this.InitCostBox.Name = "InitCostBox";
            this.InitCostBox.Size = new System.Drawing.Size(121, 22);
            this.InitCostBox.TabIndex = 6;
            // 
            // InitCostLbl
            // 
            this.InitCostLbl.AutoSize = true;
            this.InitCostLbl.Location = new System.Drawing.Point(21, 179);
            this.InitCostLbl.Name = "InitCostLbl";
            this.InitCostLbl.Size = new System.Drawing.Size(76, 17);
            this.InitCostLbl.TabIndex = 7;
            this.InitCostLbl.Text = "Initial Cost:";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(75, 416);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(237, 416);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.InitCostLbl);
            this.Controls.Add(this.InitCostBox);
            this.Controls.Add(this.DamageLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ClassLbl);
            this.Controls.Add(this.DamageBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ClassBox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ClassBox;
        private TextBox NameBox;
        private TextBox DamageBox;
        private Label ClassLbl;
        private Label NameLbl;
        private Label DamageLbl;
        private TextBox InitCostBox;
        private Label InitCostLbl;
        private Button OKBtn;
        private Button CancelBtn;

        private Label BrandLbl = new Label();
        private TextBox BrandBox = new TextBox();
        private Label DestrRangeLbl = new Label();
        private TextBox DestrRangeBox = new TextBox();
        private Label MagazineLbl = new Label();
        private TextBox MagazineBox = new TextBox();
        private Label RapidityLbl = new Label();
        private TextBox RapidityBox = new TextBox();

    }
}