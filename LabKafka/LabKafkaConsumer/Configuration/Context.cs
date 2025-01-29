using LabKafkaConsumer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LabKafkaConsumer.Configuration
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Proposta> Propostas { get; set; }
    }
}
