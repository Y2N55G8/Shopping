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
    /// 数据库模型(用户类型)
    /// </summary>
    public class UserTypeMap:EntityTypeConfiguration<UserType>
    {
        public UserTypeMap() {
            //主键
            HasKey(x => x.UT_no);
            //标识类型名
            Property(x => x.UT_name);
            //实际显示名
            Property(x => x.UT_display);
            //等级头像
            Property(x => x.UT_img);
            //积分上限
            Property(x => x.UT_jfmax);
            //积分下限
            Property(x => x.UT_jfmin);
            //用户级别位置
            Property(x => x.UT_rank);

            //用户类型表名
            ToTable("UserType");
        }
    }
}
