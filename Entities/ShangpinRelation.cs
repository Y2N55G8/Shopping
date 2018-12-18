using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 关联商品
    /// </summary>
    public class ShangpinRelation
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int SR_no { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public int S_no { get; set; }
        /// <summary>
        /// 关联的商品编号
        /// </summary>
        public int SR_sno { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual Shangpin Shangpin { get; set;}
    }
}
