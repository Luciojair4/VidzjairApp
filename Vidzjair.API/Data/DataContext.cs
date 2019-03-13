using Microsoft.EntityFrameworkCore;
using Vidzjair.API.models;

namespace Vidzjair.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
                                                      
         public DbSet<Value> values { get; set; } 
    }
}