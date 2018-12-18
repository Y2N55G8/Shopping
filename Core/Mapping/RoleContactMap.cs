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
    /// 权限组对应
    /// </summary>
    public class RoleContactMap:EntityTypeConfiguration<RoleContact>
    {
        public RoleContactMap() {
            //主键
            HasKey(x => x.RC_no);
            //权限组编号
            Property(x => x.RG_no);
            //权限编号
            Property(x => x.R_no);

            //数据库表名
            ToTable("RoleContact");
        }
    }
}
