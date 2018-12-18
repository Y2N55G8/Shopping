using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 商品图片
    /// </summary>
    public class ShangpinImg
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int SI_no { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int S_no { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string SI_img { get; set; }
        /// <summary>
        /// 是否主图(1是 2否)
        /// </summary>
        public int SI_main { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int SI_order { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual Shangpin Shangpin { get; set; }
    }
}
