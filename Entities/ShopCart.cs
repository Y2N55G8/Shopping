using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 购物车
    /// </summary>
    public class ShopCart
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string SC_no { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string MyProperty { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string S_no { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string SC_sname { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double SC_sprice { get; set; }
        /// <summary>
        /// 最大上限数
        /// </summary>
        public int S_countmax { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int S_count { get; set; }
    }
}
