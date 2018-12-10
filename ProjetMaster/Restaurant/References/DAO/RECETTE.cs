namespace Cuisine
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
            TABLE = new HashSet<TABLE>();
            USTENSILES = new HashSet<USTENSILES>();
            INGREDIENTS = new HashSet<INGREDIENTS>();
        }

        [Key]
        public int ID_RECETTE { get; set; }

        [StringLength(15)]
        public string NOM_RECETTE { get; set; }

        public int? TEMPS_RECETTE { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLE> TABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USTENSILES> USTENSILES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGREDIENTS> INGREDIENTS { get; set; }
    }
}
