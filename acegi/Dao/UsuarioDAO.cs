using acegi.MODEL;
using NHibernate;
using System.Collections.Generic;

namespace acegi.Dao
{
    class UsuarioDAO : GenericDAO<Usuario, long>
    {
        public Usuario FindByUsuario(string usuario)
        {
            Usuario _usuario = null;
            try
            {
                IQuery query = GetSession().CreateQuery("select e from Usuario e where e.Bname = :usuario");
                query.SetParameter("usuario", usuario);

                IList<Usuario> usuarios = query.List<Usuario>();

                if(usuarios != null)
                {
                    _usuario = usuarios[0];
                }
            }
            catch
            {
                throw;
            }

            return _usuario;
        }
       
    }
}
