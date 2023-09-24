using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketingSystem.Models;

namespace TicketingSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TicketStatus>().HasData(
                new TicketStatus() { Id = 1, Name = "New" },
                new TicketStatus() { Id = 2, Name = "Active" },
                new TicketStatus() { Id = 3, Name = "Redirect" },
                new TicketStatus() { Id = 4, Name = "Done" }
                );

            base.OnModelCreating(builder);
        }

        //We Forgot to add set; to properties
        public DbSet<TicketStatus> TicketStatus { get;}
        public DbSet<Company> Company { get;}
        public DbSet<Department> Department { get;}
        public DbSet<Ticket> Ticket { get;}
        public DbSet<TicketLog> TicketLog { get;}

    }
}
