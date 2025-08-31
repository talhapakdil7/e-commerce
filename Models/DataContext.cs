using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        
       public DbSet<Urun> Urunler { get; set; }
    }
}