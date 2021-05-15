namespace DesktopBokmeyker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Events")]
    public partial class Events
    {
        private Teams teams;
        private Teams teams1;
        private Sports sports;

        public Events()
        {
            PossibleBets = new HashSet<PossibleBets>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdSport { get; set; }

        public int IdTeam1 { get; set; }

        public int IdTeam2 { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public int? IdWin { get; set; }

        public int? IdLose { get; set; }

        public bool? IsPast { get; set; }

        public bool? ToArchive { get; set; }

        public virtual Sports Sports
        {
            get => sports;
            set
            {
                sports = value;
                if (!(value is null))
                    IdSport = value.Id;
            }
        }

        public virtual Teams Teams
        {
            get => teams;
            set
            {
                teams = value;
                if (!(value is null))
                    IdTeam1 = value.Id;
            }
        }

        public virtual Teams Teams1
        {
            get => teams1;
            set
            {
                teams1 = value;
                if (!(value is null))
                    IdTeam2 = value.Id;
            }
        }

        public virtual ICollection<PossibleBets> PossibleBets { get; set; }
    }
}
