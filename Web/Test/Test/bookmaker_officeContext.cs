using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Test
{
    public partial class bookmaker_officeContext : DbContext
    {
        public bookmaker_officeContext()
        {
        }

        public bookmaker_officeContext(DbContextOptions<bookmaker_officeContext> options)
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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersBet> UsersBets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bookmaker_office;Username=postgres;Password=admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("events");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdLose).HasColumnName("id_lose");

                entity.Property(e => e.IdSport).HasColumnName("id_sport");

                entity.Property(e => e.IdTeam1).HasColumnName("id_team1");

                entity.Property(e => e.IdTeam2).HasColumnName("id_team2");

                entity.Property(e => e.IdWin).HasColumnName("id_win");

                entity.Property(e => e.IsPast).HasColumnName("is_past");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.ToArchive).HasColumnName("to_archive");

                entity.HasOne(d => d.IdSportNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.IdSport)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sport_fkey");

                entity.HasOne(d => d.IdTeam1Navigation)
                    .WithMany(p => p.EventIdTeam1Navigations)
                    .HasForeignKey(d => d.IdTeam1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("team1_fkey");

                entity.HasOne(d => d.IdTeam2Navigation)
                    .WithMany(p => p.EventIdTeam2Navigations)
                    .HasForeignKey(d => d.IdTeam2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("team2_fkey");
            });

            modelBuilder.Entity<MoneyManagement>(entity =>
            {
                entity.ToTable("money_management");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.IdOper).HasColumnName("id_oper");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Sum)
                    .HasColumnType("money")
                    .HasColumnName("sum");

                entity.Property(e => e.TakeOrAdd).HasColumnName("take_or_add");

                entity.HasOne(d => d.IdOperNavigation)
                    .WithMany(p => p.MoneyManagements)
                    .HasForeignKey(d => d.IdOper)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("oper_fkey");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.MoneyManagements)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_fkey");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.ToTable("operators");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<PossibleBet>(entity =>
            {
                entity.ToTable("possible_bets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Coef1).HasColumnName("coef1");

                entity.Property(e => e.Coef2).HasColumnName("coef2");

                entity.Property(e => e.IdEvent).HasColumnName("id_event");

                entity.Property(e => e.IdTob).HasColumnName("id_tob");

                entity.Property(e => e.IsAvailable).HasColumnName("is_available");

                entity.Property(e => e.IsPast).HasColumnName("is_past");

                entity.Property(e => e.Margin).HasColumnName("margin");

                entity.Property(e => e.Max)
                    .HasColumnType("money")
                    .HasColumnName("max");

                entity.Property(e => e.Min)
                    .HasColumnType("money")
                    .HasColumnName("min");

                entity.Property(e => e.ToArchive).HasColumnName("to_archive");

                entity.Property(e => e.Winner).HasColumnName("winner");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.PossibleBets)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("event_fkey");

                entity.HasOne(d => d.IdTobNavigation)
                    .WithMany(p => p.PossibleBets)
                    .HasForeignKey(d => d.IdTob)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tob_fkey");
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.ToTable("sports");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("teams");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.PercentWin).HasColumnName("percent_win");

                entity.Property(e => e.Raiting).HasColumnName("raiting");

                entity.Property(e => e.Squadlist).HasColumnName("squadlist");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TypeOfBet>(entity =>
            {
                entity.ToTable("type_of_bets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Balance)
                    .HasColumnType("money")
                    .HasColumnName("balance");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .HasColumnName("nickname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<UsersBet>(entity =>
            {
                entity.ToTable("users_bet");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Coef).HasColumnName("coef");

                entity.Property(e => e.IdPosBet).HasColumnName("id_pos_bet");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Prize)
                    .HasColumnType("money")
                    .HasColumnName("prize");

                entity.Property(e => e.Sum)
                    .HasColumnType("money")
                    .HasColumnName("sum");

                entity.Property(e => e.ToArchive).HasColumnName("to_archive");

                entity.Property(e => e.Victory)
                    .HasColumnType("bit(2)")
                    .HasColumnName("victory");

                entity.HasOne(d => d.IdPosBetNavigation)
                    .WithMany(p => p.UsersBets)
                    .HasForeignKey(d => d.IdPosBet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("posbet_fkey");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UsersBets)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
