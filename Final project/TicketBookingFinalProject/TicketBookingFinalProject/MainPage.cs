using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBookingFinalProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ActionOnUserItems actionOnUserItems = new ActionOnUserItems();
            actionOnUserItems.Show();
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            ActionOnTicketItems actionOnTicketItems = new ActionOnTicketItems();
            actionOnTicketItems.Show();
        }

        private void buttonVenue_Click(object sender, EventArgs e)
        {
            ActionOnVenueItems actionOnVenueItems = new ActionOnVenueItems();
            actionOnVenueItems.Show();
        }

        private void buttonBookTicket_Click(object sender, EventArgs e)
        {
            ActionOnBookingTicket actionOnBookingTicket = new ActionOnBookingTicket();
            actionOnBookingTicket.Show();
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            ActionOnEventItems actionOnEventItems = new ActionOnEventItems();
            actionOnEventItems.Show();
        }
    }
}
