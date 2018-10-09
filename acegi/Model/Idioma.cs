using FluentNHibernate.Mapping;
using System.Collections.Generic;

namespace acegi.Model
{
    public class Idioma
    {
        public virtual long Id { get; set; }
        public virtual string Spras { get; set; }
        public virtual string Langu { get; set; }
        public virtual string Denominacao { get; set; }
        public virtual ISet<Pais> Paises { get; protected set; }

    }

    public class IdiomaMap : ClassMap<Idioma>
    {
        public IdiomaMap()
        {
            Table("IDIOMA");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();
            Map(x => x.Spras).Column("SPRAS");
            Map(x => x.Langu).Column("LANGU");
            Map(x => x.Denominacao).Column("DENOMINACAO");
            HasMany(x => x.Paises)
              .KeyColumn("IDIDIOMA")
              .Inverse();
        }
    }
}
