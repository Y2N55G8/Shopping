using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Areas.Manage.Models
{
    /// <summary>
    /// 用户
    /// </summary>
    public class UserinfoModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Display(Name ="用户编号")]
        public int U_no { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "用户名")]
        public string U_username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Display(Name = "密码")]
        public string U_password { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [Display(Name = "昵称")]
        public string U_nick { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name = "性别")]
        public string U_sex { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [Display(Name = "真实姓名")]
        public string U_name { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        [Display(Name = "身份证")]
        public string U_identity { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? U_birth { get; set; }
        /// <summary>
        /// 支付积分
        /// </summary>
        [Display(Name = "支付积分")]
        public int U_ji { get; set; }
        /// <summary>
        /// 用户图像
        /// </summary>
        [Display(Name = "头像")]
        public string U_img { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        [Display(Name = "手机号")]
        public string U_tel { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        [Display(Name = "邮箱")]
        public string U_email { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [Display(Name = "详细地址")]
        public string U_address { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        [Display(Name = "简介")]
        public string U_about { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [Display(Name = "注册时间")]
        public DateTime U_regtime { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        [Display(Name = "最后一次登录时间")]
        public DateTime U_logintime { get; set; }
        /// <summary>
        /// 用户类型编号
        /// </summary>
        [Display(Name = "用户类型")]
        public int UT_no { get; set; }
        /// <summary>
        /// 默认地址(外键)
        /// </summary>
        [Display(Name = "默认地址")]
        public int UA_no { get; set; }
        /// <summary>
        /// 地区(外键)
        /// </summary>
        [Display(Name = "地区")]
        public int C_no { get; set; }
        /// <summary>
        /// 权限组编号(外键)
        /// </summary>
        [Display(Name = "权限组编号")]
        public int RG_no { get; set; }
    }
}
