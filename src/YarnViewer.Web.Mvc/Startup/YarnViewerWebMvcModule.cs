using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YarnViewer.Configuration;

namespace YarnViewer.Web.Startup
{
    [DependsOn(typeof(YarnViewerWebCoreModule))]
    public class YarnViewerWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public YarnViewerWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<YarnViewerNavigationProvider>();
            Configuration.MultiTenancy.IsEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YarnViewerWebMvcModule).GetAssembly());
        }
    }
}
