using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HDaycareManager.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Kid> Kids { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
//            modelBuilder.Entity<Attendance>()
//                .HasRequired(a => a.Parent)
//                .WithMany()
//                .WillCascadeOnDelete(false);
//            
//                
            base.OnModelCreating(modelBuilder);
        }
    }
}