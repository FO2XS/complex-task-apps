using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Test.Data.ModalEntity;

#nullable disable

namespace Test
{
    public partial class BookmakerContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public BookmakerContext()
        {
        }

        public BookmakerContext(DbContextOptions<BookmakerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<MoneyManagement> MoneyManagements { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<PossibleBet> PossibleBets { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TypeOfBet> TypeOfBets { get; set; }
        public virtual DbSet<UserBet> UserBets { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=bookmaker-office.postgres.database.azure.com; Database=BookmakerStep2; Port=5432; User Id=Maxim@bookmaker-office; Password=Vladikavkaz1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.StartDate).HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.IdSportNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdSport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_events_sports_idsport");

                entity.HasOne(d => d.IdTournamentNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdTournament)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_events_tournaments_idtournaments");

                entity.HasOne(d => d.IdTeam1Navigation)
                    .WithMany(p => p.EventIdTeam1Navigations)
                    .HasForeignKey(d => d.IdTeam1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_events_teams_idteam1");

                entity.HasOne(d => d.IdTeam2Navigation)
                    .WithMany(p => p.EventIdTeam2Navigations)
                    .HasForeignKey(d => d.IdTeam2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_events_teams_idteam2");
            });

            modelBuilder.Entity<MoneyManagement>(entity =>
            {
                entity.ToTable("MoneyManagement");

                entity.Property(e => e.Date).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Sum).HasColumnType("numeric(12,2)");

                entity.HasOne(d => d.IdOperatorNavigation)
                    .WithMany(p => p.MoneyManagements)
                    .HasForeignKey(d => d.IdOperator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_moneymanagement_operators_idoperator");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.MoneyManagements)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_moneymanagement_users_iduser");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });


            modelBuilder.Entity<PossibleBet>(entity =>
            {
                entity.Property(e => e.Max).HasColumnType("numeric(12,2)");

                entity.Property(e => e.Min).HasColumnType("numeric(12,2)");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.PossibleBets)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_possiblebets_events_idevent");

                entity.HasOne(d => d.IdTobNavigation)
                    .WithMany(p => p.PossibleBets)
                    .HasForeignKey(d => d.IdTob)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_possiblebets_typeofbets_idtob");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<RoleClaim>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.HasOne(d => d.IdSportNavigation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.IdSport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_teams_sports_idsport");
            });

            modelBuilder.Entity<TypeOfBet>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Balance).HasColumnType("numeric(12,2)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name)
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Surname)
                    .HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
                entity.Property(e => e.Avatar).HasColumnName("Avatar");
            });

            modelBuilder.Entity<UserBet>(entity =>
            {
                entity.Property(e => e.Prize).HasColumnType("numeric(12,2)");

                entity.Property(e => e.Sum).HasColumnType("numeric(12,2)");

                entity.Property(e => e.Victory).HasColumnType("bit(2)");

                entity.HasOne(d => d.IdPosBetNavigation)
                    .WithMany(p => p.UserBets)
                    .HasForeignKey(d => d.IdPosBet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_userbets_possiblebets_idposbet");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserBets)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_userbets_users_iduser");
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
