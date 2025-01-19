using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketBookingProject.Data;
using TicketBookingProject.Models;

namespace TicketBookingProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fullname=txtEmail.Text;
            string email=txtEmail.Text;
            string username=txtUsername.Text;
            string password=txtPassword.Text;
            AppDbContext context = new AppDbContext();
            bool userExists = context.Users.Any(u => u.Username == username || u.Email == email);
            if (userExists)
            {
                MessageBox.Show("Username or email already exists. Please choose another.");
                return;
            }
            User newUser = new User
            {
                FullName = fullname,
                Email = email,
                Username = username,
                Password = password 
            };
            context.Users.Add(newUser);
            try
            {
                context.SaveChanges();
                MessageBox.Show("Registration successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
