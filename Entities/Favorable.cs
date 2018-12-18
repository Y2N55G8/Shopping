using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 优惠券
    /// </summary>
    public class Favorable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string F_no { get; set; }
        /// <summary>
        /// 优惠券名称
        /// </summary>
        public string F_name { get; set; }
        /// <summary>
        /// 优惠金额
        /// </summary>
        public double F_money { get; set; }
        /// <summary>
        /// 最低消费金额
        /// </summary>
        public double F_min { get; set; }
        /// <summary>
        /// 发放数量
        /// </summary>
        public int F_count { get; set; }
        /// <summary>
        /// 剩余数量
        /// </summary>
        public int F_shenCount { get; set; }
        /// <summary>
        /// 使用数量
        /// </summary>
        public int F_userCount { get; set; }
        /// <summary>
        /// 领用数量
        /// </summary>
        public int F_getCount { get; set; }
        /// <summary>
        /// 使用开始时间
        /// </summary>
        public DateTime F_userstarttime { get; set; }
        /// <summary>
        /// 使用结束数量
        /// </summary>
        public DateTime F_userendtime { get; set; }
        /// <summary>
        /// 是否发放
        /// </summary>
        public int F_flag { get; set; }
    }
}
