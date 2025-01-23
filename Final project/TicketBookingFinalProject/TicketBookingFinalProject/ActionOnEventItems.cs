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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketBookingFinalProject
{
    public partial class ActionOnEventItems : Form
    {
        public ActionOnEventItems()
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
                var events = context.Events.ToList();
                dataGridView1.DataSource = events;
            }
        }

        private void comboBoxVenue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                comboBoxVenue.DataSource = context.Venues.ToList();
                comboBoxVenue.DisplayMember = "Name";
                comboBoxVenue.ValueMember = "Id";
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            var venueCount = dbContext.Venues.Count();

            if (venueCount == 0)
            {
                MessageBox.Show("There are no venues available. Please add a venue first.");
                return;
            }
            if (comboBoxVenue.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a venue.");
                return;
            }
            string eventName = textName.Text;
            DateTime eventDate = dateTimePicker1.Value;
            int venueId = (int)comboBoxVenue.SelectedValue;

            if (string.IsNullOrWhiteSpace(eventName))
            {
                MessageBox.Show("Please enter the event name.");
                return;
            }

            if (eventDate == null || eventDate <= DateTime.Now)
            {
                MessageBox.Show("Please select a valid future event date.");
                return;
            }


            var existingEvent = dbContext.Events
            .FirstOrDefault(e => e.Name == eventName && e.Date == eventDate &&
                                 e.VenueId == venueId);

            if (existingEvent != null)
            {
                MessageBox.Show("An event with the same name, date, and venue already exists. Please choose another date, name, or venue.");
                return;
            }

            Event newEvent = new Event
            {
                Name = eventName,
                Date = eventDate,
                VenueId = venueId
            };
            dbContext.Events.Add(newEvent);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Event created successfully!");
                textName.Clear();
                dateTimePicker1.Value = DateTime.Now;
                comboBoxVenue.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            var venueCount = dbContext.Venues.Count();

            if (venueCount == 0)
            {
                MessageBox.Show("There are no venues available. Please add a venue first.");
                return;
            }
            int eventId;
            if (!int.TryParse(textEventId.Text, out eventId))
            {
                MessageBox.Show("Please enter a valid Event ID.");
                return;
            }
            string eventName = textName.Text;
            DateTime eventDate = dateTimePicker1.Value;
            if (comboBoxVenue.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a venue.");
                return;
            }
            if (eventDate == null || eventDate <= DateTime.Now)
            {
                MessageBox.Show("Please select a valid future event date.");
                return;
            }
            int venueId = (int)comboBoxVenue.SelectedValue;
            if (string.IsNullOrWhiteSpace(eventName) && eventDate == DateTime.MinValue && venueId == 0)
            {
                MessageBox.Show("Please fill in at least one field to update.");
                return;
            }

            var existingEvent = dbContext.Events
            .FirstOrDefault(e => e.Name == eventName && e.Date == eventDate && e.VenueId == venueId);

            if (existingEvent != null)
            {
                MessageBox.Show("An event with the same name, date, and venue already exists. Please choose a different name, date, or venue.");
                return;
            }
            var eventToUpdate = dbContext.Events.FirstOrDefault(e => e.Id == eventId);
            if (eventToUpdate == null)
            {
                MessageBox.Show("Event not found. Please check the Event ID.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(eventName))
            {
                eventToUpdate.Name = eventName;
            }

            if (eventDate > DateTime.MinValue)
            {
                eventToUpdate.Date = eventDate;
            }

            if (venueId != 0)
            {
                eventToUpdate.VenueId = venueId;
            }
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Event updated successfully!");
                textEventId.Clear();
                textName.Clear();
                comboBoxVenue.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int eventId;
            if (!int.TryParse(textEventId.Text, out eventId))
            {
                MessageBox.Show("Please enter a valid Event ID.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            var eventToDelete = dbContext.Events.FirstOrDefault(e => e.Id == eventId);

            if (eventToDelete == null)
            {
                MessageBox.Show("Event not found. Please check the Event ID.");
                return;
            }
            try
            {
                dbContext.Events.Remove(eventToDelete);

                dbContext.SaveChanges();

                MessageBox.Show("Event deleted successfully!");

                textEventId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePicker1.ShowUpDown = true;
        }
    }
}
