using acegi.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace acegi.Dao
{
    class PaisDAO : GenericDAO<Pais, long>
    {
        public Pais FindByLand(String land)
        {
            try
            {
                IQuery query = GetSession().CreateQuery("select e from Pais e where e.Land = :land");

                query.SetParameter("land", land);

                IList<Pais> paises = query.List<Pais>();
                if (paises != null && paises.Count > 0)
                {
                    return paises[0];
                }
            }
            catch
            {
                throw;
            }
            return null;
        }

        public IList<Pais> FindByCountAndFilter(long count, string pais, string nome)
        {
            IList<Pais> paises = new List<Pais>();
            try
            {
                StringBuilder builder = new StringBuilder("select e from Pais e ");

                if (pais != "")
                {
                    if (!builder.ToString().Contains(" where "))
                    {
                        builder.Append(" where ");
                    }
                    builder.Append("e.Land = :pais ");
                }

                if (nome != "")
                {
                    if (!builder.ToString().Contains(" where "))
                    {
                        builder.Append(" where ");
                    }

                    if (pais != "")
                    {
                        builder.Append(" and ");
                    }
                    builder.Append("e.Nome like :nome ");
                }

                IQuery query = GetSession().CreateQuery(builder.ToString());

                if (pais != "")
                    query.SetParameter("pais", pais);

                if (nome != "")
                    query.SetParameter("nome", "%" + nome.Trim() + "%");

                paises = query.SetMaxResults((int)count).List<Pais>();

                if (paises == null)
                    paises = new List<Pais>();
            }
            catch
            {
                throw;
            }
            return paises;
        }

    }
}
