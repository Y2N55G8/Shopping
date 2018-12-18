using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DhlSet
    {
        /// <summary>
        /// 设置编号
        /// </summary>
        [Display(Name = "设置编号")]
        public int Ds_id { get; set; }
        /// <summary>
        /// 快递公司名称
        /// </summary>
        [Display(Name = "快递公司名称")]
        public string Ds_name { get; set; }
        /// <summary>
        /// 排序 0 1 2 3 int
        /// </summary>
        [Display(Name = "排序 0 1 2 3 int")]
        public int Ds_sort { get; set; }
    }
}
