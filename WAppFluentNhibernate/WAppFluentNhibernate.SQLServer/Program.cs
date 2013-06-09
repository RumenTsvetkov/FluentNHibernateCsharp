using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WAppFluentNhibernate.SQLServer.Classes;

namespace WAppFluentNhibernate.SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (IConnection Conexao = new Connection())
                {
                    //Pessoa p = new Pessoa();
                    //p.Nome = "SOUZA E SILVA";
                    //p.Status = true;
                    //p.Data = DateTime.Now;
                    //p.Hora = TimeSpan.Parse("13:15:01");
                    //p.Valor = 190.09M;

                    //Conexao.Session.BeginTransaction();
                    //Conexao.Session.Merge<Pessoa>(p);
                    //Conexao.Session.Transaction.Commit();

                    Conexao.Session.Transaction.Begin();
                    Pessoa pal = Conexao.Session.Get<Pessoa>(1);
                    pal.Hora = DateTime.Now.TimeOfDay;
                    pal.Nome = "Alterando o nome gente da gente";
                    Conexao.Session.Transaction.Commit();


                    IList<Pessoa> Pessoas =
                        Conexao.Session.CreateCriteria<Pessoa>().List<Pessoa>();

                    foreach (Pessoa p in Pessoas)
                    {
                        System.Console.WriteLine(
                            String.Format("{0} {1} {2} {3} {4}", p.Id, p.Nome, p.Data, p.Hora, p.Valor, p.Status)
                            );
                    }

                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            System.Console.ReadKey();
        }
    }
}
