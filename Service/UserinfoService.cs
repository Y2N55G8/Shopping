using Core.Repository;
using Core.UnitofWork;
using Entities;
using IService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserinfoService : IUserinfoService
    {
        IUnitofWork unit;

        IRepository<Userinfo> userRep;
        IRepository<UserType> typeRep;

        public UserinfoService(IUnitofWork unit) {
            this.unit = unit;
            this.userRep = unit.Repository<Userinfo>();
            this.typeRep = unit.Repository<UserType>();
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="grade">等级</param>
        /// <param name="admin">管理组</param>
        /// <param name="username">用户名</param>
        /// <param name="email">邮箱</param>
        /// <param name="phone">电话</param>
        /// <returns></returns>
        public decimal GetUserList(int grade, int admin, string username, string email, string phone,int index,int size)
        {
            var userDB = userRep.GetDbSet as IEnumerable<Userinfo>;
            DbSet<UserType> typeDB = typeRep.GetDbSet;

            //等级
            if (grade != 0) {
                //查询所对应等级的用户类型是否存在
                var userType = typeDB.Where(t => t.UT_rank == grade).FirstOrDefault();
                if (userType != null)
                    userDB = userDB.Where(x => x.UT_no == userType.UT_no);
            }
            //管理员分组
            if (admin != 0) {
                //查询该管理员分组是否存在
                //var
            }
            //用户名
            if (!string.IsNullOrEmpty(username)) {

            }
            //邮箱
            if (!string.IsNullOrEmpty(email)) {

            }
            //电话
            if (!string.IsNullOrEmpty(phone)) {
            }

            return default(decimal);
        }
    }
}
