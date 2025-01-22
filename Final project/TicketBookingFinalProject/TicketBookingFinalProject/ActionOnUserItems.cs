using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketBookingFinalProject.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketBookingFinalProject
{
    public partial class ActionOnUserItems : Form
    {
        public ActionOnUserItems()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
        private void UpdateUser()
        {
            int userId;
            if (!int.TryParse(textId.Text, out userId))
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }
            string fullname = textFullname.Text;
            string email = textEmail.Text;
            string username = textUsername.Text;
            string password = textPassword.Text;
            if (string.IsNullOrWhiteSpace(fullname) && string.IsNullOrWhiteSpace(email) &&
            string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter at least one field to update.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            var user = dbContext.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                MessageBox.Show("User not found. Please check the User ID.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(fullname))
            {
                user.FullName = fullname;
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email.");
                    return;
                }
                user.Email = email;
            }
            if (!string.IsNullOrWhiteSpace(username))
            {
                user.Username = username;
            }

            if (!string.IsNullOrWhiteSpace(password))
            {
                if (!IsValidPassword(password))
                {
                    MessageBox.Show("Password is not valid. It must be at least 6 characters long and contain at least one number.");
                    return;
                }
                user.Password = password;
            }
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("User updated successfully!");
                textFullname.Clear();
                textEmail.Clear();
                textPassword.Clear();
                textUsername.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        // Method to validate email using a simple regex check
        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[^@]+@[^@]+\.[^@]+$");
            return emailRegex.IsMatch(email);
        }

        // Method to validate password using a regular expression (example: at least 6 characters and contains at least one number)
        private bool IsValidPassword(string password)
        {
            var passwordRegex = new Regex(@"^(?=.*\d)[A-Za-z\d]{6,}$");
            return passwordRegex.IsMatch(password);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
        private void DeleteUser()
        {
            int userId;
            if (!int.TryParse(textId.Text, out userId))
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            var user = dbContext.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                MessageBox.Show("User not found. Please check the User ID.");
                return;
            }
            var tickets = dbContext.Tickets.Where(t => t.UserId == userId).ToList();

            if (tickets.Any())
            {
                
                dbContext.Tickets.RemoveRange(tickets);
            }
            dbContext.Users.Remove(user);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("User deleted successfully!");
                textId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var users = context.Users.ToList();
                dataGridView1.DataSource = users;
            }
        }
    }
}
