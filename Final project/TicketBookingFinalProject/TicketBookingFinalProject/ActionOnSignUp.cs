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
using TicketBookingFinalProject.Models;

namespace TicketBookingFinalProject
{
    public partial class ActionOnSignUp : Form
    {
        public ActionOnSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }
        private void SignUp()
        {
            string fullname = textFullname.Text;
            string email = textEmail.Text;
            string username = textUsername.Text;
            string password = textPassword.Text;
            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required. Please fill out all fields.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            bool userExists = dbContext.Users.Any(u => u.Username == username || u.Email == email);
            if (userExists)
            {
                MessageBox.Show("Username or email already exists. Please choose another.");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email.");
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password is not valid. It must be at least 6 characters long and contain at least one number.");
                return;
            }
            User newUser = new User()
            {
                FullName = fullname,
                Email = email,
                Username = username,
                Password = password
            };
            dbContext.Users.Add(newUser);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Registration successful!");
                ActionOnSignIn actionOnSignIn=new ActionOnSignIn();
                actionOnSignIn.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression to check if the email contains '@' and has a basic valid structure
            var emailRegex = new Regex(@"^[^@]+@[^@]+\.[^@]+$");
            return emailRegex.IsMatch(email);
        }
        private bool IsValidPassword(string password)
        {
            // Regular expression: at least 6 characters long and contains at least one number
            var passwordRegex = new Regex(@"^(?=.*\d)[A-Za-z\d]{6,}$");
            return passwordRegex.IsMatch(password);
        }

    }
}
