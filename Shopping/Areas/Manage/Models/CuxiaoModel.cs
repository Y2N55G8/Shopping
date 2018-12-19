using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Areas.Manage.Models
{
    /// <summary>
    /// 促销
    /// </summary>
    public class CuxiaoModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int C_no { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        [Display(Name = "活动名称")]
        public string C_name { get; set; }
        /// <summary>
        /// 促销的商品
        /// </summary>
        [Display(Name = "商品编号")]
        public int S_no { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        [Display(Name = "活动开始时间")]
        public DateTime C_starttime { get; set; }
        /// <summary>
        /// 活动结束时间
        /// </summary>
        [Display(Name = "活动结束时间")]
        public DateTime C_endtime { get; set; }
        /// <summary>
        /// 最低用户类型
        /// </summary>
        [Display(Name = "最低用户类型")]
        public int UT_no { get; set; }
        /// <summary>
        /// 活动额度
        /// </summary>
        [Display(Name = "活动额度")]
        public int C_activity { get; set; }
        /// <summary>
        /// 补充额度
        /// </summary>
        [Display(Name = "补充额度")]
        public int C_supplement { get; set; }
        /// <summary>
        /// 活动状态(1启用 2停止)
        /// </summary>
        [Display(Name = "活动状态")]
        public int C_flag { get; set; }
    }
}
