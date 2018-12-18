using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities;

namespace Core.Mapping
{
    public class AdminMap:EntityTypeConfiguration<Admin>
    {
        public AdminMap() {
            //管理员用户名
            HasKey(x => x.A_uid);
            //管理员密码
            HasKey(x => x.A_pwd);
            //数据库表
            ToTable("Admin");
        }
    }
}
