using System.Threading.Tasks;
using YarnViewer.Configuration.Dto;

namespace YarnViewer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
