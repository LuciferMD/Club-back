using Club.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Club.Infastructure.Data
{
    public class ClubDBContext : DbContext
    {
        public ClubDBContext(DbContextOptions<ClubDBContext> options) : base (options)  
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Completed>().HasKey(com => new
            {
                com.User_id,
                com.Enter_id
            });

            modelBuilder.Entity<Completed>().HasOne(com => com.User).WithMany(u => u.Commpleteds).HasForeignKey(c => c.User_id);
            modelBuilder.Entity<Completed>().HasOne(com => com.Entertainment).WithMany(e => e.Commpleteds).HasForeignKey(c => c.Enter_id);

            modelBuilder.Entity<Uncompleted>().HasOne(u => u.User).WithMany(u => u.Uncommpleteds).HasForeignKey(u => u.User_id);
            modelBuilder.Entity<Uncompleted>().HasOne(u => u.Entertainment).WithMany(u => u.Uncommpleteds).HasForeignKey(u => u.Enter_id);

            modelBuilder.Entity<Review>().HasOne(r => r.User).WithMany(u => u.Reviews).HasForeignKey(r => r.User_id);
            modelBuilder.Entity<Review>().HasOne(r => r.Entertainment).WithMany(e => e.Reviews).HasForeignKey(r => r.Enter_id);

            

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Entertainment> Entertainments { get; set; }
        public DbSet<Completed> Completeds { get; set; }
        public DbSet<Uncompleted> Uncompleteds { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }

    }
}
