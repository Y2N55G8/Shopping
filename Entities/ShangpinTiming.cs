using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 定时商品
    /// </summary>
    public class ShangpinTiming
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ST_no { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int S_no { get; set; }
        /// <summary>
        /// 上架时间
        /// </summary>
        public DateTime ST_starttime { get; set; }
        /// <summary>
        /// 下架时间
        /// </summary>
        public DateTime ST_endtime { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual Shangpin Shangpin { get; set; }
    }
}
