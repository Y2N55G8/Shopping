using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface ICuxiaoService
    {
        /// <summary>
        /// 新增促销
        /// </summary>
        /// <param name="cx"></param>
        /// <returns></returns>
        int InsertCuxiao(Cuxiao cx);
        /// <summary>
        /// 获取促销列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<Cuxiao> GetChuxiao();
    }
}
