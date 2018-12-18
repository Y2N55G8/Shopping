using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 属性分组
    /// </summary>
    public class AttributeGroup
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int AG_no { get; set; }
        /// <summary>
        /// 分组名称
        /// </summary>
        public string AG_name { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int C_no { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int AG_order { get; set; }

        /// <summary>
        /// 分类导航
        /// </summary>
        public virtual  Classfiy Classfiy { get; set; }
        /// <summary>
        /// 属性导航
        /// </summary>
        public virtual ICollection<Attribute> Attribute { get; set; }
    }
}
