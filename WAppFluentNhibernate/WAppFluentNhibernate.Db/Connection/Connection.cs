using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WAppFluentNhibernate.Db.Interface;

namespace WAppFluentNhibernate.Db.Connection
{
    public class Connection: IConnection
    {
        private FluentConfiguration _configuration;
        private ISessionFactory _sessiofactory;
        private ISession _session;

        public FluentConfiguration Configuration
        {
            get { return _configuration; }
            private set { _configuration = value; }
        }
        public ISessionFactory SessioFactory
        {
            get { return _sessiofactory; }
            private set { _sessiofactory = value; }
        }

        public ISession Session
        {
            get { return _session; }
            private set { _session = value; }
        }

        public Connection()
        {
            Init();
        }

        private void Init()
        {
            _configuration = Fluently.Configure()                
            .Database(MySQLConfiguration.Standard.ConnectionString(x => x
                                                                     .Server("localhost")
                                                                     .Username("root")
                                                                     .Password("senha")
                                                                     .Database("apphibernate")))
            .Mappings(c => c.FluentMappings.AddFromAssemblyOf<WAppFluentNhibernate.Db.Poco.Cliente>());            
            _sessiofactory = _configuration.BuildSessionFactory();
            _session = _sessiofactory.OpenSession();
        }

        public ISession Open()
        {
            if (_session.IsOpen == false)
            {
                _session = _sessiofactory.OpenSession();
            }
            return _session;
        }

        public void Close()
        {
            if (_session.IsOpen)  _session.Close();                
            _configuration = null;
            if (_sessiofactory.IsClosed == false)
            {
                _sessiofactory.Close();
            }
            _sessiofactory.Dispose();
            _sessiofactory = null;
            _session.Dispose();
            _session = null;
        }
        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }
    }
}
