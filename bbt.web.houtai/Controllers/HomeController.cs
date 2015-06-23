using BBT.BLL.User;
using BBT.BLL.YueSao;
using BBT.Web.Common;
using System.Web.Mvc;

namespace BBT.Web.HouTai.Controllers
{
    public class HomeController : BBTControllerBase
    {
        /// <summary>
        /// 后台管理首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var bll = new UserBLL();
            bll.GetYueSaoList();
            return View();
        }
    }
}