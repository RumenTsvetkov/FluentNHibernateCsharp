using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Poco
{
    public class Livro
    {
        public Livro()
        {
            this.Autor = new List<Autor>();
        }
        public virtual int Id { get; set; }
        public virtual string Titulo { get; set; }
        public virtual IList<Autor> Autor { get; set; }
    }

}
