using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FlexiSkills.Models.Flexi;

namespace FlexiSkills.Models
{
    public partial class FlexiDbContext : DbContext
    {
        public FlexiDbContext()
        {
        }

        public FlexiDbContext(DbContextOptions<FlexiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Models.Flexi.Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=213.171.204.36;Initial Catalog=Flexi_db;Persist Security Info=True;User ID=Josh_dbnew;Password=<password>");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_course_student");
            });

            modelBuilder.Entity<Flexi.Student>(entity =>
            {
                entity.Property(e => e.TotalFeesDue).HasDefaultValueSql("((0.0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
