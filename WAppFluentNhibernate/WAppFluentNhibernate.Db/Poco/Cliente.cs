using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco
{
    public class Cliente
    {
        public Cliente() {
            this.Telefone = new List<Telefone>();
        }

        public virtual int Codigo { get; set; }
        public virtual String Nome { get; set; }
        public virtual DateTime? Data { get; set; }
        //Campo do tipo TimeSpan para Mysql Db o tipo é BigInt(20);
        public virtual TimeSpan Hora { get; set; }
        public virtual Decimal? Valor { get; set; }
        public virtual bool? Status { get; set; }

        public virtual IList<Telefone> Telefone { get; set; }
    }

}
