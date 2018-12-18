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
    public class UserCenterService : IUserCenterService
    {
        IUnitofWork unit;
        IRepository<UserAddress> addressRep;

        public UserCenterService(IUnitofWork unit)
        {
            this.unit = unit;
            addressRep = unit.Repository<UserAddress>();
        }

        /// <summary>
        /// 新增收货地址
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public int InsertAddress(UserAddress address)
        {
            addressRep.Insert(address);
            return unit.Commit();
        }
    }
}
