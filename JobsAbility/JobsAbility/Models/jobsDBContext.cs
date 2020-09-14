using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobsAbility.Models
{
    public partial class jobsDBContext : DbContext
    {
        public jobsDBContext()
        {
        }

        public jobsDBContext(DbContextOptions<jobsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Disabilities> Disabilities { get; set; }
        public virtual DbSet<JobApplications> JobApplications { get; set; }
        public virtual DbSet<JobPostings> JobPostings { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=jobsabilitydb.cte2cofecdcz.us-east-2.rds.amazonaws.com,1433;Database=jobsDB;User Id=admin;Password=Enter123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.IsMain).HasColumnName("isMain");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasIndex(e => e.Iso)
                    .HasName("uc_Countries_Iso")
                    .IsUnique();

                entity.Property(e => e.Iso)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Iso3)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Disabilities>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<JobApplications>(entity =>
            {
                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.JobApplicationsApplicant)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_JobApplications_Users1");

                entity.HasOne(d => d.JobPosting)
                    .WithMany(p => p.JobApplications)
                    .HasForeignKey(d => d.JobPostingId)
                    .HasConstraintName("FK_JobApplications_JobPostings");

                entity.HasOne(d => d.Recruiter)
                    .WithMany(p => p.JobApplicationsRecruiter)
                    .HasForeignKey(d => d.RecruiterId)
                    .HasConstraintName("FK_JobApplications_Users");
            });

            modelBuilder.Entity<JobPostings>(entity =>
            {
                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.JobPostings)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_JobPostings_Categories");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.JobPostings)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_JobPostings_SubCategories");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SubCategories>(entity =>
            {
                entity.Property(e => e.IsMain).HasColumnName("isMain");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategories_Categories");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Users_Company");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Users_Countries");

                entity.HasOne(d => d.Disability)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DisabilityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Users_Disabilities");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
