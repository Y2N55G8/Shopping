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
        /// 用户名
        /// </summary>
        public string U_username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string U_password { get; set; }
        /// <summary>
        /// 用户类型编号
        /// </summary>
        public int UT_no { get; set; }
        /// <summary>
        /// 默认地址
        /// </summary>
        public int UA_no { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string U_email { get; set; }
        /// <summary>
        /// 用户图像
        /// </summary>
        public string U_img { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string U_tel { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public int Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public int City { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public int Area { get; set; }
    }
}
