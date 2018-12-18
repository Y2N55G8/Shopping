using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ShangpinAttribute
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int SA_id { get; set; }
        /// <summary>
        /// 属性名
        /// </summary>
        public string SA_name { get; set; }
        /// <summary>
        /// 商品id（外键）
        /// </summary>
        public int S_no { get; set; }
        /// <summary>
        /// 属性值
        /// </summary>
        public string SA_Value { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        public virtual Shangpin Shangpin { get; set; }

    }
}
