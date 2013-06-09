using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco.Map
{
    public class AutorMap: ClassMap<Autor>
    {
        public AutorMap()
        {
            Table("autor");
            Id(x => x.Id).Not.Nullable().GeneratedBy.Increment().Column("id");
            Map(x => x.Nome).Not.Nullable().Length(50).Column("nome");
            HasManyToMany<Livro>(x => x.Livro)
                .ParentKeyColumn("autorid")
                .ChildKeyColumn("livroid")
                .Table("autorlivro")
                .LazyLoad()
                .Cascade.Merge();   
             
        }
    }
}
