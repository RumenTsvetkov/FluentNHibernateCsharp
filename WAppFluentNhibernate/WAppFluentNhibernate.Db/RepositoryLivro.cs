namespace WAppFluentNhibernate.Db
{
    public class RepositoryLivro : WAppFluentNhibernate.Db.Abstract.Repository<WAppFluentNhibernate.Db.Poco.Livro>
    {
        public RepositoryLivro() : base() { }
        public RepositoryLivro(Interface.IConnection Connection)
        : base(Connection)
        {
        }
    }
}
