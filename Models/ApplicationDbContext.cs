using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication12.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Applicant> Applicants { get; set; }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<FormOfEducation> FormOfEducations { get; set; }

    public virtual DbSet<LoginType> LoginTypes { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PresenceOfSomething> PresenceOfSomethings { get; set; }

    public virtual DbSet<Speciality> Specialities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=DEMKA5;Username=postgres;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Applicant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("applicants_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("applications_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_applications_employee");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("employees_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FormOfEducation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("form_of_education_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LoginType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("login_type_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("post_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PresenceOfSomething>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("presence_of_something_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("speciality_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
