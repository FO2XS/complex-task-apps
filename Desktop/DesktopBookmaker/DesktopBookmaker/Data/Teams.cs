namespace DesktopBookmaker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Teams")]
    public partial class Teams
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teams()
        {
            Events = new HashSet<Events>();
            Events1 = new HashSet<Events>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int? Raiting { get; set; }

        public float? PercentWin { get; set; }

        public string SquadList { get; set; }

        public string Logo { get; set; }

        public int IdSport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Events> Events { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Events> Events1 { get; set; }

        public virtual Sports Sports { get; set; }

        public override string ToString()
             => Title;
    }
}
