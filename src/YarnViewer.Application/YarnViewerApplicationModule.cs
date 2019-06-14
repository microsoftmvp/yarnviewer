using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YarnViewer.Authorization;

namespace YarnViewer
{
    [DependsOn(
        typeof(YarnViewerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class YarnViewerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<YarnViewerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(YarnViewerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
