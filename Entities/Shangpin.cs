using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Shangpin
    {
        /// <summary>
        /// 主键(UUID)
        /// </summary>
        public int S_no { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string S_name { get; set; }
        /// <summary>
        /// 商品货号
        /// </summary>
        public string S_number { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int C_no { get; set; }
        /// <summary>
        /// 品牌编号
        /// </summary>
        public int B_no { get; set; }
        /// <summary>
        /// 成本价
        /// </summary>
        public double S_costprice { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        public double S_marketprice { get; set; }
        /// <summary>
        /// 本地价
        /// </summary>
        public double S_myprice { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public double S_weight { get; set; }
        /// <summary>
        /// 库存数量
        /// </summary>
        public int S_count { get; set; }
        /// <summary>
        /// 库存上限
        /// </summary>
        public int S_max { get; set; }
        /// <summary>
        /// 库存下限
        /// </summary>
        public int S_min { get; set; }
        /// <summary>
        /// 是否上架(1上架 2下架 3已删除)
        /// </summary>
        public int S_flag { get; set; }
        /// <summary>
        /// 商品标签(1热销 2精品 3新品)(多选)
        /// </summary>
        public string  S_label { get; set; }
        /// <summary>
        /// 是否热销(1是 2否)
        /// </summary>
        public int S_isHot { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int S_order { get; set; }
        /// <summary>
        /// 详细描述
        /// </summary>
        public string S_xx { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public virtual Classfiy Classfiy { get; set; }
        /// <summary>
        /// 商品品牌
        /// </summary>
        public virtual Brand Brand { get; set; }

        /// <summary>
        /// 定时商品
        /// </summary>
        public virtual ICollection<ShangpinTiming> ShangpinTimings { get; set; } 

        /// <summary>
        /// 关联商品
        /// </summary>
        public virtual ICollection<ShangpinRelation> ShangpinRelations { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        public virtual ICollection<ShangpinImg> ShangpinImgs { get; set; }

        /// <summary>
        /// 商品属性
        /// </summary>
        public virtual ICollection<ShangpinAttribute> ShangpinAttributes { get; set; }
    }
}
