using Microsoft.EntityFrameworkCore;
using LibraryManagement_MVC_.Models;

namespace LibraryManagement_MVC_.DB
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> option ) : base(option)
        {
            
        }

        public DbSet< Library> Librarys { get; set; }
    }

}
