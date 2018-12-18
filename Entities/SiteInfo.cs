using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SiteInfo
    {
        /// <summary>
        /// 站点编号  
        /// </summary>
        [Display(Name ="主键")]
        public int Si_id { get; set; }
        /// <summary>
        /// 商城名称
        /// </summary>
        [Display(Name = "商城名称")]
        public string Si_name { get; set; }
        /// <summary>
        /// 网站网址
        /// </summary>
        [Display(Name = "网站网址")]
        public string Si_url { get; set; }
        /// <summary>
        /// 网站标题
        /// </summary>
        [Display(Name = "网站标题")]
        public string Si_title { get; set; }
        /// <summary>
        /// SEO关键字
        /// </summary>
        [Display(Name = "SEO关键字")]
        public string Si_keyword { get; set; }
        /// <summary>
        /// SEO描述
        /// </summary>
        [Display(Name = "SEO描述")]
        public string Si_depict { get; set; }
        /// <summary>
        /// 备案信息
        /// </summary>
        [Display(Name = "备案信息")]
        public string Si_beian { get; set; }
        /// <summary>
        /// 脚本代码
        /// </summary>
        [Display(Name = "脚本代码")]
        public string Si_script { get; set; }
        /// <summary>
        /// 显示版权
        /// </summary>
        [Display(Name = "显示版权")]
        public int Si_copy { get; set; }


        //  public string {get;set;}
        //    public string {get;set;}
        //    public string {get;set;}
        //    public string {get;set;}

        //public int {get;set;}
        //public int {get;set;}
        //public int {get;set;}
        //public int {get;set;}
        //public int {get;set;}
        //public int {get;set;}
    }
}
