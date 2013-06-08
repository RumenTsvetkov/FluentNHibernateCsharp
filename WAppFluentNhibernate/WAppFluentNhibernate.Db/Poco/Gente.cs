using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco
{
    public class Gente
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
    }
}
