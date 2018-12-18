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
    public class ShangpinServer : IShangpin
    {
        IUnitofWork unit;
        IRepository<Shangpin> ShangRep;
        IRepository<ShangpinAttribute> SARep;

        public ShangpinServer(IUnitofWork unit)
        {
            this.unit = unit;
            ShangRep = unit.Repository<Shangpin>();
            SARep = unit.Repository<ShangpinAttribute>();
        }
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="shangpin"></param>
        /// <returns></returns>
        public int InsertShangpin(Shangpin shangpin)
        {
            ShangRep.Insert(shangpin);
            return unit.Commit();
        }
        /// <summary>
        /// 保存商品属性
        /// </summary>
        /// <param name="shangpinAttributes"></param>
        /// <returns></returns>
        public int InsertShAttribute(IEnumerable<ShangpinAttribute> shangpinAttributes)
        {
            foreach (ShangpinAttribute item in shangpinAttributes)
            {
                SARep.Insert(item);
            }
            return unit.Commit();
        }
        /// <summary>
        /// 查询最新添加的商品id
        /// </summary>
        /// <returns></returns>
        public int LastSh()
        {
            return ShangRep.GetDbSet.LastOrDefault().S_no;
        }
    }
}
