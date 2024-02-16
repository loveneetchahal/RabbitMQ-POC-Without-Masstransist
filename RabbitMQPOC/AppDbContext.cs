using MassTransit;
using Microsoft.EntityFrameworkCore;
using RabbitMQPOC.Models;

namespace RabbitMQPOC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> product { get; set; }
    }
}
