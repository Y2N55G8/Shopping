using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MallSet
    {

        /// <summary>
        /// 主键编号
        /// </summary>
        [Display(Name = "主键编号")]
        public int Ms_id { get; set; }
        /// <summary>
        /// 游客能否使用购物车
        /// </summary>
        [Display(Name = "游客能否使用购物车")]
        public int Ms_visitorcar { get; set; }
        /// <summary>
        /// 购物车提交方式
        /// </summary>
        [Display(Name = "购物车提交方式")]
        public int Ms_carsubmit { get; set; }
        /// <summary>
        /// 游客购物车可装商品数量
        /// </summary>
        [Display(Name = "游客购物车可装商品数量")]
        public int Ms_visitorcars { get; set; }
        /// <summary>
        /// 会员购物车可装商品数量
        /// </summary>
        [Display(Name = "会员购物车可装商品数量")]
        public int Ms_vipcars { get; set; }
        /// <summary>
        /// 购物车过期时间
        /// </summary>
        [Display(Name = "购物车过期时间")]
        public int Ms_cartime { get; set; }
        /// <summary>
        /// 订单编号格式
        /// </summary>
        [Display(Name = "订单编号格式")]
        public int Ms_orderid { get; set; }
        /// <summary>
        /// 在线支付过期时间
        /// </summary>
        [Display(Name = "在线支付过期时间")]
        public int Ms_ipay { get; set; }
        /// <summary>
        /// 收货过期时间
        /// </summary>
        [Display(Name = "收货过期时间")]
        public int Ms_receiving { get; set; }
       
        /// <summary>
        /// 浏览历史数量
        /// </summary>
        [Display(Name = "浏览历史数量")]
        public int Ms_history { get; set; }
        /// <summary>
        /// 最大配送地址
        /// </summary>
        [Display(Name = "最大配送地址")]
        public int Ms_address { get; set; }
        /// <summary>
        /// 收藏夹最大容量
        /// </summary>
        [Display(Name = "收藏夹最大容量")]
        public int Ms_favorites { get; set; }

    }
}
