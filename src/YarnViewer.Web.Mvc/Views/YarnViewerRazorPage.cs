using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace YarnViewer.Web.Views
{
    public abstract class YarnViewerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected YarnViewerRazorPage()
        {
            LocalizationSourceName = YarnViewerConsts.LocalizationSourceName;
        }
    }
}
