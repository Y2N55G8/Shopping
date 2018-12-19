using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Areas.Manage.Models
{
    /// <summary>
    /// 管理员权限组
    /// </summary>
    public class RoleGroupModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Display(Name = "编号")]
        public int RG_no { get; set; }
        /// <summary>
        /// 权限组组名
        /// </summary>
        [Display(Name = "名称")]
        public string RG_name { get; set; }
    }
}
