namespace DevChef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTS")]
    public partial class CLIENT
    {
        [Key]
        public int ID_CLIENT { get; set; }

        public int ID_GROUPE { get; set; }

        public virtual GROUPE GROUPE { get; set; }
    }
}
