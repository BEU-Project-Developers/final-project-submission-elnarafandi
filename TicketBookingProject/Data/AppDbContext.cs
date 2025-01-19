using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingProject.Models;

namespace TicketBookingProject
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MSI\\SQLEXPRESS;Database=TicketBookingDb;Trusted_Connection=True;");
        }
    }
}
