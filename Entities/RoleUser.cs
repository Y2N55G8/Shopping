using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 权限关系
    /// </summary>
    public class RoleUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int RU_no { get; set; }
        /// <summary>
        /// 管理员名
        /// </summary>
        public string A_uid { get; set; }
        /// <summary>
        /// 角色编号
        /// </summary>
        public int R_no { get; set; }
    }
}
