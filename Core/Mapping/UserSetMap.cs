using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class UserSetMap : EntityTypeConfiguration<UserSet>
    {
        public UserSetMap()
        {
            //主键
            HasKey(x => x.Us_id);

            Property(x => x.Us_registertype).IsRequired();
          

            Property(x => x.Us_logintype).IsRequired();
            Property(x => x.Us_reserver).IsRequired();
            Property(x => x.Us_registertime).IsRequired();
            Property(x => x.Us_shadowuser).IsRequired();
            Property(x => x.Us_loginerror).IsRequired();
            Property(x => x.Us_rememberpwd).IsRequired();

            Property(x => x.Us_welcome).IsRequired();
            Property(x => x.Us_welcomeinfo).IsRequired();
           
            //数据库表名
            ToTable("UserSet");
        }
    }
}
