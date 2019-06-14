using System.Threading.Tasks;
using Abp.Application.Services;
using YarnViewer.Sessions.Dto;

namespace YarnViewer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
