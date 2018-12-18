using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 订单明细
    /// </summary>
    public class OrderDetailed
    {
        /// <summary>
        /// 订单明细编号
        /// </summary>
        public int OD_no { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string S_no { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int OD_count { get; set; }
    }
}
