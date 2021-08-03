using auth.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace LoginAspCoreReact.Models
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext>options) 
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(s => s.IdUser);
        }
        public DbSet<User> Users { get; set; }
    }
}
