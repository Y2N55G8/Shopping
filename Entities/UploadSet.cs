using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UploadSet
    {
        /// <summary>
        /// 设置编号
        /// </summary>
        [Display(Name = "设置编号")]
        public int Ups_id { get; set; }
        /// <summary>
        /// 图片类型
        /// </summary>
        [Display(Name = "图片类型")]
        public string Ups_type { get; set; }
        /// <summary>
        /// 图片大小
        /// </summary>
        [Display(Name = "图片大小")]
        public int Ups_size { get; set; }
        /// <summary>
        /// 水印类型
        /// </summary>
        [Display(Name = "水印类型")]
        public int Ups_watermark { get; set; }
        /// <summary>
        /// 品牌缩略图
        /// </summary>
        [Display(Name = "品牌缩略图")]
        public string Ups_brand { get; set; }
        /// <summary>
        /// 商品展示缩略图
        /// </summary>
        [Display(Name = "商品展示缩略图")]
        public string Ups_good { get; set; }  /// <summary>
                                              /// 用户头像缩略图
                                              /// </summary>
        [Display(Name = "用户头像缩略图")]
        public string Ups_head { get; set; }
        /// <summary>
        /// 用户等级缩略图
        /// </summary>
        [Display(Name = "用户等级缩略图")]
        public string Ups_class { get; set; }
    }
}
