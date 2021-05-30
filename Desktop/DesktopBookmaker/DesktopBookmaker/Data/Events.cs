namespace DesktopBookmaker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Events")]
    public partial class Events
        :ICloneable, IComparable
    {
        private Teams teams;
        private Teams teams1;
        private Sports sports;
        private Tournaments tournaments;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Events()
        {
            PossibleBets = new HashSet<PossibleBets>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdSport { get; set; }

        public int IdTeam1 { get; set; }

        public int IdTeam2 { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public Boolean? Winner { get; set; }

        public bool IsPast { get; set; }

        public bool ToArchive { get; set; }

        public bool IsAvailable { get; set; }

        public int? IdTournament { get; set; }

        public virtual Sports Sports
        {
            get => sports;
            set
            {
                sports = value;
                IdSport = sports is null ? 0 : sports.Id;
            }
        }

        public virtual Teams Teams
        {
            get => teams;
            set
            {
                teams = value;
                IdTeam1 = teams is null ? 0 : teams.Id;
            }
        }

        public virtual Teams Teams1
        {
            get => teams1;
            set
            {
                teams1 = value;
                IdTeam2 = teams1 is null ? 0 : teams1.Id;
            }
        }

        public virtual Tournaments Tournaments
        {
            get => tournaments;
            set
            {
                tournaments = value;
                IdTournament = tournaments is null ? 0 : tournaments.Id;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PossibleBets> PossibleBets { get; set; }

        public object Clone()
        {
            return new Events()
            {
                Id = Id,
                IdSport = IdSport,
                IdTeam1 = IdTeam1,
                IdTeam2 = IdTeam2,
                Winner = Winner,
                IsPast = IsPast,
                ToArchive = ToArchive,
                StartDate = StartDate,
                Teams = Teams,
                Teams1 = Teams1,
                Tournaments = Tournaments,
                IsAvailable = IsAvailable,
                Sports = Sports,
            };
        }

        public int CompareTo(object obj)
        {
            return Id.CompareTo(((Events)obj).Id);
        }
    }
}
