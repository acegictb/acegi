using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acegi.Model
{
    public class FatorConversao
    {
        public virtual long Id { get; set; }
        public virtual Decimal Fator_Dst { get; set; }
        public virtual Decimal Fator_Ori { get; set; }
        public virtual string Fcurr { get; set; }
        public virtual string Waers { get; set; }
        public virtual string Kurst { get; set; }
        public virtual CategoriaCambio Categoria { get; set; }
        public virtual Moeda Fator { get; set; }
        public virtual Moeda Moeda { get; set; }
        public virtual DateTime ValDesde { get; set; }

    }

    public class FatorConversaoMap : ClassMap<FatorConversao>
    {
        public FatorConversaoMap()
        {
            Table("FATOR_CONVERSAO");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity(); ;
            Map(x => x.Fator_Dst).Column("FATOR_DST").Not.Nullable();
            Map(x => x.Fator_Ori).Column("FATOR_ORI").Not.Nullable(); 
            Map(x => x.Fcurr).Column("FCURR");
            Map(x => x.Waers).Column("WAERS");
            Map(x => x.ValDesde).Column("VALDESDE");
            References(x => x.Categoria, "IDCATCAMBIO");
            References(x => x.Fator).Column("IDFATOR");
            References(x => x.Moeda).Column("IDMOEDA");
        }
    }
}
