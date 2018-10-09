using acegi.Model;
using NHibernate;
using System;
using System.Collections.Generic;

namespace acegi.Dao
{
    class FuncaoMenuDAO : GenericDAO<FuncaoMenu, long>
    {
        public IList<FuncaoMenu> FindByUsuario(String user)
        {
            IList<FuncaoMenu> menus = new List<FuncaoMenu>();
            try
            {
                IQuery q = GetSession().CreateQuery("select e from FuncaoMenu e");

                menus = q.List<FuncaoMenu>();

                if(menus != null)
                {
                    return menus;
                }
                else
                {
                    menus = new List<FuncaoMenu>();
                }

            }catch 
            {
                throw;
            }

            return menus;
        }

    }
}
