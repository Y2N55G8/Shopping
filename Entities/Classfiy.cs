using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 分类
    /// </summary>
    public class Classfiy
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int C_no { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string C_name { get; set; }
        /// <summary>
        /// 价格范围(按照0-200|200-300 格式存放)
        /// </summary>
        public string C_prices { get; set; }
        /// <summary>
        /// 顶层分类
        /// </summary>
        public int C_cno { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int C_order { get; set; }

        /// <summary>
        /// 属性分组
        /// </summary>
        public virtual ICollection<AttributeGroup> AttributeGroups { get; set; }

        /// <summary>
        /// 品牌分类
        /// </summary>
        public virtual ICollection<BrandClass> BrandClass { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual ICollection<Shangpin> Shangpins { get; set; }

    }
}
