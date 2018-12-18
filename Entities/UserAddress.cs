using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 收货地址
    /// </summary>
    public class UserAddress
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int UA_no { get; set; }
        /// <summary>
        /// 收获地址名
        /// </summary>
        public string UA_name { get; set; }
        /// <summary>
        /// 所属用户名
        /// </summary>
        public string U_username { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string UA_person { get; set; }
        /// <summary>
        /// 是否为主地址(1是2否)
        /// </summary>
        public int UA_main { get; set; }
        /// <summary>
        /// 收货电话
        /// </summary>
        public string UA_tel { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string UA_emailno { get; set; }
    }
}
