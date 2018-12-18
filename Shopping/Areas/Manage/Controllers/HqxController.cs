using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Areas.Manage.Controllers
{
    public class HqxController : Controller
    {
        List<Shangpin> list = new List<Shangpin>
            {
                new Shangpin{S_no=1,S_name="电视",S_isHot=1,S_myprice=100,S_count=1000},
                new Shangpin{S_no=2,S_name="手机",S_isHot=3,S_myprice=200,S_count=500},
                new Shangpin{S_no=3,S_name="电脑",S_isHot=2,S_myprice=300,S_count=600},
                new Shangpin{S_no=4,S_name="平板",S_isHot=1,S_myprice=400,S_count=700},
                new Shangpin{S_no=5,S_name="电视",S_isHot=1,S_myprice=500,S_count=8000},
                new Shangpin{S_no=6,S_name="手机",S_isHot=3,S_myprice=600,S_count=900},
                new Shangpin{S_no=7,S_name="电脑",S_isHot=2,S_myprice=700,S_count=1000},
                new Shangpin{S_no=8,S_name="平板",S_isHot=1,S_myprice=800,S_count=1100}
            };
        List<Shangpin> list2 = new List<Shangpin>();
        // GET: Manage/Hqx
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 回收站
        /// </summary>
        /// <returns></returns>
        public ActionResult Recycle()
        {
            return View();
        }

        public ActionResult RecycleList(string order="asc",string sort= "S_no",int page=1,int rows=10)
        {
            string text = Request["text"];
            if (text!=null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].S_name.Contains(text))
                    {
                        list2.Add(new Shangpin
                        {
                            S_no = list[i].S_no,
                            S_name = list[i].S_name,
                            S_isHot = list[i].S_isHot,
                            S_myprice = list[i].S_myprice,
                            S_count = list[i].S_count
                        });
                    }
                }
                return Json(list2);
            }
            var r = list;
            int t = r.Count();
            if (t>0)
            {
                if (page<=1)
                    r = r.Take(rows).ToList();
                else
                    r = r.Skip((page - 1) * rows).Take(rows).ToList();
            }
            var obj = new { total = t, rows = r.ToArray() };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 评论
        /// </summary>
        /// <returns></returns>
        public ActionResult Comment()
        {
            return View();
        }

    }
}