using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class ClassSetMap : EntityTypeConfiguration<ClassSet>
    {
        public ClassSetMap()
        {
            //主键
            HasKey(x => x.Cs_id);
            Property(x => x.Cs_name).IsRequired();
            Property(x => x.Cs_register).IsRequired();
            Property(x => x.Cs_login).IsRequired();
           
            Property(x => x.Cs_email).IsRequired();
            Property(x => x.Cs_phone).IsRequired();
            Property(x => x.Cs_evpi).IsRequired();
            Property(x => x.Cs_receiving).IsRequired();


            Property(x => x.Cs_evaluate).IsRequired();
            Property(x => x.Cs_maxcount).IsRequired();
          
            //数据库表名
            ToTable("ClassSet");
        }
    }
}
