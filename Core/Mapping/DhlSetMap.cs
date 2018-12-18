using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class DhlSetMap : EntityTypeConfiguration<DhlSet>
    {
        public DhlSetMap()
        {
            //主键
            HasKey(x => x.Ds_id);

            Property(x => x.Ds_name).IsRequired();
            Property(x => x.Ds_sort).IsRequired();

                     //数据库表名
            ToTable("DhlSet");
        }
    }
}
