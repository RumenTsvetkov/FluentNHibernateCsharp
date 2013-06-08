namespace WAppFluentNhibernate.Db
{
    public class RepositoryAutor : WAppFluentNhibernate.Db.Abstract.Repository<WAppFluentNhibernate.Db.Poco.Autor>
    {
        public RepositoryAutor() : base() { }
        public RepositoryAutor(Interface.IConnection Connection)
            : base(Connection)
        {
        }
    }
}
