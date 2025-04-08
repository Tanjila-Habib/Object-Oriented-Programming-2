using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Myapp
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public LoginForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 211, 211, 211);
        }

        private void guna2GradientButtoncrtacc_Click(object sender, EventArgs e)
        {
            Signup form = new Signup(this);
            form.Show();
            this.Hide();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {

                guna2TextBoxpass.PasswordChar = '\0';
            }
            else
            {
                guna2TextBoxpass.PasswordChar = '*';
            }
        }

        private void guna2GradientButtonLogin_Click(object sender, EventArgs e)
        {
            string username = guna2TextBoxUsername.Text;
            string password = guna2TextBoxpass.Text;

            //MessageBox.Show("Username: " + username + ", password: " + password);
            var (userAuthStatus, userType) = AuthenticateUser(username, password);

            if (userAuthStatus.Equals("active", StringComparison.OrdinalIgnoreCase))
            {
                //if (userType=="admin")
                if (userType.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    AdminDashboard form = new AdminDashboard(this, username);
                    form.Show();
                    this.Hide();
                }
                else if (userType.Equals("user", StringComparison.OrdinalIgnoreCase))
                {
                    Userdashboard form = new Userdashboard(this, username);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password(usertype)!!!");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password(usertype)!!!");
            }
        }


        public static (string userAuthStatus, string userType) AuthenticateUser(string username, string password)
        {
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";
            string userAuthStatus = "F";
            string userType = "unknown";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UserType, Status FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userType = reader["UserType"].ToString();
                                userAuthStatus = reader["Status"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., log the error)
                    Console.WriteLine("Error: " + ex.Message);
                }
            }



            return (userAuthStatus, userType);
        }
    }
}
