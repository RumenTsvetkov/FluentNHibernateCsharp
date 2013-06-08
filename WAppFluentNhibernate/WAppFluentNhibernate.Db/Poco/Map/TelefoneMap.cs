using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco.Map
{
    public class TelefoneMap: ClassMap<Telefone>
    {
        public TelefoneMap(){
            Table("telefone");
            Id(x => x.Codigo).Not.Nullable().UniqueKey("codigo").GeneratedBy.Increment().Column("codigo");
            Map(x => x.Ddd).Not.Nullable().Column("ddd").Length(3);
            Map(x => x.Numero).Not.Nullable().Column("numero").Length(14);

            References(x => x.Cliente).Cascade.Merge().LazyLoad().Column("codigocliente");
        }
    }
}
