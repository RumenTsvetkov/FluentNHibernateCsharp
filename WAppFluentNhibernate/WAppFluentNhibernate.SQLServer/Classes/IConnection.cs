using System;
namespace WAppFluentNhibernate.SQLServer.Classes
{
    public interface IConnection: IDisposable
    {
        void Close();
        FluentNHibernate.Cfg.FluentConfiguration Configuration { get; }        
        NHibernate.ISession Open();
        NHibernate.ISessionFactory SessioFactory { get; }
        NHibernate.ISession Session { get; }
    }
}
