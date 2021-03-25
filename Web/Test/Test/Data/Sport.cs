using System;
using System.Collections.Generic;

#nullable disable

namespace Test
{
    public partial class Sport
    {
        public Sport()
        {
            Events = new HashSet<Event>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
