namespace Cuisine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WORKERS
    {
        [Key]
        public int ID_WORKERS { get; set; }

        [Required]
        [StringLength(15)]
        public string NOM_WORKERS { get; set; }

        public int QUANTITE_WORKERS { get; set; }

        public bool? UTILISE_WORKERS { get; set; }
    }
}
