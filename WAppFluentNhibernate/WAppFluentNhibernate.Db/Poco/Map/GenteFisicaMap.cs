using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco.Map
{
    public class GenteFisicaMap : SubclassMap<GenteFisica>
    {
        public GenteFisicaMap()
        {
            Table("gentefisica");
            Map(x => x.Cpf).Column("cpf").Not.Nullable().Length(14);
            KeyColumn("genteid");
            LazyLoad();
        }
    }
}
