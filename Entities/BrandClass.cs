using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 品牌分类
    /// </summary>
    public class BrandClass
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int BC_no { get; set; }
        /// <summary>
        /// 品牌编号
        /// </summary>
        public int B_no { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int C_no { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public virtual Classfiy Classfiy { get; set; }

       /// <summary>
       /// 商品品牌
       /// </summary>
        public virtual Brand Brand { get; set; }
    }
}
