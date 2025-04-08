using System.Windows.Forms;

namespace BirthCertificate
{
    partial class ApplyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPlaceOfBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFatherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMotherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdoMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnAddRecord = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderRadius = 20;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(155, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Username";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(403, 42);
            this.txtName.TabIndex = 10;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateOfBirth.BorderRadius = 15;
            this.dtpDateOfBirth.BorderThickness = 2;
            this.dtpDateOfBirth.Checked = true;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(155, 172);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(403, 45);
            this.dtpDateOfBirth.TabIndex = 9;
            this.dtpDateOfBirth.Value = new System.DateTime(2024, 9, 28, 21, 11, 52, 138);
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.txtPlaceOfBirth.BorderColor = System.Drawing.Color.Black;
            this.txtPlaceOfBirth.BorderRadius = 15;
            this.txtPlaceOfBirth.BorderThickness = 2;
            this.txtPlaceOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaceOfBirth.DefaultText = "";
            this.txtPlaceOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(155, 242);
            this.txtPlaceOfBirth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.PasswordChar = '\0';
            this.txtPlaceOfBirth.PlaceholderText = "Place of Birth";
            this.txtPlaceOfBirth.SelectedText = "";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(403, 45);
            this.txtPlaceOfBirth.TabIndex = 8;
            // 
            // txtFatherName
            // 
            this.txtFatherName.BackColor = System.Drawing.Color.Transparent;
            this.txtFatherName.BorderColor = System.Drawing.Color.Black;
            this.txtFatherName.BorderRadius = 15;
            this.txtFatherName.BorderThickness = 2;
            this.txtFatherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFatherName.DefaultText = "";
            this.txtFatherName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFatherName.Location = new System.Drawing.Point(155, 319);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.PasswordChar = '\0';
            this.txtFatherName.PlaceholderText = "Father Name";
            this.txtFatherName.SelectedText = "";
            this.txtFatherName.Size = new System.Drawing.Size(403, 45);
            this.txtFatherName.TabIndex = 7;
            // 
            // txtMotherName
            // 
            this.txtMotherName.BackColor = System.Drawing.Color.Transparent;
            this.txtMotherName.BorderColor = System.Drawing.Color.Black;
            this.txtMotherName.BorderRadius = 15;
            this.txtMotherName.BorderThickness = 2;
            this.txtMotherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotherName.DefaultText = "";
            this.txtMotherName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotherName.Location = new System.Drawing.Point(155, 391);
            this.txtMotherName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.PasswordChar = '\0';
            this.txtMotherName.PlaceholderText = "Mother Name";
            this.txtMotherName.SelectedText = "";
            this.txtMotherName.Size = new System.Drawing.Size(403, 45);
            this.txtMotherName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.BorderRadius = 15;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(155, 472);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(403, 45);
            this.txtAddress.TabIndex = 5;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.CheckedState.BorderThickness = 0;
            this.rdoMale.Location = new System.Drawing.Point(212, 554);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 24);
            this.rdoMale.TabIndex = 4;
            this.rdoMale.Text = "Male";
            this.rdoMale.UncheckedState.BorderThickness = 0;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.CheckedState.BorderThickness = 0;
            this.rdoFemale.Location = new System.Drawing.Point(393, 554);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(87, 24);
            this.rdoFemale.TabIndex = 3;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UncheckedState.BorderThickness = 0;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRecord.BorderRadius = 15;
            this.btnAddRecord.BorderThickness = 1;
            this.btnAddRecord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.ForeColor = System.Drawing.Color.Black;
            this.btnAddRecord.Location = new System.Drawing.Point(542, 620);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(150, 45);
            this.btnAddRecord.TabIndex = 2;
            this.btnAddRecord.Text = "Apply";
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(148, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(433, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Application for Birth Certificate";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 15;
            this.btnBack.BorderThickness = 1;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(24, 620);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtPlaceOfBirth);
            this.panel1.Controls.Add(this.btnAddRecord);
            this.panel1.Controls.Add(this.txtFatherName);
            this.panel1.Controls.Add(this.rdoFemale);
            this.panel1.Controls.Add(this.txtMotherName);
            this.panel1.Controls.Add(this.rdoMale);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Location = new System.Drawing.Point(270, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 694);
            this.panel1.TabIndex = 11;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.Location = new System.Drawing.Point(280, 620);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(150, 45);
            this.guna2GradientButton1.TabIndex = 11;
            this.guna2GradientButton1.Text = "Clear";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // ApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Myapp.Properties.Resources._1_b8WS2iEvZCQYlXq46gKpqw;
            this.ClientSize = new System.Drawing.Size(1217, 816);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ApplyForm";
            this.Text = "Application for Birth Certificate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Current_FormClosing);
            this.Load += new System.EventHandler(this.ApplyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaceOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtFatherName;
        private Guna.UI2.WinForms.Guna2TextBox txtMotherName;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2RadioButton rdoMale;
        private Guna.UI2.WinForms.Guna2RadioButton rdoFemale;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddRecord;
        private System.Windows.Forms.Label labelTitle; // Label for title
        private Guna.UI2.WinForms.Guna2GradientButton btnBack; // Back button
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;

    }
}
