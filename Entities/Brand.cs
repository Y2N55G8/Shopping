using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 商品品牌
    /// </summary>
    public class Brand
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int B_no { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string B_name { get; set; }
        /// <summary>
        /// 品牌log照片
        /// </summary>
        public string B_Log { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int B_order { get; set; }

        /// <summary>
        /// 品牌分类
        /// </summary>
        public virtual ICollection<BrandClass> BrandClasses { get; set; }
        /// <summary>
        /// 商品
        /// </summary>
        public virtual ICollection<Shangpin> Shangpins { get; set; }
    }
}
