using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 优惠券所属商品
    /// </summary>
    public class FavorableShop
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int FS_no { get; set; }
        /// <summary>
        /// 优惠券编号
        /// </summary>
        public string F_no { get; set; }
        /// <summary>
        /// 所属商品编号
        /// </summary>
        public string S_no { get; set; }
    }
}
