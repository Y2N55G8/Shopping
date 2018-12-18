using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 配送信息
    /// </summary>
    public class Distribution
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int D_no { get; set; }
        /// <summary>
        /// 配送时间
        /// </summary>
        public DateTime D_time { get; set; }
        /// <summary>
        /// 配送费用
        /// </summary>
        public double D_money { get; set; }
        /// <summary>
        /// 配送方式
        /// </summary>
        public string D_methood { get; set; }
    }
}
