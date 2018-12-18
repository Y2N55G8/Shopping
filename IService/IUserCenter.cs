using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IUserCenter
    {
        /// <summary>
        /// 添加收货地址
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        int InsertAddress(UserAddress address);
    }
}
