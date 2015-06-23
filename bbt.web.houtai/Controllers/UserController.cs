using BBT.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBT.Web.HouTai.Controllers
{
    public class UserController : BBTControllerBase
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// 用户详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail()
        {
            return View();
        }
	}
}