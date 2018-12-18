using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IShangpin
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="shangpin"></param>
        /// <returns></returns>
        int InsertShangpin(Shangpin shangpin);

        /// <summary>
        /// 保存商品属性
        /// </summary>
        /// <param name="shangpinAttributes"></param>
        /// <returns></returns>
        int InsertShAttribute(IEnumerable<ShangpinAttribute> shangpinAttributes);
    }
}
