namespace DesktopBookmaker.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System;

    [Table("public.PossibleBets")]
    public partial class PossibleBets
        : ICloneable, IComparable
    {
        private Events events;
        private TypeOfBets typeOfBets;
        private float coef1;
        private float coef2;
        private decimal min;
        private decimal max;

        public virtual TypeOfBets TypeOfBets
        {
            get => typeOfBets;
            set
            {
                typeOfBets = value;
                if (!(events is null))
                    IdTob = typeOfBets.Id;
            }
        }

        public virtual Events Events
        {
            get => events;
            set
            {
                events = value;
                if (!(events is null))
                    IdEvent = events.Id;
            }
        }

        public int Id { get; set; }

        public int IdEvent { get; set; }

        public int IdTob { get; set; }

        public float Coef1
        {
            get => coef1;
            set
            {
                coef1 = value;
                Coef.Coef1 = coef1;
            }
        }

        public float Coef2
        {
            get => coef2;
            set
            {
                coef2 = value;
                Coef.Coef2 = coef2;
            }
        }

        public decimal Min 
        { 
            get => min;
            set
            {
                min = value;
                MaxMin.Min = value;
            }
        }

        public decimal Max 
        { 
            get => max;
            set 
            {
                max = value;
                MaxMin.Max = value;
            }
        }

        public bool IsAvalaible { get; set; }

        public float? Margin { get; set; }

        public bool IsPast { get; set; }

        public bool ToArchive { get; set; }

        public bool? Winner { get; set; }

        [NotMapped]
        public Teams WinnerTeam
        {
            get
            {
                if (Winner is null)
                    return null;
                else if (Winner.Value)
                    return Events.Teams;
                else
                    return Events.Teams1;
            }
            set
            {
                if (value is null)
                    Winner = null;
                else if (value.Id == Events.Teams.Id)
                    Winner = true;
                else
                    Winner = false;
            }
        }

        [NotMapped]
        public Coef Coef { get; set; }

        [NotMapped]
        public MaxMin MaxMin { get; set; }

        public ICollection<UserBets> UserBets { get; set; }

        public PossibleBets()
        {
            UserBets = new HashSet<UserBets>();
            Coef = new Coef();
            MaxMin = new MaxMin();
        }

        public int CompareTo(object obj)
        {
            return Id.CompareTo(((PossibleBets)obj).Id);
        }

        public object Clone()
        {
            return new PossibleBets()
            {
                Id = Id,
                IdTob = IdTob,
                IdEvent = IdEvent,
                Min = Min,
                Max = Max,
                Margin = Margin,
                Coef1 = Coef1,
                Coef2 = Coef2,
                IsAvalaible = IsAvalaible,
                IsPast = IsPast,
                ToArchive = ToArchive,
                Winner = Winner,
                UserBets = UserBets,
                Events = Events,
                TypeOfBets = TypeOfBets,
            };
        }
    }

    public class Coef
    {
        public float Coef1 { get; set; }

        public float Coef2 { get; set; }

        public override string ToString()
        {
            return $"{Coef1}\n{Coef2}";
        }
    }

    public class MaxMin
    {
        public decimal Min { get; set; }

        public decimal Max { get; set; }

        public override string ToString()
        {
            return $"{Min}\n{Max}";
        }
    }
}
