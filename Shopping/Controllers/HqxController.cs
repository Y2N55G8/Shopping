using Entities;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    public class HqxController : Controller
    {
        IUserCenterService userCenter;

        public HqxController(IUserCenterService userCenter)
        {
            this.userCenter = userCenter;
        }
        // GET: Hqx
        public ActionResult Index()
        {
            return View();
        }

        //收货地址
        public ActionResult Address()
        {
            return View();
        }

        public ActionResult InsertAddress()
        {
            //收货人
            string name = Request["name"];
            //收货地址
            string address = Request["address"];
            //手机号码
            string phone = Request["phone"];
            //电子邮箱
            string email = Request["email"];
            //邮编
            string emailcode = Request["emailcode"];
            //是否默认
            int ismain = Convert.ToInt32(Request["ismain"]);
            UserAddress userAddress = new UserAddress
            {
                UA_name = address,
                U_username = name,
                UA_person = name,
                UA_main = ismain,
                UA_tel = phone,
                UA_emailno = emailcode
            };
            var json = new { state = -1, msg = "" };
            if (userCenter.InsertAddress(userAddress) == 1)
            {
                json = new { state = 1, msg = "添加成功" };
            }
            return Json(json);
        }

        //我的收藏
        public ActionResult Collection()
        {
            return View();
        }

        //购物车
        public ActionResult ShopCart()
        {
            return View();
        }

        //个人资料
        public ActionResult Information()
        {
            return View();
        }

        //安全设置
        public ActionResult Safety()
        {
            return View();
        }
    }
}