using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Modal;

namespace DbHendler
{
    public class DbContext
    {
        private NpgsqlConnection Connection { get; }

        public DbContext(NpgsqlConnection connection)
        {
            Connection = connection
                ?? throw new ArgumentNullException(nameof(connection));

            Teams = new DbList<Teams>(connection);
            Events = new DbList<Events>(connection);
        }

        public DbList<Teams> Teams { get; set; }
        public DbList<Events> Events { get; set; }
    }
}
