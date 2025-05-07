using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchedulingApp;

namespace Performance.Assessment.Software.II.Advanced.Ccharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to open the database connection
                DbConnection.OpenConnection();

                // Simulate successful login
                MessageBox.Show("You have successfully logged in.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the connection (optional, depending on your app flow)
                DbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}