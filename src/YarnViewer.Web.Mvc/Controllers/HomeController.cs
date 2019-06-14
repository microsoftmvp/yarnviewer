using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using YarnViewer.Controllers;

namespace YarnViewer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : YarnViewerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
