namespace Cuisine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COUVERTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COUVERTS()
        {
            TABLE = new HashSet<TABLE>();
        }

        [Key]
        public int ID_COUVERTS { get; set; }

        [Required]
        [StringLength(15)]
        public string NOM_COUVERTS { get; set; }

        public int NOMBRE_COUVERTS { get; set; }

        public int? UTILISE_COUVERTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLE> TABLE { get; set; }
    }
}
