using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketBookingFinalProject.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
