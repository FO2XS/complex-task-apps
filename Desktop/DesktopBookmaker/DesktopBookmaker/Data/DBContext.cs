using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DesktopBookmaker.Data
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<MoneyManagement> MoneyManagement { get; set; }
        public virtual DbSet<Operators> Operators { get; set; }
        public virtual DbSet<PossibleBets> PossibleBets { get; set; }
        public virtual DbSet<RoleClaims> RoleClaims { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Sports> Sports { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<Tournaments> Tournaments { get; set; }
        public virtual DbSet<TypeOfBets> TypeOfBets { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserBets> UserBets { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBets>()
                .Property(e => e.Sum)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PossibleBets>()
                .HasMany(e => e.UserBets)
                .WithRequired(e => e.PossibleBets)
                .HasForeignKey(e => e.IdPosBet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserBets>()
                .Property(e => e.Prize)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Events>()
                .HasMany(e => e.PossibleBets)
                .WithRequired(e => e.Events)
                .HasForeignKey(e => e.IdEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MoneyManagement>()
                .Property(e => e.Sum)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Operators>()
                .HasMany(e => e.MoneyManagement)
                .WithRequired(e => e.Operators)
                .HasForeignKey(e => e.IdOperator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PossibleBets>()
                .Property(e => e.Min)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PossibleBets>()
                .Property(e => e.Max)
                .HasPrecision(12, 2);

            modelBuilder.Entity<PossibleBets>()
                .HasMany(e => e.UserBets)
                .WithRequired(e => e.PossibleBets)
                .HasForeignKey(e => e.IdPosBet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.RoleClaims)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<Sports>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Sports)
                .HasForeignKey(e => e.IdSport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sports>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.Sports)
                .HasForeignKey(e => e.IdSport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teams>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Teams)
                .HasForeignKey(e => e.IdTeam1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teams>()
                .HasMany(e => e.Events1)
                .WithRequired(e => e.Teams1)
                .HasForeignKey(e => e.IdTeam2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tournaments>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.Tournaments)
                .HasForeignKey(e => e.IdTournament);

            modelBuilder.Entity<TypeOfBets>()
                .HasMany(e => e.PossibleBets)
                .WithRequired(e => e.TypeOfBets)
                .HasForeignKey(e => e.IdTob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Balance)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.MoneyManagement)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.IdUser)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Users>()
                .HasMany(e => e.UserBets)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.IdUser)
                .WillCascadeOnDelete(false);
        }

        internal IQueryable<Teams> GetEventsBySports(Int32 IdSports)
        {
            return Teams.Include(x => x.Sports).Where(x => x.IdSport == IdSports);
        }
    }
}
