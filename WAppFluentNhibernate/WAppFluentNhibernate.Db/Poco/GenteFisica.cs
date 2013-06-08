using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco
{
    public class GenteFisica: Gente
    {
        public virtual String Cpf { get; set; }
    }
}
