using Microsoft.EntityFrameworkCore;
using BP_Diary_1.Models;

namespace BP_Diary_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<bp_diary_records> bp_diary { get; set; }

		public virtual DbSet<bp_diary_records> Sample { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<bp_diary_records>(entity =>
			{
				entity.HasKey(e => e.bp_diary_id); // Define primary key
                entity.Property(e => e.bp_diary_id).ValueGeneratedOnAdd();
                entity.Property(e => e.date_record).HasDefaultValueSql("NOW()");
				entity.Property(e => e.systolic).IsRequired();
				entity.Property(e => e.diastolic).IsRequired();
			});
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Host=127.0.0.1;Database=postgres;Username=postgres;Password=password");
		}
	}

}
