using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db
{
    public sealed class RepositoryCliente : WAppFluentNhibernate.Db.Abstract.Repository<WAppFluentNhibernate.Db.Poco.Cliente>
    {
        public RepositoryCliente() : base() { }
        public RepositoryCliente(Interface.IConnection Connection)
            : base(Connection)
        {
        }
    }
}
