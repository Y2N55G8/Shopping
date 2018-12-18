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
    public class AttributeGroupServer : IAttributeGroup
    {

        IUnitofWork unit;
        IRepository<Classfiy> ClassRep;
        IRepository<Entities.Attribute> AtRep;
        IRepository<AttributeValue> ValueRep;
        IRepository<Brand> BrandRep;
        IRepository<AttributeGroup> GroupRep;
        


        public AttributeGroupServer(IUnitofWork unit)
        {
            this.unit = unit;
            ClassRep = unit.Repository<Classfiy>();
            AtRep = unit.Repository<Entities.Attribute>();
            ValueRep = unit.Repository<AttributeValue>();
            BrandRep = unit.Repository<Brand>();
            GroupRep = unit.Repository<AttributeGroup>();

        }

        /// <summary>
        /// 根据属性组id查找对应属性列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public dynamic attributes(int id)
        {
            return AtRep.Get(x=>x.AG_no==id).Select(x=>new { A_no=x.A_no,A_name=x.A_name,A_type=x.A_type}).ToList();
        }
        /// <summary>
        /// 根据属性id查找对应属性值列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public dynamic AttributeValues(int id)
        {
            var lis = ValueRep.Get(x => x.A_no == id).Select(x => new { AV_no = x.AV_no, AV_name = x.AV_name }).ToList();
            return lis;
        }
        /// <summary>
        /// 获取商品品牌
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Brand> Brands()
        {
            return BrandRep.Get();
        }
        /// <summary>
        /// 根据品牌名称查找商品品牌
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IEnumerable<Brand> BrandsSelect(string name)
        {
            return BrandRep.Get(x => x.B_name.Contains(name));
        }
        /// <summary>
        /// 获取商品分类
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Classfiy> classfiys()
        {
            return ClassRep.Get();
        }
        /// <summary>
        /// 根据分类id查找属性分组id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GroupId(int id)
        {
           
            return GroupRep.Get(x => x.C_no == id).FirstOrDefault().AG_no;
        }

    
    }
}
