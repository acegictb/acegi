using acegi.Model;
using NHibernate;
using System.Collections.Generic;

namespace acegi.Dao
{
    class FuncaoSubMenuDAO : GenericDAO<FuncaoSubMenu, long>
    {
        public FuncaoSubMenu FindByTransacao(string transacao)
        {
            try
            {
                IQuery query = GetSession().CreateQuery("select e from FuncaoSubMenu e where e.Transacao = :transacao");

                query.SetParameter("transacao", transacao);

                IList<FuncaoSubMenu> transacoes = query.List<FuncaoSubMenu>();
                if (transacoes != null && transacoes.Count > 0)
                {
                    return transacoes[0];
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
