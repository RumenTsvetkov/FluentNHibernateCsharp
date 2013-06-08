using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco
{
   
    public class GenteJuridica : Gente
    {
        public virtual String Cnpj { get; set; }
    }
    
}
