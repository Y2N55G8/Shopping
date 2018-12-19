using Core.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    /// <summary>
    /// ef上下文
    /// </summary>
    public class IocDBContext:DbContext
    {
        public IocDBContext() : base("name=Shopping") {
            Database.SetInitializer(new IocInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //用户
            modelBuilder.Configurations.Add(new UserinfoMap());
            //用户类型
            modelBuilder.Configurations.Add(new UserTypeMap());
            //权限
            modelBuilder.Configurations.Add(new RoleMap());
            //管理权限组
            modelBuilder.Configurations.Add(new RoleGroupMap());
            //权限组对应
            modelBuilder.Configurations.Add(new RoleContactMap());
            //属性组
            modelBuilder.Configurations.Add(new AttributeGroupMap());
            //属性
            modelBuilder.Configurations.Add(new AttributeMap());
            //属性值列表
            modelBuilder.Configurations.Add(new AttributeValueMap());
            //品牌分类
            modelBuilder.Configurations.Add(new BrandClassMap());
            //商品品牌
            modelBuilder.Configurations.Add(new BrandMap());
            //商品属性
            modelBuilder.Configurations.Add(new ShangpinAttributeMap());
            //商品
            modelBuilder.Configurations.Add(new ShangpinMap());
            //关联商品
            modelBuilder.Configurations.Add(new ShangpinRelationMap());
            //定时商品
            modelBuilder.Configurations.Add(new ShangpinTimingMap());
            //商品图片
            modelBuilder.Configurations.Add(new ShangponImgMap());
            //分类
            modelBuilder.Configurations.Add(new ClassfiyMap());
            //促销
            modelBuilder.Configurations.Add(new CuxiaoMap());
        }
    }
}
