namespace DevChef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USTENSILES")]
    public partial class USTENSILE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USTENSILE()
        {
            RECETTEs = new HashSet<RECETTE>();
        }

        [Key]
        public int ID_USTENSILES { get; set; }

        [Required]
        [StringLength(15)]
        public string NOM_USTENSILES { get; set; }

        public int NOMBRE_USTENSILES { get; set; }

        public int? UTILISE_USTENSILE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETTE> RECETTEs { get; set; }
    }
}
