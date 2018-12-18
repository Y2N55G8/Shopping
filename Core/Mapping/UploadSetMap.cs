using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class UploadSetMap : EntityTypeConfiguration<UploadSet>
    {
        public UploadSetMap()
        {
            //主键
            HasKey(x => x.Ups_id);

            Property(x => x.Ups_type).IsRequired();


            Property(x => x.Ups_size).IsRequired();
            Property(x => x.Ups_watermark).IsRequired();
            Property(x => x.Ups_brand).IsRequired();
            Property(x => x.Ups_good).IsRequired();
            Property(x => x.Ups_head).IsRequired();
            Property(x => x.Ups_class).IsRequired();

        
            //数据库表名
            ToTable("UploadSet");
        }
    }

}
