using acegi.Model;
using NHibernate;
using System.Collections.Generic;
using System.Text;

namespace acegi.Dao
{
    class IdiomaDAO : GenericDAO<Idioma, long>
    {
       
        public Idioma FindByLangu(string langu)
        {
            try
            {
                IQuery query = GetSession().CreateQuery("select e from Idioma e where e.Langu = :langu");

                query.SetParameter("langu", langu);

                IList<Idioma> idiomas = query.List<Idioma>();
                if(idiomas != null && idiomas.Count > 0)
                {
                    return idiomas[0];
                }
            }
            catch
            {
                throw;
            }
            return null;
        }

        public IList<Idioma> FindByCountAndFilter(long count, string idioma, string descricao)
        {
            IList<Idioma> idiomas = new List<Idioma>();
            try
            {
                StringBuilder builder = new StringBuilder("select e from Idioma e ");
                
                if(idioma != "")
                {
                   if(!builder.ToString().Contains(" where "))
                    {
                        builder.Append(" where ");
                    }
                    builder.Append("e.Langu = :idioma ");
                }

                if (descricao != "")
                {
                    if (!builder.ToString().Contains(" where "))
                    {
                        builder.Append(" where ");
                    }

                    if (idioma != "")
                    {
                        builder.Append(" and ");
                    }
                    builder.Append("e.Denominacao like :descricao ");
                }

                IQuery query = GetSession().CreateQuery(builder.ToString());

                if (idioma != "")
                    query.SetParameter("idioma", idioma);

                if (descricao != "")
                    query.SetParameter("descricao", "%" + descricao.Trim() + "%");

                idiomas = query.SetMaxResults((int)count).List<Idioma>();

                if(idiomas == null)
                    idiomas = new List<Idioma>();
            }
            catch
            {
                throw;
            }
            return idiomas;
        }

        public IList<Idioma> FindAllIdioma()
        {
            try{
                return FindAll();
            }
            catch
            {
                throw;
            }
        }

       
    }
}
