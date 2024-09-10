
using HospitalManagement_MVC_.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement_MVC_.DB
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> option ) : base(option)
        {
            
        }

        public DbSet<Hospital> Hospitals { get; set; }

    }
}
