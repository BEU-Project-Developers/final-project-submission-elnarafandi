using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketBookingFinalProject.Data;

namespace TicketBookingFinalProject
{
    public partial class ActionOnSignIn : Form
    {
        public ActionOnSignIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }
        private void SignIn()
        {
            string username = textUsername.Text;
            string password = textPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            var user = dbContext.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
            if (user.Password == password)
            {
                MessageBox.Show("Sign in successful!");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
