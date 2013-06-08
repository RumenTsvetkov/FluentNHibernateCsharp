using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace WAppFluentNhibernate.Db.Poco.Map
{
    public class GenteJuridicaMap: SubclassMap<GenteJuridica>
    {
        public GenteJuridicaMap()
        {
            Table("gentejuridica");
            Map(x => x.Cnpj).Length(20).Not.Nullable();
            KeyColumn("genteid");
            LazyLoad();
        }
    }
}
