using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace Core.Repository
{
    public class IocInit : DropCreateDatabaseIfModelChanges<IocDBContext>
    {
        protected override void Seed(IocDBContext context)
        {
            #region 用户
            List<Userinfo> userList = new List<Userinfo>()
            {
                new Userinfo(){ U_username = "Cyc",U_password = "111",U_nick = "昵称o",U_ji = 0,U_tel="110",U_email = "ford-chu@qq.com",U_birth = DateTime.Now,U_regtime = DateTime.Now,U_logintime = DateTime.Now,UT_no = 1,UA_no = 1,C_no=1 },
                new Userinfo(){ U_username = "Wl",U_password = "111",U_nick = "吴晓磊",U_ji = 0,U_tel="110",U_email = "111@qq.com",U_birth = DateTime.Now,U_regtime = DateTime.Now,U_logintime = DateTime.Now,UT_no = 1,UA_no = 1,C_no=1 },
                new Userinfo(){ U_username = "Hh",U_password = "111",U_nick = "胡晓航",U_ji = 0,U_tel="110",U_email = "112@qq.com",U_birth = DateTime.Now,U_regtime = DateTime.Now,U_logintime = DateTime.Now,UT_no = 1,UA_no = 1,C_no=1 },
                new Userinfo(){ U_username = "Hqx",U_password = "111",U_nick = "胡晓星",U_ji = 0,U_tel="110",U_email = "113@qq.com",U_birth = DateTime.Now,U_regtime = DateTime.Now,U_logintime = DateTime.Now,UT_no = 1,UA_no = 1,C_no=1 },
                new Userinfo(){ U_username = "Zza",U_password = "111",U_nick = "郑泽安",U_ji = 0,U_tel="110",U_email = "114@qq.com",U_birth = DateTime.Now,U_regtime = DateTime.Now,U_logintime = DateTime.Now,UT_no = 1,UA_no = 1,C_no=1 }
            };
            context.Set<Userinfo>().AddRange(userList);
            #endregion


            #region 权限
            List<Role> roleList = new List<Role>()
            {
                new Role(){ R_name = "导航菜单" },
                new Role(){ R_name = "商品帮助" },
                new Role(){ R_name = "友情链接" },
                new Role(){ R_name = "商城设置" },
                new Role(){ R_name = "禁止IP" },
                new Role(){ R_name = "筛选词" },
                new Role(){ R_name = "商城插件" },
                new Role(){ R_name = "日志管理" },
                new Role(){ R_name = "数据库" },
                new Role(){ R_name = "用户列表" },
                new Role(){ R_name = "会员等级" },
                new Role(){ R_name = "管理员组" },
                new Role(){ R_name = "新闻管理" },
                new Role(){ R_name = "广告管理" },
                new Role(){ R_name = "商品管理" },
                new Role(){ R_name = "促销活动" },
                new Role(){ R_name = "专题管理" },
                new Role(){ R_name = "优惠券" },
                new Role(){ R_name = "订单管理" },
                new Role(){ R_name = "商品评价" },
                new Role(){ R_name = "商品咨询" },
                new Role(){ R_name = "商品品牌" },
                new Role(){ R_name = "商品分类" }
            };
            context.Set<Role>().AddRange(roleList);
            #endregion
        }
    }
}
