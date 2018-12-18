using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IRoleContactService
    {
        /// <summary>
        /// 根据权限组编号获取其关联的所有权限id
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        IEnumerable<int> GetRidByGid(int gid);
    }
}
