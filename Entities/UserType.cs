using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 用户类型
    /// </summary>
    public class UserType
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int UT_no { get; set; }
        /// <summary>
        /// 标识类型名
        /// </summary>
        public string UT_name { get; set; }
        /// <summary>
        /// 实际显示名
        /// </summary>
        public string UT_display { get; set; }
        /// <summary>
        /// 等级头像
        /// </summary>
        public string UT_img { get; set; }
        /// <summary>
        /// 积分上限
        /// </summary>
        public int UT_jfmax { get; set; }
        /// <summary>
        /// 积分下限
        /// </summary>
        public int UT_jfmin { get; set; }
        /// <summary>
        /// 用户级别位置
        /// </summary>
        public int UT_rank { get; set; }
    }
}
