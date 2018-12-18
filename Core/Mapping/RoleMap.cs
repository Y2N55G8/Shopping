using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities;

namespace Core.Mapping
{
    /// <summary>
    /// 权限
    /// </summary>
    public class RoleMap:EntityTypeConfiguration<Role>
    {
        public RoleMap() {
            //主键
            HasKey(x => x.R_no);
            //权限名
            Property(x => x.R_name).IsRequired();


            //数据库表名
            ToTable("Role");
        }
    }
}
