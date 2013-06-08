using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco
{
    public class Telefone
    {
        public Telefone() { }
        public virtual int Codigo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual String Ddd { get; set; }
        public virtual String Numero { get; set; }
    }
}
