namespace DesktopBokmeyker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Teams")]
    public partial class Teams
    {
        public Teams()
        {
            Events = new HashSet<Events>();
            Events1 = new HashSet<Events>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int? Raiting { get; set; }

        public float? PercentWin { get; set; }

        public string SquadList { get; set; }

        public string Logo { get; set; }

        public virtual ICollection<Events> Events { get; set; }

        public virtual ICollection<Events> Events1 { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
