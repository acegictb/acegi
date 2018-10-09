using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acegi.Model
{
    public class FuncaoSubMenu
    {
        public virtual long Id { get; set; }
        public virtual string SubMenu { get; set; }
        public virtual string Superior { get; set; }
        public virtual string Acao { get; set; }
        public virtual string Descricao { get; set; }
        public virtual FuncaoMenu FuncoesMenu { get; set; }
        public virtual  string Transacao { get; set; }
  
    }

    public class FuncaoSubMenuMap : ClassMap<FuncaoSubMenu>
    {
        public FuncaoSubMenuMap()
        {
            Table("FUNCOES_SUB_MENU");
            Id(x => x.Id).Column("ID").GeneratedBy.Identity(); ;
            Map(x => x.SubMenu).Column("SUBMENU");
            Map(x => x.Superior).Column("SUPERIOR");
            Map(x => x.Acao).Column("ACAO");
            Map(x => x.Descricao).Column("DESCRICAO");
            Map(x => x.Transacao).Column("TRANSACAO");
            References(x => x.FuncoesMenu) 
                .Column("IDMENU")
                .Cascade.All();
        }
    }

}
