using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserSet
    {
        /// <summary>
        /// 设置编号
        /// </summary>
        [Display(Name = "设置编号")]
        public int Us_id { get; set; }
        /// <summary>
        ///注册名类型
        /// </summary>
        [Display(Name = "注册名类型")]
        public string Us_registertype { get; set; }
        /// <summary>
        ///登录名类型
        /// </summary>
        [Display(Name = "登录名类型")]
        public string Us_logintype { get; set; }

        /// <summary>
        ///保留用户名
        /// </summary>
        [Display(Name = "保留用户名")]
        public string Us_reserver { get; set; }
        /// <summary>
        ///注册时间限制
        /// </summary>
        [Display(Name = "注册时间限制")]
        public int Us_registertime { get; set; }
        /// <summary>
        ///影子登录名
        /// </summary>
        [Display(Name = "影子登录名")]
        public string Us_shadowuser { get; set; }

        /// <summary>
        ///允许登陆失败次数，如果超过次数 则禁止登陆15分钟
        /// </summary>
        [Display(Name = "允许登陆失败次数，如果超过次数 则禁止登陆15分钟")]
        public string Us_loginerror { get; set; }
        /// <summary>
        ///是否记住密码   0为不记住 1为记住密码
        /// </summary>
        [Display(Name = "是否记住密码")]
        public int Us_rememberpwd { get; set; }
        /// <summary>
        ///是否发送欢迎
        /// </summary>
        [Display(Name = "是否发送欢迎")]
        public int Us_welcome { get; set; }
        /// <summary>
        ///欢迎信息内容
        /// </summary>
        [Display(Name = "欢迎信息内容")]
        public string Us_welcomeinfo { get; set; }
    }
}
