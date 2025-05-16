using Microsoft.EntityFrameworkCore;
using ContactAPI.Models; // we'll create the model class in Step 3

namespace ContactAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }
            public DbSet<Contact> Contacts { get; set; }
        

    }
}
