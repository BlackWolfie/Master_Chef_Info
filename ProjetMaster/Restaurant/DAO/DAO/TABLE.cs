namespace Cuisine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TABLE")]
    public partial class TABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABLE()
        {
            GROUPE = new HashSet<GROUPE>();
            SUPPLEMENT = new HashSet<SUPPLEMENT>();
            RECETTE = new HashSet<RECETTE>();
            COUVERTS = new HashSet<COUVERTS>();
        }

        [Key]
        public int ID_TABLE { get; set; }

        public int? ID_GROUPE { get; set; }

        public int TAILLE_TABLE { get; set; }

        public bool OCCUPATION_TABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GROUPE> GROUPE { get; set; }

        public virtual GROUPE GROUPE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLEMENT> SUPPLEMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETTE> RECETTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COUVERTS> COUVERTS { get; set; }
    }
}
