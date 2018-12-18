using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 属性值列表
    /// </summary>
    public class AttributeValue
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int AV_no { get; set; }
        /// <summary>
        /// 属性值
        /// </summary>
        public string AV_name { get; set; }
        /// <summary>
        /// 所属属性编号
        /// </summary>
        public int A_no { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int A_order { get; set; }

        /// <summary>
        /// 属性导航
        /// </summary>
        public virtual Attribute Attribute { get; set; }


    }
}
