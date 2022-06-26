using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AoDPedia_Site
{
    public partial class AoDPediaContext : DbContext
    {
        public AoDPediaContext()
        {
        }

        public AoDPediaContext(DbContextOptions<AoDPediaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TArmy> TArmies { get; set; }
        public virtual DbSet<TArmyUnit> TArmyUnits { get; set; }
        public virtual DbSet<TModel> TModels { get; set; }
        public virtual DbSet<TModelModelType> TModelModelTypes { get; set; }
        public virtual DbSet<TModelSpecialRule> TModelSpecialRules { get; set; }
        public virtual DbSet<TModelType> TModelTypes { get; set; }
        public virtual DbSet<TModelWargear> TModelWargears { get; set; }
        public virtual DbSet<TModelWeapon> TModelWeapons { get; set; }
        public virtual DbSet<TRiteOfWar> TRiteOfWars { get; set; }
        public virtual DbSet<TRule> TRules { get; set; }
        public virtual DbSet<TRuleCategory> TRuleCategories { get; set; }
        public virtual DbSet<TSource> TSources { get; set; }
        public virtual DbSet<TSpecialRule> TSpecialRules { get; set; }
        public virtual DbSet<TUnit> TUnits { get; set; }
        public virtual DbSet<TUnitCompositionModel> TUnitCompositionModels { get; set; }
        public virtual DbSet<TUnitCompositionWargear> TUnitCompositionWargears { get; set; }
        public virtual DbSet<TUnitCompositionWeapon> TUnitCompositionWeapons { get; set; }
        public virtual DbSet<TUnitOptionModel> TUnitOptionModels { get; set; }
        public virtual DbSet<TUnitOptionWargear> TUnitOptionWargears { get; set; }
        public virtual DbSet<TUnitOptionWeapon> TUnitOptionWeapons { get; set; }
        public virtual DbSet<TWargear> TWargears { get; set; }
        public virtual DbSet<TWarlordTrait> TWarlordTraits { get; set; }
        public virtual DbSet<TWeapon> TWeapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=AoDPedia");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TArmy>(entity =>
            {
                entity.ToTable("T_Army");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TArmyUnit>(entity =>
            {
                entity.ToTable("T_Army_Unit");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArmyId).HasColumnName("Army_Id");

                entity.Property(e => e.UnitId).HasColumnName("Unit_Id");
            });

            modelBuilder.Entity<TModel>(entity =>
            {
                entity.ToTable("T_Model");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Attacks)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AvFront)
                    .HasMaxLength(10)
                    .HasColumnName("AV_Front")
                    .IsFixedLength(true);

                entity.Property(e => e.AvRear)
                    .HasMaxLength(10)
                    .HasColumnName("AV_Rear")
                    .IsFixedLength(true);

                entity.Property(e => e.AvSide)
                    .HasMaxLength(10)
                    .HasColumnName("AV_Side")
                    .IsFixedLength(true);

                entity.Property(e => e.BallisticSkill)
                    .HasMaxLength(10)
                    .HasColumnName("Ballistic_Skill")
                    .IsFixedLength(true);

                entity.Property(e => e.HullPoints).HasColumnType("ntext");

                entity.Property(e => e.Initiative)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Leadership)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Movement)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Save)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SourcePage).HasColumnName("Source_Page");

                entity.Property(e => e.Strength)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Toughness)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.WeaponSkill)
                    .HasMaxLength(10)
                    .HasColumnName("Weapon_Skill")
                    .IsFixedLength(true);

                entity.Property(e => e.Wounds).HasColumnType("ntext");
            });

            modelBuilder.Entity<TModelModelType>(entity =>
            {
                entity.ToTable("T_Model_Model_Types");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelId).HasColumnName("Model_Id");

                entity.Property(e => e.ModelTypeId).HasColumnName("Model_Type_Id");
            });

            modelBuilder.Entity<TModelSpecialRule>(entity =>
            {
                entity.ToTable("T_Model_Special_Rules");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelId).HasColumnName("Model_Id");

                entity.Property(e => e.SpecialRuleId).HasColumnName("Special_Rule_Id");
            });

            modelBuilder.Entity<TModelType>(entity =>
            {
                entity.ToTable("T_Model_Types");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");
            });

            modelBuilder.Entity<TModelWargear>(entity =>
            {
                entity.ToTable("T_Model_Wargear");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelId).HasColumnName("Model_Id");

                entity.Property(e => e.WargearId).HasColumnName("Wargear_Id");
            });

            modelBuilder.Entity<TModelWeapon>(entity =>
            {
                entity.ToTable("T_Model_Weapons");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelId).HasColumnName("Model_Id");

                entity.Property(e => e.WeaponId).HasColumnName("Weapon_Id");
            });

            modelBuilder.Entity<TRiteOfWar>(entity =>
            {
                entity.ToTable("T_Rite_Of_War");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArmyId).HasColumnName("Army_Id");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TRule>(entity =>
            {
                entity.ToTable("T_Rules");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("Parent_Id");

                entity.Property(e => e.RuleType).HasColumnName("Rule_Type");

                entity.Property(e => e.SourceId).HasColumnName("Source_Id");

                entity.Property(e => e.SourcePage).HasColumnName("Source_Page");
            });

            modelBuilder.Entity<TRuleCategory>(entity =>
            {
                entity.ToTable("T_Rule_Category");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("Parent_Id");
            });

            modelBuilder.Entity<TSource>(entity =>
            {
                entity.ToTable("T_Source");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TSpecialRule>(entity =>
            {
                entity.ToTable("T_Special_Rules");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Fluff).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Rules).IsUnicode(false);
            });

            modelBuilder.Entity<TUnit>(entity =>
            {
                entity.ToTable("T_Unit");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Role).HasMaxLength(25);

                entity.Property(e => e.SourcePage).HasColumnName("Source_Page");
            });

            modelBuilder.Entity<TUnitCompositionModel>(entity =>
            {
                entity.ToTable("T_Unit_Composition_Models");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelId).HasColumnName("Model_Id");

                entity.Property(e => e.UnitId).HasColumnName("Unit_Id");
            });

            modelBuilder.Entity<TUnitCompositionWargear>(entity =>
            {
                entity.ToTable("T_Unit_Composition_Wargear");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UnitId).HasColumnName("Unit_Id");

                entity.Property(e => e.WargearId).HasColumnName("Wargear_Id");
            });

            modelBuilder.Entity<TUnitCompositionWeapon>(entity =>
            {
                entity.ToTable("T_Unit_Composition_Weapon");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.UnitId).HasColumnName("Unit_Id");

                entity.Property(e => e.WeaponId).HasColumnName("Weapon_Id");
            });

            modelBuilder.Entity<TUnitOptionModel>(entity =>
            {
                entity.ToTable("T_Unit_Option_Model");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelId).HasColumnName("Model_Id");
            });

            modelBuilder.Entity<TUnitOptionWargear>(entity =>
            {
                entity.ToTable("T_Unit_Option_Wargear");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelsPerWargear).HasColumnName("Models_Per_Wargear");

                entity.Property(e => e.UnitId).HasColumnName("Unit_Id");

                entity.Property(e => e.WargearId).HasColumnName("Wargear_Id");
            });

            modelBuilder.Entity<TUnitOptionWeapon>(entity =>
            {
                entity.ToTable("T_Unit_Option_Weapon");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModelsPerWeapon).HasColumnName("Models_Per_Weapon");

                entity.Property(e => e.UnitId).HasColumnName("Unit_Id");

                entity.Property(e => e.WeaponId).HasColumnName("Weapon_Id");
            });

            modelBuilder.Entity<TWargear>(entity =>
            {
                entity.ToTable("T_Wargear");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TWarlordTrait>(entity =>
            {
                entity.ToTable("T_Warlord_Traits");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArmyId).HasColumnName("Army_Id");
            });

            modelBuilder.Entity<TWeapon>(entity =>
            {
                entity.ToTable("T_Weapon");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ap)
                    .HasMaxLength(10)
                    .HasColumnName("AP")
                    .IsFixedLength(true);

                entity.Property(e => e.ArmyId).HasColumnName("Army_Id");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Range)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SourceId).HasColumnName("Source_Id");

                entity.Property(e => e.SourcePage).HasColumnName("Source_Page");

                entity.Property(e => e.Strength)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
