using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 管理员权限
    /// </summary>
    public class Role
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int R_no { get; set; }
        /// <summary>
        /// 权限名
        /// </summary>
        public string R_name { get; set; }
        /// <summary>
        /// 显示的名称
        /// </summary>
        //public string R_display { get; set; }
    }
}
