namespace DevChef
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
            GROUPEs = new HashSet<GROUPE>();
            SUPPLEMENTs = new HashSet<SUPPLEMENT>();
            RECETTEs = new HashSet<RECETTE>();
            COUVERTS = new HashSet<COUVERT>();
        }

        [Key]
        public int ID_TABLE { get; set; }

        public int? ID_GROUPE { get; set; }

        public int TAILLE_TABLE { get; set; }

        public bool OCCUPATION_TABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GROUPE> GROUPEs { get; set; }

        public virtual GROUPE GROUPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLEMENT> SUPPLEMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECETTE> RECETTEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COUVERT> COUVERTS { get; set; }
    }
}
