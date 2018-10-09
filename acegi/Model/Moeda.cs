using FluentNHibernate.Mapping;
using System;

namespace acegi.Model
{
    public class Moeda
    {
        public virtual long Id { get; set; }
        public virtual string Waers { get; set; }
        public virtual string Tcurc { get; set; }
        public virtual string Primario { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Cdecimal { get; set; }
        public virtual DateTime ValDesde { get; set; }

    }

    public class MoedaMap : ClassMap<Moeda>
    {
        public MoedaMap()
        {
            Table("MOEDA");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity(); ;
            Map(x => x.Waers).Column("WAERS");
            Map(x => x.Tcurc).Column("TCURC");
            Map(x => x.Primario).Column("PRIMARIO");
            Map(x => x.Descricao).Column("DESCRICAO");
            Map(x => x.Cdecimal).Column("CDECIMAL");
            Map(x => x.ValDesde).Column("VALDESDE");

        }
    }

}
