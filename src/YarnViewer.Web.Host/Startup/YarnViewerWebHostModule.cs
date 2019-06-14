using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YarnViewer.Configuration;

namespace YarnViewer.Web.Host.Startup
{
    [DependsOn(
       typeof(YarnViewerWebCoreModule))]
    public class YarnViewerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public YarnViewerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(YarnViewerWebHostModule).GetAssembly());
        }
    }
}
