using Entities;
using IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Areas.Manage.Controllers
{
    public class CycController : Controller
    {
        IRoleService roleService;
        IRoleGroupService RGroupService;
        public CycController(IRoleService roleService,IRoleGroupService RGroupService)
        {
            this.roleService = roleService;
            this.RGroupService = RGroupService;
        }


        #region 管理员权限

        #region 获取所有权限
        /// <summary>
        /// 获取所有权限
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRoles() {
            return Json(roleService.GetRoles());
        }
        #endregion




        /// <summary>
        /// 管理员权限列表
        /// </summary>
        /// <returns></returns>
        public ActionResult RoleGroupList()
        {
            return View();
        }

        /// <summary>
        /// 管理员组编辑
        /// </summary>
        /// <returns></returns>
        public ActionResult EditRoleGroup()
        {
            //判断是新增还是修改
            object edit = Request["edit"];
            if (edit == null)
                return View(0);
            else
                //判断是否存在该管理组
                //不存在则返回回去
                return View(Convert.ToInt32(edit));
        }
        #region 新增管理权限组
        /// <summary>
        /// 新增管理权限组
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertRoleGroup()
        {
            string name = Request["name"];
            List<int> roles = JsonConvert.DeserializeObject<List<int>>(Request["roles"]);


            if (!string.IsNullOrEmpty(name)) {
                return Content(RGroupService.InsertGroup(name,roles).ToString());
            }
            return Content("0");
        }
        #endregion
        #region 获取所有管理权限组
        /// <summary>
        /// 获取所有管理权限组
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRoleGroups()
        {
            return Json(RGroupService.GetRoleGroups());
        }
        #endregion
        #endregion


        #region 新增用户
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertUser()
        {
            return View();
        }
        #endregion


        #region 我的积分
        public ActionResult MyIntegral()
        {
            return View();
        }
        #endregion

        #region 优惠券
        public ActionResult Discounts()
        {
            return View();
        }
        #endregion

        // GET: Manage/Cyc
        public ActionResult Index()
        {
            return View();
        }
    }
}