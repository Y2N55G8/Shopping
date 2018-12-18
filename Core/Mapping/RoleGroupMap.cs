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
    /// 管理员权限组
    /// </summary>
    public class RoleGroupMap:EntityTypeConfiguration<RoleGroup>
    {
        public RoleGroupMap() {
            //管理权限组编号
            HasKey(x => x.RG_no);
            //权限组名称
            Property(x => x.RG_name).IsRequired();
        }
    }
}
