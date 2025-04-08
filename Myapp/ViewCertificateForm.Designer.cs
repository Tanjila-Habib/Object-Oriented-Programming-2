using System;

namespace Myapp
{
    partial class ViewCertificateForm
    {
        private Guna.UI2.WinForms.Guna2TextBox txtSearchRecordID;
        private Guna.UI2.WinForms.Guna2Button btnLoadRecord;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaceOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtFatherName;
        private Guna.UI2.WinForms.Guna2TextBox txtMotherName;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2Button btnDownloadPDF;
        private System.Windows.Forms.Label lblSearchRecordID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPlaceOfBirth;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStatus;

        private void InitializeComponent()
        {
            this.txtSearchRecordID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLoadRecord = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPlaceOfBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFatherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMotherName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDownloadPDF = new Guna.UI2.WinForms.Guna2Button();
            this.lblSearchRecordID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchRecordID
            // 
            this.txtSearchRecordID.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchRecordID.BorderColor = System.Drawing.Color.Black;
            this.txtSearchRecordID.BorderRadius = 15;
            this.txtSearchRecordID.BorderThickness = 2;
            this.txtSearchRecordID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRecordID.DefaultText = "";
            this.txtSearchRecordID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchRecordID.Location = new System.Drawing.Point(169, 28);
            this.txtSearchRecordID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchRecordID.Name = "txtSearchRecordID";
            this.txtSearchRecordID.PasswordChar = '\0';
            this.txtSearchRecordID.PlaceholderText = "";
            this.txtSearchRecordID.SelectedText = "";
            this.txtSearchRecordID.Size = new System.Drawing.Size(320, 40);
            this.txtSearchRecordID.TabIndex = 0;
            // 
            // btnLoadRecord
            // 
            this.btnLoadRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadRecord.BorderRadius = 15;
            this.btnLoadRecord.BorderThickness = 2;
            this.btnLoadRecord.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRecord.ForeColor = System.Drawing.Color.Black;
            this.btnLoadRecord.Location = new System.Drawing.Point(505, 28);
            this.btnLoadRecord.Name = "btnLoadRecord";
            this.btnLoadRecord.Size = new System.Drawing.Size(114, 40);
            this.btnLoadRecord.TabIndex = 1;
            this.btnLoadRecord.Text = "Load";
            this.btnLoadRecord.Click += new System.EventHandler(this.btnLoadRecord_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderRadius = 15;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(169, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(320, 40);
            this.txtName.TabIndex = 2;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateOfBirth.BorderRadius = 15;
            this.dtpDateOfBirth.BorderThickness = 2;
            this.dtpDateOfBirth.Checked = true;
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(169, 158);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(320, 40);
            this.dtpDateOfBirth.TabIndex = 3;
            this.dtpDateOfBirth.Value = new System.DateTime(2024, 9, 28, 12, 6, 8, 668);
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.txtPlaceOfBirth.BorderColor = System.Drawing.Color.Black;
            this.txtPlaceOfBirth.BorderRadius = 15;
            this.txtPlaceOfBirth.BorderThickness = 2;
            this.txtPlaceOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaceOfBirth.DefaultText = "";
            this.txtPlaceOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(169, 218);
            this.txtPlaceOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.PasswordChar = '\0';
            this.txtPlaceOfBirth.PlaceholderText = "";
            this.txtPlaceOfBirth.ReadOnly = true;
            this.txtPlaceOfBirth.SelectedText = "";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(320, 40);
            this.txtPlaceOfBirth.TabIndex = 4;
            // 
            // txtFatherName
            // 
            this.txtFatherName.BackColor = System.Drawing.Color.Transparent;
            this.txtFatherName.BorderColor = System.Drawing.Color.Black;
            this.txtFatherName.BorderRadius = 15;
            this.txtFatherName.BorderThickness = 2;
            this.txtFatherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFatherName.DefaultText = "";
            this.txtFatherName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFatherName.Location = new System.Drawing.Point(169, 286);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.PasswordChar = '\0';
            this.txtFatherName.PlaceholderText = "";
            this.txtFatherName.ReadOnly = true;
            this.txtFatherName.SelectedText = "";
            this.txtFatherName.Size = new System.Drawing.Size(320, 40);
            this.txtFatherName.TabIndex = 5;
            // 
            // txtMotherName
            // 
            this.txtMotherName.BackColor = System.Drawing.Color.Transparent;
            this.txtMotherName.BorderColor = System.Drawing.Color.Black;
            this.txtMotherName.BorderRadius = 15;
            this.txtMotherName.BorderThickness = 2;
            this.txtMotherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotherName.DefaultText = "";
            this.txtMotherName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotherName.Location = new System.Drawing.Point(169, 358);
            this.txtMotherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.PasswordChar = '\0';
            this.txtMotherName.PlaceholderText = "";
            this.txtMotherName.ReadOnly = true;
            this.txtMotherName.SelectedText = "";
            this.txtMotherName.Size = new System.Drawing.Size(320, 40);
            this.txtMotherName.TabIndex = 6;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BorderColor = System.Drawing.Color.Black;
            this.txtGender.BorderRadius = 15;
            this.txtGender.BorderThickness = 2;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.DefaultText = "";
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGender.Location = new System.Drawing.Point(169, 422);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.PlaceholderText = "";
            this.txtGender.ReadOnly = true;
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(320, 40);
            this.txtGender.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.BorderRadius = 15;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(169, 495);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(320, 40);
            this.txtAddress.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BorderColor = System.Drawing.Color.Black;
            this.txtStatus.BorderRadius = 15;
            this.txtStatus.BorderThickness = 2;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStatus.Location = new System.Drawing.Point(169, 553);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.PlaceholderText = "";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(320, 40);
            this.txtStatus.TabIndex = 9;
            // 
            // btnDownloadPDF
            // 
            this.btnDownloadPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadPDF.BorderRadius = 15;
            this.btnDownloadPDF.BorderThickness = 2;
            this.btnDownloadPDF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadPDF.ForeColor = System.Drawing.Color.Black;
            this.btnDownloadPDF.Location = new System.Drawing.Point(469, 600);
            this.btnDownloadPDF.Name = "btnDownloadPDF";
            this.btnDownloadPDF.Size = new System.Drawing.Size(150, 40);
            this.btnDownloadPDF.TabIndex = 10;
            this.btnDownloadPDF.Text = "Download PDF";
            this.btnDownloadPDF.Click += new System.EventHandler(this.btnDownloadPDF_Click);
            // 
            // lblSearchRecordID
            // 
            this.lblSearchRecordID.AutoSize = true;
            this.lblSearchRecordID.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchRecordID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRecordID.Location = new System.Drawing.Point(13, 37);
            this.lblSearchRecordID.Name = "lblSearchRecordID";
            this.lblSearchRecordID.Size = new System.Drawing.Size(138, 20);
            this.lblSearchRecordID.TabIndex = 11;
            this.lblSearchRecordID.Text = "Search Record ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(34, 167);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(104, 20);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaceOfBirth.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(27, 234);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(108, 20);
            this.lblPlaceOfBirth.TabIndex = 14;
            this.lblPlaceOfBirth.Text = "Place of Birth:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.BackColor = System.Drawing.Color.Transparent;
            this.lblFatherName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.Location = new System.Drawing.Point(15, 302);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(117, 20);
            this.lblFatherName.TabIndex = 15;
            this.lblFatherName.Text = "Father\'s Name:";
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.BackColor = System.Drawing.Color.Transparent;
            this.lblMotherName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotherName.Location = new System.Drawing.Point(13, 374);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(126, 20);
            this.lblMotherName.TabIndex = 16;
            this.lblMotherName.Text = "Mother\'s Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(72, 433);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 17;
            this.lblGender.Text = "Gender:";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);

            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(68, 506);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 20);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(77, 573);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 20);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchRecordID);
            this.panel1.Controls.Add(this.btnLoadRecord);
            this.panel1.Controls.Add(this.lblSearchRecordID);
            this.panel1.Controls.Add(this.btnDownloadPDF);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.txtMotherName);
            this.panel1.Controls.Add(this.txtFatherName);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblMotherName);
            this.panel1.Controls.Add(this.lblFatherName);
            this.panel1.Controls.Add(this.txtPlaceOfBirth);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblDateOfBirth);
            this.panel1.Controls.Add(this.lblPlaceOfBirth);
            this.panel1.Location = new System.Drawing.Point(226, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 698);
            this.panel1.TabIndex = 20;
            // 
            // ViewCertificateForm
            // 
            this.BackgroundImage = global::Myapp.Properties.Resources._1_b8WS2iEvZCQYlXq46gKpqw;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel1);
            this.Name = "ViewCertificateForm";
            this.Text = "View Birth Certificate";
            this.Load += new System.EventHandler(this.ViewCertificateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void lblGender_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Panel panel1;
    }
}
