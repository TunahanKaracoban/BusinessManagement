using System;
using Business.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BusinessManagement.Dal.Concrete.Entityframework.Context
{
    public partial class BusinessManagementContext : DbContext
    {
        IConfiguration configuration;
        public BusinessManagementContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //public BusinessManagementContext(DbContextOptions<BusinessManagementContext> options)
        //    : base(options)
        //{
        //}

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));
                //optionsBuilder.UseSqlServer("Server=DESKTOP-K0CTJKB;Database=BusinessManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Message1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Message");

                entity.Property(e => e.MessageReceiverId).HasColumnName("MessageReceiverID");

                entity.Property(e => e.MessageSenderId).HasColumnName("MessageSenderID");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.HasOne(d => d.MessageReceiver)
                    .WithMany(p => p.MessageMessageReceivers)
                    .HasForeignKey(d => d.MessageReceiverId)
                    .HasConstraintName("FK_Messages_Users1");

                entity.HasOne(d => d.MessageSender)
                    .WithMany(p => p.MessageMessageSenders)
                    .HasForeignKey(d => d.MessageSenderId)
                    .HasConstraintName("FK_Messages_Users");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Messages_Jobs");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentSubject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobAssigmentId).HasColumnName("JobAssigmentID");

                entity.Property(e => e.JobEndDate).HasColumnType("date");

                entity.Property(e => e.JobOpenId).HasColumnName("JobOpenID");

                entity.Property(e => e.JobStartDate).HasColumnType("date");

                entity.Property(e => e.RequestHeader)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jobs_Departments");

                entity.HasOne(d => d.JobAssigment)
                    .WithMany(p => p.RequestJobAssigments)
                    .HasForeignKey(d => d.JobAssigmentId)
                    .HasConstraintName("FK_Jobs_Users1");

                entity.HasOne(d => d.JobOpen)
                    .WithMany(p => p.RequestJobOpens)
                    .HasForeignKey(d => d.JobOpenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jobs_Users");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Departments");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
