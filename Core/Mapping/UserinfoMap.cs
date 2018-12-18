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
            //用户编号
            HasKey(x => x.U_no);
            //用户名
            Property(x => x.U_username);
            //密码
            Property(x => x.U_password);
            //昵称
            Property(x => x.U_nick);
            //性别
            Property(x => x.U_sex);
            //真实姓名
            Property(x => x.U_name);
            //身份证
            Property(x => x.U_identity);
            //出生日期
            Property(x => x.U_birth);
            //支付积分
            Property(x => x.U_ji);
            //用户头像
            Property(x => x.U_img);
            //用户手机号
            Property(x => x.U_tel);
            //用户邮箱
            Property(x => x.U_email);
            //详细地址
            Property(x => x.U_email);
            //简介
            Property(x => x.U_about);
            //注册时间
            Property(x => x.U_regtime);
            //最后一次登陆时间
            Property(x => x.U_logintime);
            //用户类型编号(外键)
            Property(x => x.UT_no);
            //默认地址(外键)
            Property(x => x.UA_no);
            //地区(外键)
            Property(x => x.C_no);
            //权限组编号(外键)
            Property(x => x.RG_no);
            
            //表名
            ToTable("Userinfo");
        }
    }
}
