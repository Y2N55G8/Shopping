using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 活动赠品
    /// </summary>
    public class Gift
    {
        /// <summary>
        /// 赠品编号
        /// </summary>
        public int G_no { get; set; }
        /// <summary>
        /// 促销编号
        /// </summary>
        public string C_no { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string S_no { get; set; }
        /// <summary>
        /// 促销商品数量
        /// </summary>
        public int G_count { get; set; }
    }
}
