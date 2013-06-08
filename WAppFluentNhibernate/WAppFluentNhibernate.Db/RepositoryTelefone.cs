using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db
{
    public sealed class RepositoryTelefone : WAppFluentNhibernate.Db.Abstract.Repository<WAppFluentNhibernate.Db.Poco.Telefone>
    {
        public RepositoryTelefone() : base() { }
        public RepositoryTelefone(Interface.IConnection Connection)
            : base(Connection)
        {
        }
    }
}
