using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Impact.Models
{
    public partial class Game_ImpactContext : DbContext
    {
        public Game_ImpactContext()
        {
        }

        public Game_ImpactContext(DbContextOptions<Game_ImpactContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbilityType> AbilityType { get; set; }
        public virtual DbSet<Loot> Loot { get; set; }
        public virtual DbSet<NodeLocations> NodeLocations { get; set; }
        public virtual DbSet<PlayersAbilities> PlayersAbilities { get; set; }
        public virtual DbSet<UserAccounts> UserAccounts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WorldRequirements> WorldRequirements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-4I7HLHH\\SQLEXPRESS;Database=Game_Impact;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbilityType>(entity =>
            {
                entity.ToTable("ABILITY_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LvlRequirement).HasColumnName("LVL_REQUIREMENT");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.WorldReqKey).HasColumnName("WORLD_REQ_KEY");

                entity.HasOne(d => d.WorldReqKeyNavigation)
                    .WithMany(p => p.AbilityType)
                    .HasForeignKey(d => d.WorldReqKey)
                    .HasConstraintName("FK__ABILITY_T__WORLD__02084FDA");
            });

            modelBuilder.Entity<Loot>(entity =>
            {
                entity.ToTable("LOOT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseDamage)
                    .HasColumnName("BASE_DAMAGE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BasePrice)
                    .HasColumnName("BASE_PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BaseWeight)
                    .HasColumnName("BASE_WEIGHT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.WorldReqKey).HasColumnName("WORLD_REQ_KEY");

                entity.HasOne(d => d.WorldReqKeyNavigation)
                    .WithMany(p => p.Loot)
                    .HasForeignKey(d => d.WorldReqKey)
                    .HasConstraintName("FK__LOOT__WORLD_REQ___04E4BC85");
            });

            modelBuilder.Entity<NodeLocations>(entity =>
            {
                entity.ToTable("NODE_LOCATIONS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.X)
                    .HasColumnName("x")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Y)
                    .HasColumnName("y")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Z)
                    .HasColumnName("z")
                    .HasColumnType("decimal(8, 4)");
            });

            modelBuilder.Entity<PlayersAbilities>(entity =>
            {
                entity.ToTable("PLAYERS_ABILITIES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbilityId).HasColumnName("ABILITY_ID");

                entity.Property(e => e.PlayerAbilityLevel)
                    .HasColumnName("PLAYER_ABILITY_LEVEL")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlayerId).HasColumnName("PLAYER_ID");

                entity.HasOne(d => d.Ability)
                    .WithMany(p => p.PlayersAbilities)
                    .HasForeignKey(d => d.AbilityId)
                    .HasConstraintName("FK__PLAYERS_A__ABILI__0C85DE4D");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayersAbilities)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK__PLAYERS_A__PLAYE__0B91BA14");
            });

            modelBuilder.Entity<UserAccounts>(entity =>
            {
                entity.ToTable("USER_ACCOUNTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Credits).HasColumnName("CREDITS");

                entity.Property(e => e.LocKey).HasColumnName("LOC_KEY");

                entity.Property(e => e.LootTableId).HasColumnName("LOOT_TABLE_ID");

                entity.Property(e => e.Ptwgold).HasColumnName("PTWGOLD");

                entity.Property(e => e.UserKey).HasColumnName("USER_KEY");

                entity.HasOne(d => d.LocKeyNavigation)
                    .WithMany(p => p.UserAccounts)
                    .HasForeignKey(d => d.LocKey)
                    .HasConstraintName("FK__USER_ACCO__LOC_K__07C12930");

                entity.HasOne(d => d.UserKeyNavigation)
                    .WithMany(p => p.UserAccounts)
                    .HasForeignKey(d => d.UserKey)
                    .HasConstraintName("FK__USER_ACCO__USER___08B54D69");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasColumnName("FNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.Lname)
                    .HasColumnName("LNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<WorldRequirements>(entity =>
            {
                entity.ToTable("WORLD_REQUIREMENTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DarkMinLvl).HasColumnName("DARK_MIN_LVL");

                entity.Property(e => e.DexMinLvl).HasColumnName("DEX_MIN_LVL");

                entity.Property(e => e.EarthMinLvl).HasColumnName("EARTH_MIN_LVL");

                entity.Property(e => e.FireMinLvl).HasColumnName("FIRE_MIN_LVL");

                entity.Property(e => e.IntMinLvl).HasColumnName("INT_MIN_LVL");

                entity.Property(e => e.LightMinLvl).HasColumnName("LIGHT_MIN_LVL");

                entity.Property(e => e.StrMinLvl).HasColumnName("STR_MIN_LVL");

                entity.Property(e => e.WaterMinLvl).HasColumnName("WATER_MIN_LVL");

                entity.Property(e => e.WindMinLvl).HasColumnName("WIND_MIN_LVL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
