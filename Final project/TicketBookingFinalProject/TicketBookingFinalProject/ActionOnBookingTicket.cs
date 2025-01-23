using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
using TicketBookingFinalProject.Models;

namespace TicketBookingFinalProject
{
    public partial class ActionOnBookingTicket : Form
    {
        public ActionOnBookingTicket()
        {
            InitializeComponent();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            AppDbContext _dbContext = new AppDbContext();
            try
            {
                int ticketId = Convert.ToInt32(textTicketId.Text);
                string userEmail = textUserEmail.Text;
                var ticket = _dbContext.Tickets.FirstOrDefault(t => t.Id == ticketId);
                if (ticket == null)
                {
                    MessageBox.Show("Ticket not found!");
                    return;
                }
                if (ticket.IsBooked)
                {
                    MessageBox.Show("This ticket is already booked.");
                    return;
                }
                var user = _dbContext.Users.FirstOrDefault(u => u.Email == userEmail);
                if (user == null)
                {
                    MessageBox.Show("User with the provided email not found!");
                    return;
                }
                ticket.IsBooked = true;
                ticket.UserId = user.Id;
                _dbContext.SaveChanges();
                MessageBox.Show("Ticket successfully booked!");
                textTicketId.Clear();
                textUserEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var tickets = context.Tickets.ToList();
                dataGridView1.DataSource = tickets;
            }
        }
    }
}
