namespace Cuisine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INGREDIENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INGREDIENTS()
        {
            RECETTE = new HashSet<RECETTE>();
        }

        [Key]
        public int ID_INGREDIENT { get; set; }

        [Required]
        [StringLength(15)]
        public string NOM_INGREDIENT { get; set; }

        public int QUANTITE_INGREDIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETTE> RECETTE { get; set; }
    }
}
