using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 促销
    /// </summary>
    public class Cuxiao
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int C_no { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public string C_name { get; set; }
        /// <summary>
        /// 促销的商品
        /// </summary>
        public int S_no { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime C_starttime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        public DateTime C_endtime { get; set; }
        /// <summary>
        /// 最低用户类型
        /// </summary>
        public int UT_no { get; set; }
        /// <summary>
        /// 配额上限
        /// </summary>
        public int C_max { get; set; }
        /// <summary>
        /// 活动状态(1启用 2停止)
        /// </summary>
        public int C_flag { get; set; }
    }
}
