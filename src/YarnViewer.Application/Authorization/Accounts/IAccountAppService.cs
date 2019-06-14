using System.Threading.Tasks;
using Abp.Application.Services;
using YarnViewer.Authorization.Accounts.Dto;

namespace YarnViewer.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
