using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 优惠券所属
    /// </summary>
    public class FavorableUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int FU_no { get; set; }
        /// <summary>
        /// 优惠券
        /// </summary>
        public string F_no { get; set; }
        /// <summary>
        /// 所属用户名
        /// </summary>
        public string U_username { get; set; }
        /// <summary>
        /// 是否过期(1未过期 2过期)
        /// </summary>
        public int FU_flag { get; set; }
    }
}
