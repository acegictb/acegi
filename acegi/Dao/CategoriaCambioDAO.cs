using acegi.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acegi.Dao
{
    class CategoriaCambioDAO : GenericDAO<CategoriaCambio, long>
    {
        public CategoriaCambio FindByCategoria(string categoria)
        {
            CategoriaCambio _categoria = null;
            try
            {
                IQuery query = GetSession().CreateQuery("select e from CategoriaCambio e where e.Kurst = :categoria");
                query.SetParameter("categoria", categoria);

                IList<CategoriaCambio> categorias = query.List<CategoriaCambio>();

                if (categorias != null && categorias.Count > 0)
                {
                    _categoria = categorias[0]; 
                }
            }
            catch
            {
                throw;
            }

            return _categoria;
        }

        public IList<CategoriaCambio> FindByCategoriaDescricao(string categoria, string descricao)
        {
            IList<CategoriaCambio> catCambios = new List<CategoriaCambio>();
            try
            {
                String sql = "select e from CategoriaCambio e";

                if(categoria != null && categoria != "")
                {
                    sql += " where e.Kurst = :categoria ";
                }

                if(descricao != null && descricao != "")
                {

                    if (!sql.ToString().Contains(" where "))
                    {
                        sql += " where ";
                    }

                    if (categoria != "")
                    {
                        sql += " and ";
                    }

                    sql += " e.Descricao like :descricao";
                }

                IQuery query = GetSession().CreateQuery(sql);

                if (categoria != "")
                    query.SetParameter("categoria", categoria);

                if (descricao != "")
                    query.SetParameter("descricao", "%" + descricao.Trim() + "%");

                catCambios = query.List<CategoriaCambio>();

                if (catCambios == null)
                    catCambios = new List<CategoriaCambio>();
            }
            catch
            {
                throw;
            }
            return catCambios;
        }
    }

}
