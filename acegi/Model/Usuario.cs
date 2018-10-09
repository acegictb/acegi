using FluentNHibernate.Mapping;
using System;

namespace acegi.MODEL
{
    [Serializable]
    public class Usuario
    {
        public virtual long Id { get; set; }
        public virtual string Bname { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime FromDate { get; set; }
        public virtual DateTime ToDate { get; set; }
     
    }

    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("USUARIO");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity(); ;
            Map(x => x.Bname).Column("BNAME");
            Map(x => x.FromDate).Column("FROMDATE");
            Map(x => x.Nome).Column("NOME");
            Map(x => x.ToDate).Column("TODATE");
            Map(x => x.Senha).Column("SENHA");
        }
    }

}
