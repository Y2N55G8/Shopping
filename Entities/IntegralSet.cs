using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class IntegralSet
    {
        /// <summary>
        /// 设置编号
        /// </summary>
        [Display(Name = "设置编号")]
        public int Is_id { get; set; }
        /// <summary>
        /// 图片类型
        /// </summary>
        [Display(Name = "名称")]
        public string Is_name { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        [Display(Name = "价格")]
        public int Is_price { get; set; }
        /// <summary>
        /// 注册
        /// </summary>
        [Display(Name = "注册")]
        public int Is_register { get; set; }
        /// <summary>
        /// 每天登陆
        /// </summary>
        [Display(Name = "每天登陆")]
        public int Is_login { get; set; }

        /// <summary>
        /// 验证邮箱
        /// </summary>
        [Display(Name = "验证邮箱")]
        public int Is_email { get; set; }
        /// <summary>
        /// 验证手机
        /// </summary>
        [Display(Name = "验证手机")]
        public int Is_phone { get; set; }
        /// <summary>
        /// 完善用户信息
        /// </summary>
        [Display(Name = "完善用户信息")]
        public int Is_evpi { get; set; }
        /// <summary>
        /// 收货  以订单金额的百分比计算
        /// </summary>
        [Display(Name = "收货")]
        public int Is_receiving { get; set; }
        /// <summary>
        /// Int	评价商品
        /// </summary>
        [Display(Name = "Int	评价商品")]
        public int Is_evaluate { get; set; }
        /// <summary>
        /// 每天最大发放
        /// </summary>
        [Display(Name = "每天最大发放")]
        public int Is_maxcount { get; set; }
        /// <summary>
        /// 每笔订单最大使用
        /// </summary>
        [Display(Name = "每笔订单最大使用")]
        public int Is_limit { get; set; }

    }
}
