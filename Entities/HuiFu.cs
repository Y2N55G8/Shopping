using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 回复表
    /// </summary>
    public class HuiFu
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int H_no { get; set; }
        /// <summary>
        /// 回复人
        /// </summary>
        public string H_writer { get; set; }
        /// <summary>
        /// 评论编号
        /// </summary>
        public string P_no { get; set; }
        /// <summary>
        /// 回复内容
        /// </summary>
        public string H_content { get; set; }
        /// <summary>
        /// 回复状态(1显示 2隐藏)
        /// </summary>
        public int H_flag { get; set; }
        /// <summary>
        /// 回复时间
        /// </summary>
        public DateTime H_time { get; set; }
    }
}
