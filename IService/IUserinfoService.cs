using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    /// <summary>
    /// 用户
    /// </summary>
    public interface IUserinfoService
    {
        /// <summary>
        /// 根据条件查询用户
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="roleGroup"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        IEnumerable<Userinfo> GetUsers(int grade, int roleGroup, string username, string email, string phone,int index,int size);

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int InsertUser(Userinfo user);

        /// <summary>
        /// 根据编号查询用户
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        Userinfo GetUserById(int id);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        int UpdateUser(Userinfo userinfo);
    }
}
