using Microsoft.EntityFrameworkCore;
using BP_Diary_1.Models;

namespace BP_Diary_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<bp_diary_records> bp_diary_records { get; set; }

        public override int SaveChanges()
        {
            ConvertDateTimesToUtc();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ConvertDateTimesToUtc();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void ConvertDateTimesToUtc()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    foreach (var property in entry.Properties)
                    {
                        if (property.Metadata.ClrType == typeof(DateTime))
                        {
                            if (property.CurrentValue is DateTime dateTime && dateTime.Kind == DateTimeKind.Local)
                            {
                                property.CurrentValue = dateTime.ToUniversalTime();
                            }
                        }
                    }
                }
            }
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<bp_diary_records>(entity =>
			{
				entity.HasKey(e => e.bp_diary_id); // Define primary key
                entity.Property(e => e.bp_diary_id).ValueGeneratedOnAdd();
                //entity.Property(e => e.date_record);
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
