using Abp.AspNetCore.Mvc.ViewComponents;

namespace YarnViewer.Web.Views
{
    public abstract class YarnViewerViewComponent : AbpViewComponent
    {
        protected YarnViewerViewComponent()
        {
            LocalizationSourceName = YarnViewerConsts.LocalizationSourceName;
        }
    }
}
