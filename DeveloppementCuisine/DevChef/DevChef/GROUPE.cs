namespace DevChef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GROUPE")]
    public partial class GROUPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GROUPE()
        {
            CLIENTS = new HashSet<CLIENT>();
            TABLEs = new HashSet<TABLE>();
        }

        [Key]
        public int ID_GROUPE { get; set; }

        public int ID_TABLE { get; set; }

        [Required]
        [StringLength(15)]
        public string TYPE_GROUPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT> CLIENTS { get; set; }

        public virtual TABLE TABLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLE> TABLEs { get; set; }
    }
}
