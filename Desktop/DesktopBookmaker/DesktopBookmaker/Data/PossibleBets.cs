namespace DesktopBookmaker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.PossibleBets")]
    public partial class PossibleBets
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdEvent { get; set; }

        public int IdTob { get; set; }

        public float Coef1 { get; set; }

        public float Coef2 { get; set; }

        public decimal Min { get; set; }

        public decimal Max { get; set; }

        public bool IsAvalaible { get; set; }

        public float? Margin { get; set; }

        public bool IsPast { get; set; }

        public bool ToArchive { get; set; }

        public bool? Winner { get; set; }

        public virtual Events Events { get; set; }

        public virtual TypeOfBets TypeOfBets { get; set; }

        public virtual ICollection<UserBets> UserBets { get; set; }

        public PossibleBets()
        {
            UserBets = new HashSet<UserBets>();
        }
    }
}
