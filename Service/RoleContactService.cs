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
    public class RoleContactService : IRoleContactService
    {
        IUnitofWork unit;
        IRepository<RoleContact> contactRep;

        public RoleContactService(IUnitofWork unit) {
            this.unit = unit;
            contactRep = unit.Repository<RoleContact>();
        }

        /// <summary>
        /// 根据权限组编号查询所关联的所有权限id
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        public Array GetRidByGid(int gid)
        {
            return contactRep.Get(x => x.RG_no == gid, "", null).Select(x=>x.R_no).ToArray();
        }
    }
}
