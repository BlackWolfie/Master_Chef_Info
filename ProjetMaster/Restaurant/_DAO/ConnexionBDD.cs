namespace Cuisine
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConnexionBDD : DbContext
    {
        public ConnexionBDD()
            : base("name=ConnexionBDD")
        {
        }

        public virtual DbSet<CLIENTS> CLIENTS { get; set; }
        public virtual DbSet<COUVERTS> COUVERTS { get; set; }
        public virtual DbSet<GROUPE> GROUPE { get; set; }
        public virtual DbSet<INGREDIENTS> INGREDIENTS { get; set; }
        public virtual DbSet<RECETTE> RECETTE { get; set; }
        public virtual DbSet<SUPPLEMENT> SUPPLEMENT { get; set; }
        public virtual DbSet<TABLE> TABLE { get; set; }
        public virtual DbSet<USTENSILES> USTENSILES { get; set; }
        public virtual DbSet<WORKERS> WORKERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COUVERTS>()
                .Property(e => e.NOM_COUVERTS)
                .IsUnicode(false);

            modelBuilder.Entity<COUVERTS>()
                .HasMany(e => e.TABLE)
                .WithMany(e => e.COUVERTS)
                .Map(m => m.ToTable("DISPOSER").MapLeftKey("ID_COUVERTS").MapRightKey("ID_TABLE"));

            modelBuilder.Entity<GROUPE>()
                .Property(e => e.TYPE_GROUPE)
                .IsUnicode(false);

            modelBuilder.Entity<GROUPE>()
                .HasMany(e => e.CLIENTS)
                .WithRequired(e => e.GROUPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GROUPE>()
                .HasMany(e => e.TABLE1)
                .WithOptional(e => e.GROUPE1)
                .HasForeignKey(e => e.ID_GROUPE);

            modelBuilder.Entity<INGREDIENTS>()
                .Property(e => e.NOM_INGREDIENT)
                .IsUnicode(false);

            modelBuilder.Entity<RECETTE>()
                .Property(e => e.NOM_RECETTE)
                .IsUnicode(false);

            modelBuilder.Entity<RECETTE>()
                .HasMany(e => e.TABLE)
                .WithMany(e => e.RECETTE)
                .Map(m => m.ToTable("COMMANDER").MapLeftKey("ID_RECETTE").MapRightKey("ID_TABLE"));

            modelBuilder.Entity<RECETTE>()
                .HasMany(e => e.USTENSILES)
                .WithMany(e => e.RECETTE)
                .Map(m => m.ToTable("ETRE_UTILISER").MapLeftKey("ID_RECETTE").MapRightKey("ID_USTENSILES"));

            modelBuilder.Entity<RECETTE>()
                .HasMany(e => e.INGREDIENTS)
                .WithMany(e => e.RECETTE)
                .Map(m => m.ToTable("UTILISER").MapLeftKey("ID_RECETTE").MapRightKey("ID_INGREDIENT"));

            modelBuilder.Entity<SUPPLEMENT>()
                .Property(e => e.NOM_SUPPLEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE>()
                .HasMany(e => e.GROUPE)
                .WithRequired(e => e.TABLE)
                .HasForeignKey(e => e.ID_TABLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USTENSILES>()
                .Property(e => e.NOM_USTENSILES)
                .IsUnicode(false);

            modelBuilder.Entity<WORKERS>()
                .Property(e => e.NOM_WORKERS)
                .IsUnicode(false);
        }
    }
}
