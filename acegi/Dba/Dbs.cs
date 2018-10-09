using acegi.Model;
using acegi.MODEL;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace acegi.DBA
{
    public class Dbs
    {
        private static IStatelessSession session;
        private Dbs()
        {
        }

        public static IStatelessSession GetSession()
        {
            if (session == null)
            {
                   ISessionFactory factory = Fluently.Configure()
                        .Database(MySQLConfiguration.Standard
                        .ConnectionString(c => c
                        .Server("192.168.137.150")
                        .Database("acegi")
                        .Username("root")
                        .Password("linroor2012")))
                        .Mappings(m => m.FluentMappings.Add(typeof(UsuarioMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(FuncaoMenuMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(FuncaoSubMenuMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(IdiomaMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(MoedaMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(NRIntervaloMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(PaisMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(CategoriaCambioMap)))
                        .Mappings(m => m.FluentMappings.Add(typeof(FatorConversaoMap)))
                        .ExposeConfiguration(x => x.SetProperty("hbm2ddl.keywords", "auto"))
                        .BuildSessionFactory();

                session = factory.OpenStatelessSession();
            }
            return session;
        }
    }
}
