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
        int InsertGroup(string name,List<int> roles);
    }
}
