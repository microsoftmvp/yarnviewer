using System.Collections.Generic;
using YarnViewer.Roles.Dto;
using YarnViewer.Users.Dto;

namespace YarnViewer.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
