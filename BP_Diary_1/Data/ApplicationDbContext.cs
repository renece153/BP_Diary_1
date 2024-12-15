using Microsoft.EntityFrameworkCore;
using BP_Diary_1.Models;

namespace BP_Diary_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<bp_diary> bp_diary { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
