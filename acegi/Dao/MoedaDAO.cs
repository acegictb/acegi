using acegi.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace acegi.Dao
{
    class MoedaDAO : GenericDAO<Moeda, long>
    {
        public Moeda FindByWaers(String waers)
        {
            try
            {
                IQuery query = GetSession().CreateQuery("select e from Moeda e where e.Waers = :waers");

                query.SetParameter("waers", waers);

                IList<Moeda> moedas = query.List<Moeda>();
                if (moedas != null && moedas.Count > 0)
                {
                    return moedas[0];
                }
            }
            catch
            {
                throw;
            }
            return null;
        }

        public IList<Moeda> FindByCountAndFilter(string waers, string descricao, string primario)
        {
            IList<Moeda> moedas = new List<Moeda>();
            try
            {
                StringBuilder builder = new StringBuilder("select e from Moeda e ");

                if (waers != "")
                {
                    if (!builder.ToString().Contains(" where "))
                    {
                        builder.Append(" where ");
                    }
                    builder.Append("e.Waers = :waers ");
                }

                if (descricao != "")
                {
                    if (!builder.ToString().Contains(" where "))
                    {
                        builder.Append(" where ");
                    }

                    if (waers != "")
                    {
                        builder.Append(" and ");
                    }
                    builder.Append("e.Descricao like :descricao ");
                }

                if (primario != "")
                {
                    if (!builder.ToString().Contains(" where "))
                    {
                        builder.Append(" where ");
                    }

                    if (waers != "" || descricao != "")
                    {
                        builder.Append(" and ");
                    }
                    builder.Append("e.Primario = :primario ");
                }

                IQuery query = GetSession().CreateQuery(builder.ToString());

                if (waers != "")
                    query.SetParameter("waers", waers);

                if (descricao != "")
                    query.SetParameter("descricao", "%" + descricao.Trim() + "%");

                if(primario == "X")
                    query.SetParameter("primario", "X");

                moedas = query.List<Moeda>();

                if (moedas == null)
                    moedas = new List<Moeda>();
            }
            catch
            {
                throw;
            }
            return moedas;
        }

    }
}
