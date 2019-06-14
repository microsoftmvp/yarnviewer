using Microsoft.AspNetCore.Antiforgery;
using YarnViewer.Controllers;

namespace YarnViewer.Web.Host.Controllers
{
    public class AntiForgeryController : YarnViewerControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
