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
        IRepository<Cuxiao> CuxiaoRep;

        public CuxiaoService(IUnitofWork unit) {
            this.unit = unit;
            CuxiaoRep = unit.Repository<Cuxiao>();
        }
        /// <summary>
        /// 新增促销
        /// </summary>
        /// <param name="cx"></param>
        /// <returns></returns>
        public int InsertCuxiao(Cuxiao cx)
        {
            CuxiaoRep.Insert(cx);
            return unit.Commit();
        }
    }
}
