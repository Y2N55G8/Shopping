using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 管理员权限组
    /// </summary>
    public class RoleGroup
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int RG_no { get; set; }
        /// <summary>
        /// 权限组组名
        /// </summary>
        public string RG_name { get; set; }
    }
}
