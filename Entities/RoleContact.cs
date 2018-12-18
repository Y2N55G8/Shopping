using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 权限组对应表
    /// </summary>
    public class RoleContact
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int RC_no { get; set; }
        /// <summary>
        /// 权限组编号
        /// </summary>
        public int RG_no { get; set; }
        /// <summary>
        /// 权限编号
        /// </summary>
        public int R_no { get; set; }
    }
}
