using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    public class ZzaController : Controller
    {
        // GET: Zza
        public ActionResult Index()
        {
            return View();
        }

        //购物车
        public ActionResult Shopping()
        {
            return View();
        }
        //无限级分类
        public ActionResult Menu()
        {
            return View();
        }

        //分类管理
        public ActionResult TypeSys()
        {
            return View();
        }
        //分类添加
        public ActionResult TypeIns()
        {
            return View();
        }
    }
}