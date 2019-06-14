using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YarnViewer.MultiTenancy.Dto;

namespace YarnViewer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

