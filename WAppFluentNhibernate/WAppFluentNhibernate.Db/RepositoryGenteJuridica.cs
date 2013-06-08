using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db
{
    public class RepositoryGenteJuridica : WAppFluentNhibernate.Db.Abstract.Repository<WAppFluentNhibernate.Db.Poco.GenteJuridica>
    {
        public RepositoryGenteJuridica() : base() { }
        public RepositoryGenteJuridica(Interface.IConnection Connection)
            : base(Connection)
        {
        }
    }
}
