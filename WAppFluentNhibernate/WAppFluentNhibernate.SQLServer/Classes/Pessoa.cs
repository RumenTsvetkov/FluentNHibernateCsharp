using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Mapping;
using FluentNHibernate.Mapping;
namespace WAppFluentNhibernate.SQLServer.Classes
{
    public class Pessoa
    {
        public virtual int Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual DateTime? Data { get; set; }
        public virtual TimeSpan? Hora { get; set; }
        public virtual decimal? Valor { get; set; }
        public virtual bool Status { get; set; }
    }
    public class PessoaMap: ClassMap<Pessoa>
    {
        public PessoaMap()
        {
            Id(x => x.Id).GeneratedBy.Identity().Not.Nullable().Unique();
            Map(x => x.Nome).Nullable();
            Map(x => x.Data).Nullable();
            Map(x => x.Hora).Nullable().CustomType("TimeAsTimeSpan"); 
            // TimeAsTimeSpan funciona com campos Time(7) no SqlServer                        
            Map(x => x.Valor).Nullable();
            Map(x => x.Status).Not.Nullable();
        }
    }
}
