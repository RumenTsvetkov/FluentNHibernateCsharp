using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db
{    
    public sealed class RepositoryGenteFisica : WAppFluentNhibernate.Db.Abstract.Repository<WAppFluentNhibernate.Db.Poco.GenteFisica>
    {
        public RepositoryGenteFisica() : base() { }
        public RepositoryGenteFisica(Interface.IConnection Connection)
            : base(Connection)
        {
        }
    }
}
