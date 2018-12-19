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
    public class CuxiaoService:ICuxiaoService
    {
        IUnitofWork unit;
        IRepository<Cuxiao> cuxiaoRep;

        public CuxiaoService(IUnitofWork unit) {
            this.unit = unit;
            cuxiaoRep = unit.Repository<Cuxiao>();
        }

        /// <summary>
        /// 获取促销列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cuxiao> GetChuxiao()
        {
            return cuxiaoRep.Get();
        }

        /// <summary>
        /// 新增促销
        /// </summary>
        /// <param name="cx"></param>
        /// <returns></returns>
        public int InsertCuxiao(Cuxiao cx)
        {
            cuxiaoRep.Insert(cx);
            return unit.Commit();
        }
    }
}
