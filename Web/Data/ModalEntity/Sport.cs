using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Data.ModalEntity
{
    public partial class Sport
    {
        public Sport()
        {
            Events = new HashSet<Event>();
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
