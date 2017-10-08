using Envision.EnCMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Envision.EnCMS.Data
{

    public class EnCMSContext : DbContext
    {
        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Error> Errors { get; set; }

        public EnCMSContext(DbContextOptions options) : base(options)
        {
        }
        //public virtual void Commit()
        //{
        //    base.SaveChanges();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }
            modelBuilder.Entity<Gadget>().Property(b => b.Name).IsRequired();
            modelBuilder.Entity<Category>().Property(b => b.Name).IsRequired();           
            // Photos
            modelBuilder.Entity<Photo>().Property(p => p.Title).HasMaxLength(100);
            modelBuilder.Entity<Photo>().Property(p => p.AlbumId).IsRequired();
            // Album
            modelBuilder.Entity<Album>().Property(a => a.Title).HasMaxLength(100);
            modelBuilder.Entity<Album>().Property(a => a.Description).HasMaxLength(500);
            modelBuilder.Entity<Album>().HasMany(a => a.Photos).WithOne(p => p.Album);

            // User
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.Salt).IsRequired().HasMaxLength(200);

            // UserRole
            modelBuilder.Entity<UserRole>().Property(ur => ur.UserId).IsRequired();
            modelBuilder.Entity<UserRole>().Property(ur => ur.RoleId).IsRequired();

            // Role
            modelBuilder.Entity<Role>().Property(r => r.Name).IsRequired().HasMaxLength(50);

            //modelBuilder.ApplyConfiguration<GadgetConfiguration>;
            //modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }

}
    
