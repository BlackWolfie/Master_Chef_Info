namespace DevChef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUPPLEMENT")]
    public partial class SUPPLEMENT
    {
        [Key]
        public int ID_SUPPLEMENT { get; set; }

        public int? ID_TABLE { get; set; }

        [Required]
        [StringLength(15)]
        public string NOM_SUPPLEMENT { get; set; }

        public int QUANTITE_SUPPLEMENT { get; set; }

        public int? UTILISE_SUPPLEMENT { get; set; }

        public virtual TABLE TABLE { get; set; }
    }
}
