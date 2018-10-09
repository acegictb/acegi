using acegi.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acegi.Dao
{
    class FatorConversaoDAO : GenericDAO<FatorConversao, long>
    {
        public FatorConversao FindByFator(string kurst, string fcurr, string waers)
        {
            try
            {
                IQuery query = GetSession().CreateQuery("select e from FatorConversao e where e.Categoria.Kurst = :kurst and" +
                    " e.Fcurr = :fcurr and e.Waers = :waers");

                query.SetParameter("kurst", kurst);
                query.SetParameter("fcurr", fcurr);
                query.SetParameter("waers", waers);

                IList<FatorConversao> fatores = query.List<FatorConversao>();
                if (fatores != null && fatores.Count > 0)
                {
                    return fatores[0];
                }
            }
            catch
            {
                throw;
            }
            return null;
        }
    }
}
