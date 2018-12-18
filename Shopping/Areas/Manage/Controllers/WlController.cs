using Entities;
using Service;
using Shopping.Areas.Manage.Models.wl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Areas.Manage.Controllers
{
    public class WlController : Controller
    {
        AttributeGroupServer groupServer;
        ShangpinServer shangpinServer;

        public WlController(AttributeGroupServer groupServer, ShangpinServer shangpinServer)
        {
            this.groupServer = groupServer;
            this.shangpinServer = shangpinServer;
        }

        // GET: Manage/Wl
        public ActionResult Index()
        {
            return View();
        }
        //商品管理 添加商品
        public ActionResult add()
        {
            return View();
        }
        /// <summary>
        /// 加载分类
        /// </summary>
        public ActionResult Classfiy()
        {
           IEnumerable<Classfiy> classfiys = groupServer.classfiys();
            List<Clfiy> clfiys = new List<Clfiy>();
            Clfiy clfiy = new Clfiy();
            clfiys.Add(clfiy);
            foreach (var item in classfiys)
            {
                Clfiy clfiy1 = new Clfiy(item, classfiys.ToList());
                clfiys.Add(clfiy1);
            }

            return Json(clfiys, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 加载商品品牌
        /// </summary>
        /// <returns></returns>
        public ActionResult Brand()
        {
            IEnumerable<Brand> brands = groupServer.Brands();
            return Json(brands, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 选择分类属性
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Attribute()
        {
            int id = Convert.ToInt32(Request.Form["id"]);
            int S_no = groupServer.GroupId(id);
            var list  = groupServer.attributes(S_no);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 加载属性值列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult AttributeValue()
        {
            int id = Convert.ToInt32(Request.Form["id"]);
            return Json(groupServer.AttributeValues(id), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        public ActionResult Save()
        {
            Shangpin shangpin = new Shangpin()
            {
                S_name = Request.Form["S_name"],
                S_number = Request.Form["S_number"],
                C_no = Convert.ToInt32(Request.Form["C_no"]),
                B_no = Convert.ToInt32(Request.Form["B_no"]),
                S_costprice = Convert.ToInt32(Request.Form["S_cb"]),
                S_marketprice = Convert.ToInt32(Request.Form["S_sc"]),
                S_myprice = Convert.ToInt32(Request.Form["S_bd"]),
                S_weight = Convert.ToInt32(Request.Form["S_k"]),
                S_count = Convert.ToInt32(Request.Form["S_kc"]),
                S_max = Convert.ToInt32(Request.Form["S_max"]),
                S_min = Convert.ToInt32(Request.Form["S_min"]),
                S_flag = Convert.ToInt32(Request.Form["S_flag"]),
                S_label = Request.Form["S_label"],
                S_isHot = Convert.ToInt32(Request.Form["S_isHot"]),
                S_order = 0,
                S_xx = null

            };
           int i= shangpinServer.InsertShangpin(shangpin);
            if (i > 0)
            {

                return Json(shangpinServer.LastSh(), JsonRequestBehavior.AllowGet);
            }
            return Json(0);
            
        }

        /// <summary>
        /// 添加商品属性
        /// </summary>
        /// <returns></returns>
        public ActionResult SaveAttribute()
        {
            return View();
        }


    }
}