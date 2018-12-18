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
        //IRepository<UserType> typeRep;
        //IRepository<RoleGroup> RGroupRep;

        public UserinfoService(IUnitofWork unit) {
            this.unit = unit;
            this.userRep = unit.Repository<Userinfo>();
            //this.typeRep = unit.Repository<UserType>();
            //this.RGroupRep = unit.Repository<RoleGroup>();
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="grade">等级</param>
        /// <param name="roleGroup">管理组</param>
        /// <param name="username">用户名</param>
        /// <param name="email">邮箱</param>
        /// <param name="phone">电话</param>
        /// <returns></returns>
        public IEnumerable<Userinfo> GetUsers(int grade, int roleGroup, string username, string email, string phone,int index,int size)
        {
            var userDB = userRep.GetDbSet as IEnumerable<Userinfo>;

            //等级
            if (grade != 0) {
                userDB = userDB.Where(x => x.UT_no == grade);
            }
            //管理员组
            if (roleGroup != 0) {
                userDB = userDB.Where(x => x.RG_no == roleGroup);
            }
            //用户名
            if (!string.IsNullOrEmpty(username)) {
                userDB = userDB.Where(x=>x.U_username.Contains(username));
            }
            //邮箱
            if (!string.IsNullOrEmpty(email)) {
                userDB = userDB.Where(x => x.U_email.Contains(email));
            }
            //电话
            if (!string.IsNullOrEmpty(phone)) {
                userDB = userDB.Where(x => x.U_tel.Contains(phone));
            }
            //分页
            userDB = userDB.Skip((index - 1) * size).Take(size);

            return userDB.ToList();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int InsertUser(Userinfo user)
        {
            userRep.Insert(user);
            return unit.Commit();
        }
    }
}
