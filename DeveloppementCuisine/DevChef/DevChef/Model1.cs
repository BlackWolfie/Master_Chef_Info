namespace DevChef
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cuisine : DbContext
    {
        public Cuisine()
            : base("name=Connexion")
        {
        }

        public virtual DbSet<CLIENT> CLIENTS { get; set; }
        public virtual DbSet<COUVERT> COUVERTS { get; set; }
        public virtual DbSet<GROUPE> GROUPEs { get; set; }
        public virtual DbSet<INGREDIENT> INGREDIENTS { get; set; }
        public virtual DbSet<RECETTE> RECETTEs { get; set; }
        public virtual DbSet<SUPPLEMENT> SUPPLEMENTs { get; set; }
        public virtual DbSet<TABLE> TABLEs { get; set; }
        public virtual DbSet<USTENSILE> USTENSILES { get; set; }
        public virtual DbSet<WORKER> WORKERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COUVERT>()
                .Property(e => e.NOM_COUVERTS)
                .IsUnicode(false);

            modelBuilder.Entity<COUVERT>()
                .HasMany(e => e.TABLEs)
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
                .HasMany(e => e.TABLEs)
                .WithOptional(e => e.GROUPE)
                .HasForeignKey(e => e.ID_GROUPE);

            modelBuilder.Entity<INGREDIENT>()
                .Property(e => e.NOM_INGREDIENT)
                .IsUnicode(false);

            modelBuilder.Entity<RECETTE>()
                .Property(e => e.NOM_RECETTE)
                .IsUnicode(false);

            modelBuilder.Entity<RECETTE>()
                .HasMany(e => e.TABLEs)
                .WithMany(e => e.RECETTEs)
                .Map(m => m.ToTable("COMMANDER").MapLeftKey("ID_RECETTE").MapRightKey("ID_TABLE"));

            modelBuilder.Entity<RECETTE>()
                .HasMany(e => e.USTENSILES)
                .WithMany(e => e.RECETTEs)
                .Map(m => m.ToTable("ETRE_UTILISER").MapLeftKey("ID_RECETTE").MapRightKey("ID_USTENSILES"));

            modelBuilder.Entity<RECETTE>()
                .HasMany(e => e.INGREDIENTS)
                .WithMany(e => e.RECETTEs)
                .Map(m => m.ToTable("UTILISER").MapLeftKey("ID_RECETTE").MapRightKey("ID_INGREDIENT"));

            modelBuilder.Entity<SUPPLEMENT>()
                .Property(e => e.NOM_SUPPLEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE>()
                .HasMany(e => e.GROUPEs)
                .WithRequired(e => e.TABLE)
                .HasForeignKey(e => e.ID_TABLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USTENSILE>()
                .Property(e => e.NOM_USTENSILES)
                .IsUnicode(false);

            modelBuilder.Entity<WORKER>()
                .Property(e => e.NOM_WORKERS)
                .IsUnicode(false);
        }
    }
}
