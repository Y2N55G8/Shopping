using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    /// <summary>
    /// 商品属性分类
    /// </summary>
    public interface IAttributeGroup
    {
        /// <summary>
        /// 获取商品分类
        /// </summary>
        /// <returns></returns>
        IEnumerable<Classfiy> classfiys();
        

        /// <summary>
        /// 根据分类id查找属性分组id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int GroupId(int id);

        /// <summary>
        /// 根据属性组id查找对应属性列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        dynamic attributes(int id);
        
        /// <summary>
        /// 根据属性id查找对应属性值列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       dynamic AttributeValues(int id);

        /// <summary>
        /// 获取商品品牌
        /// </summary>
        /// <returns></returns>
        IEnumerable<Brand> Brands();

        /// <summary>
        /// 根据品牌名称查找商品品牌
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IEnumerable<Brand> BrandsSelect(string name);

       
    }
}
