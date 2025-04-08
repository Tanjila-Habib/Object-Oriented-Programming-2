using System.Windows.Forms;

namespace Myapp
{
    partial class Signup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientButtonBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButtonCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2GradientButtonBack);
            this.panel1.Controls.Add(this.guna2GradientButtonCreate);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.guna2TextBoxEmail);
            this.panel1.Controls.Add(this.guna2TextBoxUsername);
            this.panel1.Location = new System.Drawing.Point(296, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 666);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter information for creating account";
            // 
            // guna2GradientButtonBack
            // 
            this.guna2GradientButtonBack.AutoRoundedCorners = true;
            this.guna2GradientButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButtonBack.BorderRadius = 21;
            this.guna2GradientButtonBack.BorderThickness = 2;
            this.guna2GradientButtonBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButtonBack.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButtonBack.Location = new System.Drawing.Point(393, 458);
            this.guna2GradientButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButtonBack.Name = "guna2GradientButtonBack";
            this.guna2GradientButtonBack.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButtonBack.TabIndex = 5;
            this.guna2GradientButtonBack.Text = "Back";
            this.guna2GradientButtonBack.Click += new System.EventHandler(this.guna2GradientButtonBack_Click);
            // 
            // guna2GradientButtonCreate
            // 
            this.guna2GradientButtonCreate.AutoRoundedCorners = true;
            this.guna2GradientButtonCreate.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButtonCreate.BorderRadius = 21;
            this.guna2GradientButtonCreate.BorderThickness = 2;
            this.guna2GradientButtonCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButtonCreate.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButtonCreate.Location = new System.Drawing.Point(114, 458);
            this.guna2GradientButtonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButtonCreate.Name = "guna2GradientButtonCreate";
            this.guna2GradientButtonCreate.Size = new System.Drawing.Size(201, 45);
            this.guna2GradientButtonCreate.TabIndex = 4;
            this.guna2GradientButtonCreate.Text = "Create Account";
            this.guna2GradientButtonCreate.Click += new System.EventHandler(this.guna2GradientButtonCreate_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 26;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::Myapp.Properties.Resources.password_76;
            this.guna2TextBox1.Location = new System.Drawing.Point(140, 284);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Password";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(327, 55);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // guna2TextBoxEmail
            // 
            this.guna2TextBoxEmail.AutoRoundedCorners = true;
            this.guna2TextBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxEmail.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxEmail.BorderRadius = 26;
            this.guna2TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxEmail.DefaultText = "";
            this.guna2TextBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxEmail.IconLeft = global::Myapp.Properties.Resources._3178158;
            this.guna2TextBoxEmail.Location = new System.Drawing.Point(140, 199);
            this.guna2TextBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBoxEmail.Name = "guna2TextBoxEmail";
            this.guna2TextBoxEmail.PasswordChar = '\0';
            this.guna2TextBoxEmail.PlaceholderText = "Email";
            this.guna2TextBoxEmail.SelectedText = "";
            this.guna2TextBoxEmail.Size = new System.Drawing.Size(327, 55);
            this.guna2TextBoxEmail.TabIndex = 1;
            // 
            // guna2TextBoxUsername
            // 
            this.guna2TextBoxUsername.AutoRoundedCorners = true;
            this.guna2TextBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxUsername.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxUsername.BorderRadius = 26;
            this.guna2TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxUsername.DefaultText = "";
            this.guna2TextBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxUsername.IconLeft = global::Myapp.Properties.Resources.username_1;
            this.guna2TextBoxUsername.Location = new System.Drawing.Point(140, 112);
            this.guna2TextBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBoxUsername.Name = "guna2TextBoxUsername";
            this.guna2TextBoxUsername.PasswordChar = '\0';
            this.guna2TextBoxUsername.PlaceholderText = "Username";
            this.guna2TextBoxUsername.SelectedText = "";
            this.guna2TextBoxUsername.Size = new System.Drawing.Size(327, 55);
            this.guna2TextBoxUsername.TabIndex = 0;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Myapp.Properties.Resources._1_b8WS2iEvZCQYlXq46gKpqw;
            this.ClientSize = new System.Drawing.Size(1238, 875);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Signup";
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Current_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonCreate;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButtonBack;
        private System.Windows.Forms.Label label1;
    }
}