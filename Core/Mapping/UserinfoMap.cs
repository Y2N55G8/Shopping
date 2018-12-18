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
    /// 数据库模型(用户)
    /// </summary>
    public class UserinfoMap : EntityTypeConfiguration<Userinfo>
    {
        public UserinfoMap()
        {
            //用户名
            HasKey(x => x.U_username);
            //密码
            Property(x => x.U_password).IsRequired();
            //用户类型编号(外键)
            Property(x => x.UT_no).IsRequired();
            //默认地址
            Property(x => x.UA_no).IsRequired();
            //用户邮箱
            Property(x => x.U_email);
            //用户头像
            Property(x => x.U_img);
            //用户手机号
            Property(x => x.U_tel);
            //省份
            Property(x => x.Province);
            //城市
            Property(x => x.City);
            //区
            Property(x => x.Area);
            
            //表名
            ToTable("Userinfo");
        }
    }
}
