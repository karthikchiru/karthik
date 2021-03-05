using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FileDownload.Models
{
    public partial class logoContext : DbContext
    {
        public logoContext()
        {
        }

        public logoContext(DbContextOptions<logoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authority> Authorities { get; set; }
        public virtual DbSet<DistrictMaster> DistrictMasters { get; set; }
        public virtual DbSet<OTP> OTPs { get; set; }
        public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Userform> Userforms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-V537EHH\\SQLEXPRESS;Database=logo;User Id=kart;Password=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Authority>(entity =>
            {
                entity.ToTable("Authority");

                entity.Property(e => e.Role_Admin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Role_DistrictHead)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Role_StateHead)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Role_User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DistrictMaster>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.ToTable("DistrictMaster");

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.DistrictMasters)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DistrictMaster_StateMaster");
            });

            modelBuilder.Entity<OTP>(entity =>
            {
                entity.ToTable("OTP");

                entity.Property(e => e.Createtime).HasColumnType("datetime");

                entity.Property(e => e.Token).HasMaxLength(50);

                entity.Property(e => e.emailid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.otp1).HasColumnName("otp");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OTPs)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OTP_UserProfile");
            });

            modelBuilder.Entity<PasswordResetToken>(entity =>
            {
                entity.ToTable("PasswordResetToken");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Token).HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.QR_Code)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.UPI_id)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_UserProfile");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.ToTable("RefreshToken");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Expires).HasColumnType("datetime");

                entity.Property(e => e.Token).HasMaxLength(50);

                entity.HasOne(d => d.user)
                    .WithMany(p => p.RefreshTokens)
                    .HasForeignKey(d => d.userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Refresh Token_UserProfile");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Authority)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("RoleMaster");

                entity.Property(e => e.Authority)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StateMaster>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("StateMaster");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK_Appuser");

                entity.ToTable("UserProfile");

                entity.Property(e => e.ConfirmPassword).IsRequired();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.RoleType).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_UserRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_UserProfile");
            });

            modelBuilder.Entity<Userform>(entity =>
            {
                entity.ToTable("Userform");

                entity.Property(e => e.AadharCardNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dateofbirth).HasColumnType("datetime");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MoblieNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PanNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Taluk)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.user)
                    .WithMany(p => p.Userforms)
                    .HasForeignKey(d => d.userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Userform_UserProfile");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
