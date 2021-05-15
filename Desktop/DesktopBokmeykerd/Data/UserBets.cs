namespace DesktopBokmeyker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.UserBets")]
    public partial class UserBets
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdPosBet { get; set; }

        public float Coef { get; set; }

        public decimal Sum { get; set; }

        public decimal? Prize { get; set; }

        public bool? ToArchive { get; set; }

        public virtual PossibleBets PossibleBets { get; set; }

        public virtual Users Users { get; set; }
    }
}
