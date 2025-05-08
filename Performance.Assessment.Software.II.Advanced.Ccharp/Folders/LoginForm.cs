using MySql.Data.MySqlClient;
using Performance.Assessment.Software.II.Advanced.Ccharp.Properties;
using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Performance.Assessment.Software.II.Advanced.Ccharp
{
    public partial class LoginForm : Form
    {
        // Database connection string for MySQL database
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        // Constructor - initializes the form and sets up default settings
        public LoginForm()
        {
            InitializeComponent();

            // Sets the user's time zone and location
            lblTimeZoneValueA.Text = TimeZoneInfo.Local.StandardName;
            lblLocationValueB.Text = new RegionInfo(CultureInfo.CurrentCulture.Name).DisplayName;

            // Populate the language selection combo box
            cbLanguage.Items.Add("English");
            cbLanguage.Items.Add("Spanish");
            cbLanguage.SelectedItem = "English"; // Default language

            // Register event handler for language selection changes
            cbLanguage.SelectedIndexChanged += cbLanguage_SelectedIndexChanged;

            // Apply the default language (English)
            ApplyLanguage("en");
        }

        // Event handler for the "Show Password" checkbox
        // Toggles the visibility of the password text
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Event handler for language selection changes
        // Switches the UI language based on the selected item in the combo box
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLang = cbLanguage.SelectedItem.ToString().ToLower();
            string langCode = selectedLang == "spanish" ? "es" : "en";
            ApplyLanguage(langCode);
        }

        // Applies the selected language to the form controls
        private void ApplyLanguage(string langCode)
        {
            // Set the current thread's culture to the selected language
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(langCode);

            // Update the form labels and buttons with localized text
            lblLanguage.Text = Resources.Language;
            lblUserContext.Text = Resources.Username;
            lblPassword.Text = Resources.Password;
            btnLogin.Text = Resources.Login;
        }

        // Authenticates the user against the MySQL database
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                // Get the connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

                // Open a new connection to the database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to check for matching username and password
                    string query = "SELECT COUNT(*) FROM user WHERE userName = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Use parameterized queries to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Check if there is a matching user record
                        int matchCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Return true if a matching user is found
                        return matchCount > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific errors
                MessageBox.Show($"Database connection error:\n\n{ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"An unexpected error occurred:\n\n{ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the entered username and password, trimming any extra spaces
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Check if either the username or password is empty
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both a username and password.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Attempt to authenticate the user
                if (AuthenticateUser(username, password))
                {
                    // Successful login message
                    MessageBox.Show("You have successfully logged in.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TODO: Navigate to the main application window (uncomment when ready)
                    // MainForm mainForm = new MainForm();
                    // mainForm.Show();
                    // this.Hide();
                }
                else
                {
                    // Show an error message for incorrect credentials
                    MessageBox.Show("Access Denied. Please enter the correct username and password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show($"An unexpected error occurred:\n\n{ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event handler for the login button click event



    }
}

