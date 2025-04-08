using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BirthCertificate;


namespace Myapp
{
    public partial class AdminDashboard : Form
    {
        public static AdminDashboard instance;
        private string _username;
        private LoginForm loginForm;
        public AdminDashboard(LoginForm form, string username)
        {
            InitializeComponent();
            instance = this;
            _username = username;
            loginForm = form;
        }

        private void Userdashboard_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(64, 211, 211, 211);
            labelwelcome.Text = $"Welcome, {_username}";
            label1.Text = _username; this.Load += Userdashboard_Load; // Subscribe to the Load event

        }

        private void guna2GradientButtondwnpdf_Click(object sender, EventArgs e)
        {
            // Create an instance of ApplyForm
            //ApplyForm applyForm = new ApplyForm(this.loginForm, this._username);
            //CertificateAuth applyForm = new CertificateAuth(this.loginForm, this._username);
            CertificateAuth applyForm = new CertificateAuth(this.loginForm,this);

            // Show ApplyForm
            applyForm.Show();

            // Optionally, hide the current Userdashboard form
            this.Hide(); // Uncomment if you want to hide the Userdashboard
        }

        /*private void guna2ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginForm previousForm = new LoginForm();
            loginForm.ShowDialog();
        }*/

        private void guna2GradientButtonapply_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement(this);
            userManagement.ShowDialog(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();

            //depricated code
            //this.Hide();
            //LoginForm previousForm = new LoginForm();
        }

        
    }
}
