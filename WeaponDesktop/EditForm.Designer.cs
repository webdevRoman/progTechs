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
            this.ClassLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.DamageLbl = new System.Windows.Forms.Label();
            this.InitCostLbl = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DamageNum = new System.Windows.Forms.NumericUpDown();
            this.InitCostNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DamageNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitCostNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(220, 12);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(150, 24);
            this.ClassBox.TabIndex = 0;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(220, 65);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(150, 22);
            this.NameBox.TabIndex = 1;
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.Location = new System.Drawing.Point(12, 15);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(46, 17);
            this.ClassLbl.TabIndex = 3;
            this.ClassLbl.Text = "Class:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(12, 68);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name:";
            this.NameLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // DamageLbl
            // 
            this.DamageLbl.AutoSize = true;
            this.DamageLbl.Location = new System.Drawing.Point(12, 122);
            this.DamageLbl.Name = "DamageLbl";
            this.DamageLbl.Size = new System.Drawing.Size(103, 17);
            this.DamageLbl.TabIndex = 5;
            this.DamageLbl.Text = "Damage Proof:";
            // 
            // InitCostLbl
            // 
            this.InitCostLbl.AutoSize = true;
            this.InitCostLbl.Location = new System.Drawing.Point(12, 177);
            this.InitCostLbl.Name = "InitCostLbl";
            this.InitCostLbl.Size = new System.Drawing.Size(76, 17);
            this.InitCostLbl.TabIndex = 7;
            this.InitCostLbl.Text = "Initial Cost:";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(61, 411);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(100, 30);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(220, 411);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 30);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DamageNum
            // 
            this.DamageNum.Location = new System.Drawing.Point(220, 120);
            this.DamageNum.Name = "DamageNum";
            this.DamageNum.Size = new System.Drawing.Size(150, 22);
            this.DamageNum.TabIndex = 10;
            // 
            // InitCostNum
            // 
            this.InitCostNum.Location = new System.Drawing.Point(220, 175);
            this.InitCostNum.Name = "InitCostNum";
            this.InitCostNum.Size = new System.Drawing.Size(150, 22);
            this.InitCostNum.TabIndex = 11;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.InitCostNum);
            this.Controls.Add(this.DamageNum);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.InitCostLbl);
            this.Controls.Add(this.DamageLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ClassLbl);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ClassBox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DamageNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitCostNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ClassBox;
        private TextBox NameBox;
        private Label ClassLbl;
        private Label NameLbl;
        private Label DamageLbl;
        private Label InitCostLbl;
        private NumericUpDown DamageNum;
        private NumericUpDown InitCostNum;
        private Button OKBtn;
        private Button CancelBtn;

        private Label BrandLbl = new Label();
        private NumericUpDown BrandNum = new NumericUpDown();
        private Label BladeLbl = new Label();
        private NumericUpDown BladeNum = new NumericUpDown();
        private Label DestrRangeLbl = new Label();
        private NumericUpDown DestrRangeNum = new NumericUpDown();
        private Label MagazineLbl = new Label();
        private NumericUpDown MagazineNum = new NumericUpDown();
        private Label RapidityLbl = new Label();
        private NumericUpDown RapidityNum = new NumericUpDown();
    }
}