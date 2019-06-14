using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace YarnViewer.Controllers
{
    public abstract class YarnViewerControllerBase: AbpController
    {
        protected YarnViewerControllerBase()
        {
            LocalizationSourceName = YarnViewerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
