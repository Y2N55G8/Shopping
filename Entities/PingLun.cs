using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 评论
    /// </summary>
    public class PingLun
    {
        /// <summary>
        /// 评论编号
        /// </summary>
        public string P_no { get; set; }
        /// <summary>
        /// 发表评论的用户
        /// </summary>
        public string U_username { get; set; }
        /// <summary>
        /// 货品编号
        /// </summary>
        public string S_no { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string P_content { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime P_time { get; set; }
        /// <summary>
        /// 评论状态(1显示 2隐藏)
        /// </summary>
        public int P_flag { get; set; }
    }
}
