using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IRoleGroupService
    {
        /// <summary>
        /// 查找所有管理权限组
        /// </summary>
        /// <returns></returns>
        IEnumerable<RoleGroup> GetRoleGroups();
        /// <summary>
        /// 新增管理员组
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        int InsertGroup(string name,Array roles);
        /// <summary>
        /// 根据权限组id查询权限组
        /// </summary>
        /// <param name="RGid"></param>
        /// <returns></returns>
        RoleGroup GetRoleGroup(int RGid);
        /// <summary>
        /// 修改权限组信息
        /// </summary>
        /// <param name="RGid"></param>
        /// <param name="name"></param>
        /// <param name="roles"></param>
        /// <returns></returns>
        int UpdateRoleGroup(int RGid,string name,Array rids);
        /// <summary>
        /// 删除权限组信息
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        int DeleteGroupByGid(int gid);
    }
}
