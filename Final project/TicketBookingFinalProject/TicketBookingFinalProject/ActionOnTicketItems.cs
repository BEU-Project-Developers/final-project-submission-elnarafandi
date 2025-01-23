using Microsoft.EntityFrameworkCore;
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
    public partial class ActionOnTicketItems : Form
    {

        public ActionOnTicketItems()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                var tickets = context.Tickets.ToList();
                dataGridView1.DataSource = tickets;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                comboBox1.DataSource = context.Events.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            var eventCount = dbContext.Events.Count();

            if (eventCount == 0)
            {
                MessageBox.Show("There are no events available. Please add an event first.");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an event.");
                return;
            }
            int eventId = (int)comboBox1.SelectedValue;
            decimal ticketPrice;
            if (!decimal.TryParse(textPrice.Text, out ticketPrice) || ticketPrice <= 0)
            {
                MessageBox.Show("Please enter a valid Ticket Price.");
                return;
            }
            
            var selectedEvent = dbContext.Events
                                    .Where(e => e.Id == eventId)
                                    .Select(e => new
                                    {
                                        VenueCapacity = e.Venue.Capacity,
                                        TicketCount = dbContext.Tickets.Count(t => t.EventId == e.Id)
                                    })
                                    .FirstOrDefault();
            if (selectedEvent == null)
            {
                MessageBox.Show("Event not found.");
                return;
            }
            if (selectedEvent.TicketCount >= selectedEvent.VenueCapacity)
            {
                MessageBox.Show("The venue has reached its full capacity. No more tickets can be created for this event.");
                return;
            }
            Ticket newTicket = new Ticket
            {
                EventId = eventId,
                Price = ticketPrice,
                IsBooked = false
            };
            dbContext.Tickets.Add(newTicket);
            try
            {

                dbContext.SaveChanges();

                MessageBox.Show("Ticket created successfully!");

                comboBox1.SelectedIndex = -1;
                textPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            var eventCount = dbContext.Events.Count();

            if (eventCount == 0)
            {
                MessageBox.Show("There are no events available. Please add an event first.");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an event.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textTicketId.Text))
            {
                MessageBox.Show("Please enter a Ticket ID.");
                return;
            }
            int eventId = (int)comboBox1.SelectedValue;
            int ticketId;
            if (!int.TryParse(textTicketId.Text, out ticketId) || ticketId <= 0)
            {
                MessageBox.Show("Please enter a valid Ticket ID.");
                return;
            }
            decimal ticketPrice;
            if (!decimal.TryParse(textPrice.Text, out ticketPrice) || ticketPrice <= 0)
            {
                MessageBox.Show("Please enter a valid Ticket Price.");
                return;
            }
            

            var ticketToUpdate = dbContext.Tickets.FirstOrDefault(t => t.Id == ticketId);
            if (ticketToUpdate == null)
            {
                MessageBox.Show("Ticket not found.");
                return;
            }

            bool isEventChanged = ticketToUpdate.EventId != eventId;
            if (isEventChanged)
            {
                var selectedEvent = dbContext.Events
                    .Where(e => e.Id == eventId)
                    .Select(e => new
                    {
                        VenueCapacity = e.Venue.Capacity,
                        TicketCount = dbContext.Tickets.Count(t => t.EventId == e.Id)
                    })
                    .FirstOrDefault();

                if (selectedEvent == null)
                {
                    MessageBox.Show("Event not found.");
                    return;
                }

                if (selectedEvent.TicketCount >= selectedEvent.VenueCapacity)
                {
                    MessageBox.Show("The venue has reached its full capacity. No more tickets can be created for this event.");
                    return;
                }
            }

            ticketToUpdate.Price = ticketPrice;
            ticketToUpdate.EventId = eventId;
            try
            {
                dbContext.SaveChanges();

                MessageBox.Show("Ticket updated successfully!");

                comboBox1.SelectedIndex = -1;
                textTicketId.Clear();
                textPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textTicketId.Text))
            {
                MessageBox.Show("Please enter a Ticket ID.");
                return;
            }
            int ticketId;
            if (!int.TryParse(textTicketId.Text, out ticketId) || ticketId <= 0)
            {
                MessageBox.Show("Please enter a valid Ticket ID.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            var ticketToDelete = dbContext.Tickets.FirstOrDefault(t => t.Id == ticketId);

            if (ticketToDelete == null)
            {
                MessageBox.Show("Ticket not found.");
                return;
            }
            dbContext.Tickets.Remove(ticketToDelete);
            try
            {
                dbContext.SaveChanges();

                MessageBox.Show("Ticket deleted successfully!");

                textTicketId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
