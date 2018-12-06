namespace DevChef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RECETTE")]
    public partial class RECETTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECETTE()
        {
            TABLEs = new HashSet<TABLE>();
            USTENSILES = new HashSet<USTENSILE>();
            INGREDIENTS = new HashSet<INGREDIENT>();
        }

        [Key]
        public int ID_RECETTE { get; set; }

        [StringLength(15)]
        public string NOM_RECETTE { get; set; }

        public int? TEMPS_RECETTE { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLE> TABLEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USTENSILE> USTENSILES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGREDIENT> INGREDIENTS { get; set; }
    }
}
