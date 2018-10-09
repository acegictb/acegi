using FluentNHibernate.Mapping;
using System.Collections.Generic;

namespace acegi.Model
{
    public class FuncaoMenu
    {
        public virtual long Id { get; set; }
        public virtual string Menu { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<FuncaoSubMenu> FuncoesSubMenu { get; set; }
    }

    public class FuncaoMenuMap : ClassMap<FuncaoMenu>
    {
        public FuncaoMenuMap()
        {
            Table("FUNCOES_MENU");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity();
            Map(x => x.Menu).Column("MENU");
            Map(x => x.Descricao).Column("DESCRICAO");
            HasMany(x => x.FuncoesSubMenu).KeyColumn("IDMENU").AsBag().Not.LazyLoad();
        }
    }

}
