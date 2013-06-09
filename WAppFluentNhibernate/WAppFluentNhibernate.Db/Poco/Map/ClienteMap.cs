using FluentNHibernate.Mapping;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//http://www.leandroprado.com.br/2012/01/mapeamentos-com-fluent-nhibernate/

namespace WAppFluentNhibernate.Db.Poco.Map
{
    public class ClienteMap: ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Table("cliente");
            Id(x => x.Codigo).GeneratedBy.Increment().Not.Nullable().Column("codigo");
            Map(x => x.Data).Nullable().Column("data");
            //Map(x => x.Hora).Column("hora").CustomType("timestamp"); // gravar funciona
            //Map(x => x.Hora).Column("hora").CustomType("TimeAsTimeSpan"); // carregar funciona
            //Hora configura como TimeSpan para banco SGBD MySql Type DB=Int64 ou BigInt(20)
            Map(x => x.Hora).Column("hora"); //
            Map(x => x.Nome).Not.Nullable().Column("nome").Length(255);
            Map(x => x.Status).Nullable().Column("status");
            Map(x => x.Valor).Nullable().Column("valor");

            HasMany(x => x.Telefone).Cascade.Merge().LazyLoad().KeyColumn("codigocliente");
        }
    }
}
