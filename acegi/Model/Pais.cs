using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acegi.Model
{
    public class Pais
    {
        public virtual long Id { get; set; }
        public virtual string Land { get; set; }
        public virtual string Langu { get; set; }
        public virtual string Nome { get; set; }
        public virtual string PaisIso { get; set; }
        public virtual Idioma Idioma { get; set; }
    }

    public class PaisMap : ClassMap<Pais>
    {
        public PaisMap()
        {
            Table("PAIS");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity(); ;
            Map(x => x.Land).Column("LAND").Not.Nullable();
            Map(x => x.Langu).Column("LANGU").Not.Nullable(); ;
            Map(x => x.Nome).Column("NOME");
            Map(x => x.PaisIso).Column("PAISISO");
            References(x => x.Idioma)
              .Column("IDIDIOMA");
        }
    }

}
