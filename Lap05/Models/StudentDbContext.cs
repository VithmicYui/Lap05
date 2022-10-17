using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lap05.Models
{
    public partial class StudentDbContext : DbContext
    {
        public StudentDbContext()
            : base("name=StudentDbContext")
        {
        }

        public virtual DbSet<Faculty1> Faculty1 { get; set; }
        public virtual DbSet<Student1> Student1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty1>()
                .HasMany(e => e.Student1)
                .WithRequired(e => e.Faculty1)
                .WillCascadeOnDelete(false);
        }
    }
}
