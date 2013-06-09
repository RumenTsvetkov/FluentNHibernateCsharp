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
            try{

                Connection Conexao = new Connection();
                Conexao.Open();

                Cliente cliente = new Cliente();
                cliente.Nome = "Teste 1";
                cliente.Valor = 100;
                cliente.Data = DateTime.Now;
                cliente.Hora = DateTime.Now.TimeOfDay;
                cliente.Status = true;

                Conexao.Session.Transaction.Begin();
                Conexao.Session.Merge(cliente);
                Conexao.Session.Transaction.Commit();

                Conexao.Dispose();


            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }


            //return;
            Task TaskLoad = new Task(() =>
            {
                Carregar_Grid();
            });
            TaskLoad.Start();
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
                    if (Clientes != null)
                    {
                        dataGridView1.DataSource = Clientes.Select(x => new { x.Codigo, x.Nome }).ToList();
                        dataGridView1.Update();
                        Clientes = null;
                    }
                    else label1.Text = "Error";
                }
            }
        }
    }
}
