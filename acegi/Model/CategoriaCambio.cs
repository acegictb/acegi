using FluentNHibernate.Mapping;
using System.Collections.Generic;

namespace acegi.Model
{
    public class CategoriaCambio
    {
        public virtual long Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Kurst { get; set; }
        public virtual IList<FatorConversao> fatores { get; set; }
    }

    public class CategoriaCambioMap : ClassMap<CategoriaCambio>
    {
        public CategoriaCambioMap()
        {
            Table("CAT_CAMBIO");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();
            Map(x => x.Descricao).Column("DESCRICAO");
            Map(x => x.Kurst).Column("KURST");
            HasMany<FatorConversao>(x => x.fatores).KeyColumn("IDCATCAMBIO");
        }
    }
}
