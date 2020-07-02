using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MockHollywoodBets.CustomModels;

namespace MockHollywoodBets.Models
{
    public partial class MockHollywoodBetsContext : DbContext
    {
        public MockHollywoodBetsContext()
        {
        }

        public MockHollywoodBetsContext(DbContextOptions<MockHollywoodBetsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bettype> Bettype { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketBettype> MarketBettype { get; set; }
        public virtual DbSet<Odds> Odds { get; set; }
        public virtual DbSet<SportCountry> SportCountry { get; set; }
        public virtual DbSet<SportTree> SportTree { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }
        public virtual DbSet<TournamentBettype> TournamentBettype { get; set; }
        public virtual DbSet<TournamentSc> TournamentSc { get; set; }
        public virtual DbSet<MarketOdd> MarketOdd { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//           To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-AER3FMQ\\SQLEXPRESS01;Database=MockHollywoodBets;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bettype>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Logo).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.TournamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Tournament");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<MarketBettype>(entity =>
            {
                entity.HasOne(d => d.Bettype)
                    .WithMany(p => p.MarketBettype)
                    .HasForeignKey(d => d.BettypeId)
                    .HasConstraintName("FK_MarketBettype_Bettype");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.MarketBettype)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_MarketBettype_Market");
            });

            modelBuilder.Entity<Odds>(entity =>
            {
                entity.Property(e => e.Odds1)
                    .HasColumnName("Odds")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Odds)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_Odds_Event");

                entity.HasOne(d => d.MarketBettype)
                    .WithMany(p => p.Odds)
                    .HasForeignKey(d => d.MarketBettypeId)
                    .HasConstraintName("FK_Odds_MarketBettype");
            });

            modelBuilder.Entity<SportCountry>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SportCountry)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_SportCountry_Country");

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.SportCountry)
                    .HasForeignKey(d => d.SportId)
                    .HasConstraintName("FK_SportCountry_SportTree");
            });

            modelBuilder.Entity<SportTree>(entity =>
            {
                entity.Property(e => e.Logo).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TournamentBettype>(entity =>
            {
                entity.HasOne(d => d.Bettype)
                    .WithMany(p => p.TournamentBettype)
                    .HasForeignKey(d => d.BettypeId)
                    .HasConstraintName("FK_TournamentBettype_Bettype");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.TournamentBettype)
                    .HasForeignKey(d => d.TournamentId)
                    .HasConstraintName("FK_TournamentBettype_Tournament");
            });

            modelBuilder.Entity<TournamentSc>(entity =>
            {
                entity.ToTable("TournamentSC");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TournamentSc)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_TournamentSC_Country");

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.TournamentSc)
                    .HasForeignKey(d => d.SportId)
                    .HasConstraintName("FK_TournamentSC_SportTree");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.TournamentSc)
                    .HasForeignKey(d => d.TournamentId)
                    .HasConstraintName("FK_TournamentSC_Tournament");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
