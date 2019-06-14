using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YarnViewer.Roles.Dto;
using YarnViewer.Users.Dto;

namespace YarnViewer.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
