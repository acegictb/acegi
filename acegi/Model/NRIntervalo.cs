using FluentNHibernate.Mapping;

namespace acegi.Model
{
    public class NRIntervalo
    {
        public virtual long Id { get; set; }
        public virtual string NrObject { get; set; }
        public virtual string SubNrObject { get; set; }
        public virtual string NrRange { get; set; }
        public virtual string Ryear { get; set; }
        public virtual string FromNumber { get; set; }
        public virtual string ToNumber { get; set; }
        public virtual string NrLevel { get; set; }
        public virtual string ExternInd { get; set; }

    }

    public class NRIntervaloMap : ClassMap<NRIntervalo>
    {
        public NRIntervaloMap()
        {
            Table("NR_INTERVALO");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity(); ;
            Map(x => x.NrObject).Column("NROBJECT");
            Map(x => x.SubNrObject).Column("SUBNROBJECT");
            Map(x => x.NrRange).Column("NRRANGE");
            Map(x => x.Ryear).Column("RYEAR");
            Map(x => x.FromNumber).Column("FROMNUMBER");
            Map(x => x.ToNumber).Column("TONUMBER");
            Map(x => x.NrLevel).Column("NRLEVEL");
            Map(x => x.ExternInd).Column("EXTERNIND");

        }
    }

}
