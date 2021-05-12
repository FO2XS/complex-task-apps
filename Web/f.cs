using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.ModalEntity;

namespace Test
{

    public static class f
    {
        public static ICollection<Event> GetEvetsCollection(this ICollection<Event> collection, Func<Event, bool> wFunc)
        {
            return collection.Where(wFunc).ToList();
        }
    }
}
