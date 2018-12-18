using Core.Repository;
using Core.UnitofWork;
using Entities;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RoleService : IRoleService
    {
        IUnitofWork unit;
        IRepository<Role> roleRep;

        public RoleService(IUnitofWork unit) {
            this.unit = unit;
            roleRep = unit.Repository<Role>();
        }
        /// <summary>
        /// 获取管理权限组
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Role> GetRoles()
        {
            return roleRep.Get();
        }
    }
}
