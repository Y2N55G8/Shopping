using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class IntegralSetMap : EntityTypeConfiguration<IntegralSet>
    {
        public IntegralSetMap()
        {
            //主键
            HasKey(x => x.Is_id);

            Property(x => x.Is_name).IsRequired();


            Property(x => x.Is_price).IsRequired();
            Property(x => x.Is_register).IsRequired();
            Property(x => x.Is_login).IsRequired();
            Property(x => x.Is_email).IsRequired();
            Property(x => x.Is_phone).IsRequired();
            Property(x => x.Is_evpi).IsRequired();


            Property(x => x.Is_receiving).IsRequired();
            Property(x => x.Is_evaluate).IsRequired();
            Property(x => x.Is_maxcount).IsRequired();
            Property(x => x.Is_limit).IsRequired();

            //数据库表名
            ToTable("IntegralSet");
        }
    }
}
