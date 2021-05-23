using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Data.ModalEntity
{
    public partial class Tournament
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
