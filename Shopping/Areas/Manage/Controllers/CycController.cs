using AutoMapper;
using Entities;
using IService;
using Newtonsoft.Json;
using Shopping.Areas.Manage.Models;
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
        IRoleContactService contactService;
        IUserinfoService userService;
        ICuxiaoService cuxiaoService;
        public CycController(IUserinfoService userService, IRoleService roleService, IRoleGroupService RGroupService, IRoleContactService contactService, ICuxiaoService cuxiaoService)
        {
            this.userService = userService;
            this.roleService = roleService;
            this.RGroupService = RGroupService;
            this.contactService = contactService;
            this.cuxiaoService = cuxiaoService;
        }

        #region 视图

        #region 用户
        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        //public ActionResult UserList()
        //{
        //    //用户信息
        //    ViewData["Userinfos"] = JsonConvert.SerializeObject(userService.GetUsers(0, 0, null, null, null, 1, 10));
        //    //管理员组
        //    var RGroups = RGroupService.GetRoleGroups().ToList();
        //    RGroups.Add(new RoleGroup() { RG_no = 0, RG_name = "非管理员" });
        //    ViewData["infos"] = JsonConvert.SerializeObject(new { RGroups = RGroups });

        //    return View();
        //}

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult UserinfoList()
        {
            //用户信息
            var list = Mapper.Map<IEnumerable<UserinfoModel>>(userService.GetUsers(0, 0, null, null, null, 1, 10));
            //管理员组
            ViewData["RGroups"] = new SelectList(RGroupService.GetRoleGroups(), "RG_no", "RG_name");
            return View(list);
        }
        /// <summary>
        /// 编辑用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult EditUserinfo(int? id)
        {
            //管理员组
            ViewData["RGroups"] = new SelectList(RGroupService.GetRoleGroups(), "RG_no", "RG_name");
            //新增
            if (id == null)
                return View();
            //修改
            else
            {
                var user = userService.GetUserById(Convert.ToInt32(id));
                return View(Mapper.Map<UserinfoModel>(user));
            }
        }
        [HttpPost]
        public ActionResult EditUserinfo(UserinfoModel model)
        {
            //管理员组
            ViewData["RGroups"] = new SelectList(RGroupService.GetRoleGroups(), "RG_no", "RG_name");
            //验证
            if (!ModelState.IsValid)
                return View(model);
            int result = 0;
            //修改
            if (model.U_no != null)
            {
                result = userService.UpdateUser(Mapper.Map<Userinfo>(model));
            }
            //新增
            else
            {
                model.U_regtime = DateTime.Now;
                result = userService.InsertUser(Mapper.Map<Userinfo>(model));
            }
            if (result != 0)
                return RedirectToAction("UserinfoList");
            return View(model);
        }

        #endregion

        #region 管理员权限
        /// <summary>
        /// 管理员权限列表
        /// </summary>
        /// <returns></returns>
        public ActionResult RoleGroupList()
        {
            var list = Mapper.Map<IEnumerable<RoleGroupModel>>(RGroupService.GetRoleGroups());
            return View(list);
        }

        /// <summary>
        /// 编辑管理组
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult EditRGroup(int? id)
        {
            ViewData["Roles"] = roleService.GetRoles();
            //新增
            if (id == null)
                return View();
            //修改
            else
            {
                //获取指定权限组
                var RGroup = Mapper.Map<RoleGroupModel>(RGroupService.GetRoleGroup(Convert.ToInt32(id)));
                //获取指定权限组下的所有权限
                ViewData["RolesArr"] = contactService.GetRidByGid(Convert.ToInt32(id));
                return View(RGroup);
            }
        }
        [HttpPost]
        public ActionResult EditRGroup(RoleGroupModel model)
        {
            ViewData["Roles"] = roleService.GetRoles();
            //验证
            if (!ModelState.IsValid)
                return View(model);
            //获取权限
            int[] roles = Array.ConvertAll(Request["Role"].Split(new string[] { ",", "false" }, StringSplitOptions.RemoveEmptyEntries), s => Convert.ToInt32(s));
            int result = 0;
            //修改
            if (model.RG_no != null)
            {
                result = RGroupService.UpdateRoleGroup(Convert.ToInt32(model.RG_no), model.RG_name, roles);
            }
            //新增
            else
                result = RGroupService.InsertGroup(model.RG_name, roles);
            if (result != 0)
                return RedirectToAction("RoleGroupList");
            return View(model);
        }


        #endregion

        #region 促销活动
        /// <summary>
        /// 促销列表
        /// </summary>
        /// <returns></returns>
        public ActionResult CuxiaoList()
        {
            var list = cuxiaoService.GetChuxiao();
            return View(list);
        }

        /// <summary>
        /// 赠品促销/促销列表
        /// </summary>
        /// <returns></returns>
        public ActionResult PromotionList()
        {
            return View();
        }

        /// <summary>
        /// 赠品促销/添加促销
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertComplimentary()
        {
            //获取商品列表
            return View();
        }

        /// <summary>
        /// 满赠促销/添加促销
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult InsertConsumption()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertConsumption(CuxiaoModel cuxiaoModel)
        {
            if (!ModelState.IsValid)
                return View(cuxiaoModel);
            int result = cuxiaoService.InsertCuxiao(Mapper.Map<Cuxiao>(cuxiaoModel));
            if (result != 0)
                return RedirectToAction("CuxiaoList");
            return View(cuxiaoModel);
        }
        #endregion

        #endregion


















        #region 促销活动

        #region 添加促销
        public ActionResult InsertCuxiao()
        {
            string cid = Request["cid"];
            string name = Request["name"];
            string starttime = Request["starttime"];
            string endtime = Request["endtime"];
            string grade = Request["grade"];
            string alimit = Request["alimit"];
            string slimit = Request["slimit"];
            string flag = Request["flag"];


            Cuxiao cuxiao = new Cuxiao()
            {
                S_no = Convert.ToInt32(cid),
                C_name = name,
                C_starttime = Convert.ToDateTime(starttime),
                C_endtime = Convert.ToDateTime(endtime),
                UT_no = Convert.ToInt32(grade),
                C_activity = Convert.ToInt32(alimit),
                C_supplement = Convert.ToInt32(slimit),
                C_flag = Convert.ToInt32(flag)
            };
            int result = cuxiaoService.InsertCuxiao(cuxiao);

            return Content(result.ToString());
        }
        #endregion



        #region 视图

        #region 赠品促销管理
        #region 赠品列表
        public ActionResult Gift()
        {
            return View();
        }
        #endregion
        #endregion

        #region 满赠促销


        #endregion

        #endregion

        #endregion


        #region 管理员权限





        #region 管理权限组增删改

        #region 删除管理权限组
        public ActionResult DeleteRoleGroups()
        {
            int gid = Convert.ToInt32(Request["RGid"]);
            int result = RGroupService.DeleteGroupByGid(gid);
            return Content(result.ToString());
        }
        #endregion
        #endregion



        #endregion


        #region 视图


        #region 新增用户



        #region 新增用户
        public ActionResult InsertUser()
        {
            string username = Request["username"];
            string email = Request["email"];
            string phone = Request["phone"];
            string nick = Request["nick"];
            string password = Request["password"];
            string grade = Request["grade"];
            string rgroup = Request["rgroup"];
            string ji = Request["ji"];
            string name = Request["name"];
            string identity = Request["identity"];
            string date = Request["date"];
            string address = Request["address"];
            string intro = Request["intro"];

            int result = userService.InsertUser(new Userinfo()
            {
                U_username = username,
                U_email = email,
                U_tel = phone,
                U_nick = nick,
                U_password = password,
                UT_no = Convert.ToInt32(string.IsNullOrEmpty(grade) ? "0" : grade),
                RG_no = Convert.ToInt32(string.IsNullOrEmpty(rgroup) ? "0" : rgroup),
                U_ji = Convert.ToInt32(string.IsNullOrEmpty(ji) ? "0" : ji),
                U_name = name,
                U_identity = identity,
                U_birth = Convert.ToDateTime(date),
                U_address = address,
                U_about = intro,
                U_regtime = DateTime.Now,
                U_logintime = DateTime.Now

            });

            return Content(result.ToString());
        }
        #endregion
        #region 获取用户信息
        public ActionResult GetUsers()
        {

            //用户信息
            return Content(JsonConvert.SerializeObject(userService.GetUsers(string.IsNullOrEmpty(Request["grade"]) ? 0 : Convert.ToInt32((Request["grade"])), string.IsNullOrEmpty(Request["rgroup"]) ? 0 : Convert.ToInt32((Request["rgroup"])), Request["username"], Request["email"], Request["phone"], 1, 10)));
        }
        #endregion


        #endregion

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