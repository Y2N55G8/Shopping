using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class SiteInfoMap: EntityTypeConfiguration<SiteInfo>
    {
        public SiteInfoMap()
        {
            //主键
            HasKey(x => x.Si_id);
            
            Property(x => x.Si_name).IsRequired();
            Property(x => x.Si_url).IsRequired();

            Property(x => x.Si_title).IsRequired();
            Property(x => x.Si_keyword).IsRequired();
            Property(x => x.Si_depict).IsRequired();
            Property(x => x.Si_depict).IsRequired();
            Property(x => x.Si_script).IsRequired();
            Property(x => x.Si_copy).IsRequired();
            //数据库表名
            ToTable("SiteInfo");
        }
    }

}
