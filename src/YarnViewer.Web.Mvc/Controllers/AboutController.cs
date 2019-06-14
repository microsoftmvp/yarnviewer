using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using YarnViewer.Controllers;

namespace YarnViewer.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : YarnViewerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
