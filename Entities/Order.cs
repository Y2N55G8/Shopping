using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 订单列表
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int O_no { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime O_time { get; set; }
        /// <summary>
        /// 下单用户
        /// </summary>
        public string U_username { get; set; }
        /// <summary>
        /// 订单状态(1退货 2等待付款 3待确认 4已确认 5待发货 6已收货)
        /// </summary>
        public int MyProperty { get; set; }
        /// <summary>
        /// 配送信息编号
        /// </summary>
        public string D_no { get; set; }
        /// <summary>
        /// 支付编号
        /// </summary>
        public string P_no { get; set; }
        /// <summary>
        /// 收获地址
        /// </summary>
        public int UA_no { get; set; }
        /// <summary>
        /// 积分金额
        /// </summary>
        public int O_jfmoney { get; set; }
        /// <summary>
        /// 订单结算金额
        /// </summary>
        public double O_sum { get; set; }
        /// <summary>
        /// 订单明细编号
        /// </summary>
        public string OD_no { get; set; }
        /// <summary>
        /// 最佳收货时间
        /// </summary>
        public DateTime O_goodtime { get; set; }
    }
}
