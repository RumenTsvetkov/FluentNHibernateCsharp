using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WAppFluentNhibernate.Db.Abstract
{
    public abstract class Repository<T> : WAppFluentNhibernate.Db.Interface.IDal<T> where T: class, new()
    {
        private Interface.IConnection _connection;
        public Interface.IConnection Connection
        {
            get { return this._connection; }
            private set { this._connection = value; }
        }
        public Repository()
        {
            this._connection = new Connection.Connection();
            this.Connection.Open();
        }
        public Repository(Interface.IConnection Connection)
        {
            this._connection = Connection;
            this.Connection.Open();
        }

        public void Add(T model)
        {
            this._connection.Session.Transaction.Begin();
            this._connection.Session.Merge<T>(model);
            this._connection.Session.Transaction.Commit();
        }

        public void Edit(T model)
        {
            this._connection.Session.Transaction.Begin();
            this._connection.Session.Merge<T>(model);
            this._connection.Session.Transaction.Commit();
        }

        public void AddorEdit(T model)
        {
            this._connection.Session.Transaction.Begin();
            this._connection.Session.Merge<T>(model);
            this._connection.Session.Transaction.Commit();
        }

        public void Remove(T model)
        {
            this._connection.Session.Transaction.Begin();
            this._connection.Session.Delete(model);
            this._connection.Session.Transaction.Commit();
        }

        public T Find(object Key)
        {
            return (T)this._connection.Session.Get<T>(Key);
        }

        public IQueryable<T> Query()
        {
            return this._connection.Session.CreateCriteria<T>().List<T>().AsQueryable<T>();
        }

        public void Dispose()
        {
            this.Connection.Close();
            GC.SuppressFinalize(this);
        }
    }
}
