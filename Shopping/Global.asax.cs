using AutoMapper;
using Core.Repository;
using Core.UnitofWork;
using Entities;
using IService;
using Ninject;
using Ninject.Web.Common.WebHost;
using Service;
using Shopping.Areas.Manage.Models;
using System.Data.Entity;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace Shopping
{
    public class MvcApplication : NinjectHttpApplication
    {
        /// <summary>
        /// mvc配置
        /// </summary>
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(x =>
            {
                //促销
                x.CreateMap<Cuxiao, CuxiaoModel>();
            });
        }
        /// <summary>
        /// 绑定
        /// </summary>
        /// <returns></returns>
        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Bind<DbContext>().To<IocDBContext>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            kernel.Bind<IUnitofWork>().To<UnitofWork>();
            kernel.Bind<IUserinfoService>().To<UserinfoService>();
            kernel.Bind<IRoleService>().To<RoleService>();
            kernel.Bind<IRoleGroupService>().To<RoleGroupService>();
            kernel.Bind<IRoleContactService>().To<RoleContactService>();
            kernel.Bind<IAttributeGroup>().To<AttributeGroupServer>();
            kernel.Bind<IShangpin>().To<ShangpinServer>();
            kernel.Bind<IUserCenterService>().To<UserCenterService>();
            kernel.Bind<ICuxiaoService>().To<CuxiaoService>();
            return kernel;
        }
    }
}
