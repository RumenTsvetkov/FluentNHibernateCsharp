using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WAppFluentNhibernate.Db.Connection;
using WAppFluentNhibernate.Db.Poco;
using WAppFluentNhibernate.Db.Abstract;
using WAppFluentNhibernate.Db.Interface;
using WAppFluentNhibernate.Db;
using System.Threading.Tasks;
namespace WAppFluentNhibernate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private delegate void CarregarGrid();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (Repository<Livro> dallivro = new RepositoryLivro())
                {
                    Repository<Autor> dalautor = new RepositoryAutor(dallivro.Connection);

                    Livro livro = dallivro.Find(2);
                    Autor autor = dalautor.Find(1);

                    //autor.Livro.Add(livro);

                    //dalautor.Edit(autor);

                }
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
            }


            return;
            //Task TaskLoad = new Task(() =>
            //{
            //    Carregar_Grid();
            //});
            //TaskLoad.Start();
        }
        public void Carregar_Grid()
        {
            if (this.InvokeRequired)
            {
                CarregarGrid CGrid = new CarregarGrid(Carregar_Grid);
                this.Invoke(CGrid);
            }
            else
            {
                using (Repository<Cliente> RepCliente = new RepositoryCliente())
                {
                    IQueryable<Cliente> Clientes = RepCliente.Query();
                    dataGridView1.DataSource = Clientes.Select(x => new { x.Codigo, x.Nome }).ToList();
                    dataGridView1.Update();
                    Clientes = null;                    
                }
            }
        }
    }
}
