using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WAppFluentNhibernate.Db.Interface
{
    public interface IDal<T>: IDisposable where T: class,new()
    {
        WAppFluentNhibernate.Db.Interface.IConnection Connection { get; }
        void Add(T model);
        void Edit(T model);
        void AddorEdit(T model);
        void Remove(T model);        
        T Find(object Key);
        IQueryable<T> Query();
    }
}
