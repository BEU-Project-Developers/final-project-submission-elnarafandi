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
    public partial class ActionOnVenueItems : Form
    {
        public ActionOnVenueItems()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateVenue();
        }
        private void CreateVenue()
        {
            string venueName = textVenueName.Text;
            string location = textLocation.Text;
            int capacity;
            if (string.IsNullOrWhiteSpace(venueName) || string.IsNullOrWhiteSpace(location) || !int.TryParse(textCapacity.Text, out capacity))
            {
                MessageBox.Show("Please fill in all fields with valid information.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            Venue newVenue = new Venue()
            {
                Name = venueName,
                Location = location,
                Capacity = capacity
            };
            dbContext.Venues.Add(newVenue);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Venue created successfully!");

                textVenueName.Clear();
                textLocation.Clear();
                textCapacity.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateVenue();
        }
        private void UpdateVenue()
        {
            int venueId;
            if (!int.TryParse(textVenueId.Text, out venueId))
            {
                MessageBox.Show("Please enter a valid Venue ID.");
                return;
            }
            string venueName = textVenueName.Text;
            string location = textLocation.Text;
            int capacity;

            if (string.IsNullOrWhiteSpace(venueName) && string.IsNullOrWhiteSpace(location) &&
            string.IsNullOrWhiteSpace(textCapacity.Text))
            {
                MessageBox.Show("Please fill in at least one field to update.");
                return;
            }

            if (!int.TryParse(textCapacity.Text, out capacity) && !string.IsNullOrWhiteSpace(textCapacity.Text))
            {
                MessageBox.Show("Please enter a valid Capacity.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            var venue = dbContext.Venues.FirstOrDefault(v => v.Id == venueId);

            if (venue == null)
            {
                MessageBox.Show("Venue not found. Please check the Venue ID.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(venueName))
            {
                venue.Name = venueName;
            }

            if (!string.IsNullOrWhiteSpace(location))
            {
                venue.Location = location;
            }
            if (!string.IsNullOrWhiteSpace(textCapacity.Text))
            {
                venue.Capacity = capacity;
            }
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Venue updated successfully!");

                textVenueId.Clear();
                textVenueName.Clear();
                textLocation.Clear();
                textCapacity.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteVenue();
        }
        private void DeleteVenue()
        {
            int venueId;
            if (!int.TryParse(textVenueId.Text, out venueId))
            {
                MessageBox.Show("Please enter a valid Venue ID.");
                return;
            }
            AppDbContext dbContext = new AppDbContext();
            var venue = dbContext.Venues.FirstOrDefault(v => v.Id == venueId);

            if (venue == null)
            {
                MessageBox.Show("Venue not found. Please check the Venue ID.");
                return;
            }
            dbContext.Venues.Remove(venue);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Venue deleted successfully!");

                textVenueId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadVenuesData();
        }
        private void LoadVenuesData()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var venues = context.Venues.ToList();
                dataGridView1.DataSource = venues;
            }
        }
    }
}
