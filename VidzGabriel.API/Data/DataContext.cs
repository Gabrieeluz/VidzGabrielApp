using Microsoft.EntityFrameworkCore;
using VidzGabriel.API.Models;

namespace VidzGabriel.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}