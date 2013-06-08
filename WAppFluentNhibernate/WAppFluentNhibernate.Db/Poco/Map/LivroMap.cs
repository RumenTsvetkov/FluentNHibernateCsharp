using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco.Map
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Table("livro");
            Id(x=>x.Id).Not.Nullable().GeneratedBy.Increment().Column("id");
            Map(x => x.Titulo).Not.Nullable().Length(200).Column("titulo");
            HasManyToMany<Autor>(x => x.Autor)
                .LazyLoad()
                .Table("autorlivro")
                .Cascade.Merge()
                .ParentKeyColumn("livroid")
                .ChildKeyColumn("autorid");
        }
    }
}
