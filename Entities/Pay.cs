using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 支付信息
    /// </summary>
    public class Pay
    {
        /// <summary>
        /// 支付编号
        /// </summary>
        public string P_no { get; set; }
        /// <summary>
        /// 支付方式(1货到付款 2网上支付)
        /// </summary>
        public int P_methood { get; set; }
        /// <summary>
        /// 支付时间(为空时表示未付款)
        /// </summary>
        public DateTime? P_time { get; set; }
    }
}
