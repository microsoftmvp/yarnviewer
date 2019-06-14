using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using YarnViewer.Configuration.Dto;

namespace YarnViewer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : YarnViewerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
