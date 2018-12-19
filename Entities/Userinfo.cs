using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 用户
    /// </summary>
    public class Userinfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int U_no { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string U_username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string U_password { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string U_nick { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string U_sex { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string U_name { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string U_identity { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? U_birth { get; set; }
        /// <summary>
        /// 支付积分
        /// </summary>
        public int U_ji { get; set; }
        /// <summary>
        /// 用户图像
        /// </summary>
        public string U_img { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string U_tel { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string U_email { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string U_address { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string U_about { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime U_regtime { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime? U_logintime { get; set; }
        /// <summary>
        /// 用户类型编号
        /// </summary>
        public int UT_no { get; set; }
        /// <summary>
        /// 默认地址(外键)
        /// </summary>
        public int UA_no { get; set; }
        /// <summary>
        /// 地区(外键)
        /// </summary>
        public int C_no { get; set; }
        /// <summary>
        /// 权限组编号(外键)
        /// </summary>
        public int RG_no { get; set; }
    }
}
