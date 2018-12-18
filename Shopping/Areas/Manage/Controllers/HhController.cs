using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Areas.Manage.Controllers
{
    public class HhController : Controller
    {
        // GET: Manage/Hh
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DaoHang()
        {
            return View();
        }
        public ActionResult AddDaoHang()
        {
            return View();
        }
        /// <summary>
        /// 测试测试 @组长
        /// </summary>
        /// <returns></returns>
        public ActionResult Ceshi()
        {
            return Content("2018年12月19日00:27:50   胡航  网站测试");
        }
        #region/系统设置

        //  站点信息(主要功能：站点信息编辑)

        //商城设置(主要功能：商城设置编辑)

        //账号设置(主要功能：账号设置编辑)

        //上传设置(主要功能：上传设置编辑)

        //积分设置(主要功能：积分设置编辑)

        //配送公司(主要功能：配送公司编辑与删除)
        #endregion

    }
}