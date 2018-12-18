using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    public class CycController : Controller
    {
        IUserinfoService userService;
        public CycController(IUserinfoService userService)
        {
            this.userService = userService;
        }

        // GET: Cyc
        public ActionResult Index()
        {
            return View();
        }
        #region 个人信息
        [HttpGet]
        public ActionResult Information()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Information(object obj)
        {
            return View();
        }

        #region 获取个人信息
        /// <summary>
        /// 获取个人信息
        /// </summary>
        /// <param name="context"></param>
        public ActionResult GetInformation()
        {

            //用户名

            //会员
            //昵称
            //真实姓名
            //性别
            //身份证号码
            //出生日期
            //详细地址 省 市 区
            //个人简介
            return Json("");
        }
        #endregion
        #endregion

        #region 账号安全
        /// <summary>
        /// 账户安全
        /// </summary>
        /// <returns></returns>
        public ActionResult Safety()
        {
            return View();
        }
        #endregion

        #region 用户列表
        public ActionResult UserList()
        {
            return View();
        }

        #region 获取用户信息
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUserList()
        {
            //根据等级管理员组用户名邮箱手机
            int grade = 0;
            int admin = 0;
            string username = "";
            string email = "";
            string phone = "";
            //等级
            if (Request["grade"] != null)
                grade = Convert.ToInt32(Request["grade"]);
            //管理员组
            if (Request["admin"] != null)
                admin = Convert.ToInt32(Request["admin"]);
            //用户名
            if (Request["username"] != null)
                username = Request["username"].ToString();
            //邮箱
            if (Request["email"] != null)
                email = Request["email"].ToString();
            //手机
            if (Request["phone"] != null)
                phone = Request["phone"].ToString();
            //当前页码数
            int index = Request["phone"] == null ? 1 : Convert.ToInt32(Request["index"]);
            //每页条目数
            int size = Request["size"] == null ? 0 : Convert.ToInt32(Request["size"]);
            return Json(userService.GetUsers(grade,admin,username,email,phone,index,size));
        }
        #endregion

        #endregion

    }
}