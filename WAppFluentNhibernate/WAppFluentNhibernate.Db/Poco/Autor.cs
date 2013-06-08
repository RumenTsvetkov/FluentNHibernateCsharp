using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco
{
    public class Autor
    {
        public Autor()
        {
            this.Livro = new List<Livro>();
        }
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Livro> Livro { get; set; }
    }
}
