using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class MallSetMap : EntityTypeConfiguration<MallSet>
    {
        public MallSetMap()
        {
            //主键
            HasKey(x => x.Ms_id);

            Property(x => x.Ms_visitorcar).IsRequired();
            Property(x => x.Ms_carsubmit).IsRequired();

            Property(x => x.Ms_visitorcars).IsRequired();
            Property(x => x.Ms_vipcars).IsRequired();
            Property(x => x.Ms_cartime).IsRequired();
            Property(x => x.Ms_orderid).IsRequired();
            Property(x => x.Ms_ipay).IsRequired();
            Property(x => x.Ms_receiving).IsRequired();

            Property(x => x.Ms_history).IsRequired();
            Property(x => x.Ms_history).IsRequired();
            Property(x => x.Ms_favorites).IsRequired();

            //数据库表名
            ToTable("MallSet");
        }
    }
}
