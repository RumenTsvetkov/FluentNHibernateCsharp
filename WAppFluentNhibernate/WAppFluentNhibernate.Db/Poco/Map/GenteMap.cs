using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco.Map
{
    public class GenteMap: ClassMap<Gente>
    {
        public GenteMap()
        {
            Table("gente");
            Id(x => x.Id).GeneratedBy.Increment().Not.Nullable().Column("id");
            Map(x => x.Nome).Not.Nullable().Length(45).Column("nome");
        }
    }
}
